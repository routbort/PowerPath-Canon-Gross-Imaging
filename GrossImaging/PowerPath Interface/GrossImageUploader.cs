using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace GrossImaging
{
    public class GrossImageUploader
    {

        const int MAXIMUM_VERSION_INCREMENT = 10;
        const int MAXIMUM_IMAGE_WIDTH = 1000; // Used for downsampling into PowerPath

        public string UploadBasePath { get; set; }
        public string UploadDomain { get; set; }
        public string UploadUsername { get; set; }
        public string UploadPassword { get; set; }
        public int? MaximumPictureDimension { get; set; }


        private Image ResizeImage(Image inputImage, int maximumWidth, int maximumHeight)
        {

            var imageEncoders = ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
            var ratioX = maximumWidth / (double)inputImage.Width;
            var ratioY = maximumHeight / (double)inputImage.Height;
            var ratio = ratioX < ratioY ? ratioX : ratioY;
            var newImageHeight = (int)(inputImage.Height * ratio);
            var newImageWidth = (int)(inputImage.Width * ratio);
            var thumbnail = new Bitmap(newImageWidth, newImageHeight);
            var graphic = Graphics.FromImage(thumbnail);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;
            graphic.DrawImage(inputImage, 0, 0, newImageWidth, newImageHeight);
            return thumbnail;
        }




        public void ImportPicture(SpecimenInfo si, Image AcquiredImage, bool AutoRefreshPowerPathAfterUpload)
        {


            using (SqlConnection cn = new SqlConnection(si.PP.Database.ConnectionString))
            using (SqlCommand sqlCmdCheck = new SqlCommand(@"SELECT COUNT(*)  FROM acc_image (NOLOCK) where acc_specimen_id = @acc_specimen_id and label like @label", cn))
            {
                cn.Open();
                sqlCmdCheck.Parameters.Add(new SqlParameter("@acc_specimen_id", System.Data.SqlDbType.Int, 4));
                sqlCmdCheck.Parameters.Add(new SqlParameter("@label", System.Data.SqlDbType.VarChar, 50));
                SqlCommand c = new SqlCommand("select system_user", cn);
                SqlDataReader rs = c.ExecuteReader();
                rs.Read();
                string user = rs.GetString(0);
                rs.Close();
                sqlCmdCheck.Parameters["@acc_specimen_id"].Value = si.ID;
                sqlCmdCheck.Parameters["@label"].Value = "Image %";
                int initial_version = Convert.ToInt32(sqlCmdCheck.ExecuteScalar());
                if (initial_version == 0) initial_version = 1; //People like numbers to start at 1; they are not programmers I guess
                int final_version = initial_version;
                while (final_version <= initial_version + MAXIMUM_VERSION_INCREMENT)
                {
                    sqlCmdCheck.Parameters["@label"].Value = "Image " + (final_version).ToString();
                    if (Convert.ToInt32(sqlCmdCheck.ExecuteScalar()) == 0) break;
                    final_version++;
                }
                if (final_version >= initial_version + MAXIMUM_VERSION_INCREMENT)
                    throw new ApplicationException("Maximum number of imported automatic grossing labels exceeded");
                GrossImage image = new GrossImage();
                image.FullImage = AcquiredImage;
                SqlCommand sqlCmdAddImage = new SqlCommand("stpc_pathstation_insert_case_image_mdacc", cn);
                sqlCmdAddImage.CommandType = CommandType.StoredProcedure;
                sqlCmdAddImage.Parameters.AddWithValue("@image_type_id", 1);

                //determine if we need to downsize
                float aspectRatio = (float)image.FullImage.Width / image.FullImage.Height;

                Image finalImage = image.FullImage;

                if (this.MaximumPictureDimension.HasValue)
                    if (image.FullImage.Width > this.MaximumPictureDimension.Value || image.FullImage.Height > this.MaximumPictureDimension.Value)
                        finalImage = ResizeImage(finalImage, this.MaximumPictureDimension.Value, this.MaximumPictureDimension.Value);

                byte[] finalImageData = GrossImage.ImageToByte2(finalImage);


                //sqlCmdAddImage.Parameters.AddWithValue("@acc_id", si.ParentCase.AccID);
                //Silly but gross images are supposed to have only acc_speciment_id, not acc_id
                //Not sure why this needed a formal constraint


                sqlCmdAddImage.Parameters.AddWithValue("@acc_specimen_id", si.ID);
                sqlCmdAddImage.Parameters.AddWithValue("@data_format", "JPEG");
                sqlCmdAddImage.Parameters.AddWithValue("@label", "Image " + final_version.ToString());
                sqlCmdAddImage.Parameters.AddWithValue("@description", "");
                sqlCmdAddImage.Parameters.AddWithValue("@image_width", finalImage.Width);
                sqlCmdAddImage.Parameters.AddWithValue("@image_height", finalImage.Height);
                sqlCmdAddImage.Parameters.AddWithValue("@image_color_depth", System.Drawing.Image.GetPixelFormatSize(image.FullImage.PixelFormat));
                sqlCmdAddImage.Parameters.AddWithValue("@notes", "Imported " + DateTime.Now.ToString("M/d/yyyy hh:mm:ss") + " by " + user);
                sqlCmdAddImage.Parameters.AddWithValue("@include_in_report", "N");
                sqlCmdAddImage.Parameters.AddWithValue("@include_in_internet", "N");
                sqlCmdAddImage.Parameters.AddWithValue("@created_date", DateTime.Now);
                sqlCmdAddImage.Parameters.AddWithValue("@data", finalImageData);
                sqlCmdAddImage.Parameters.AddWithValue("@image_thumbnail", image.ThumbnailImageData);
                if (sqlCmdAddImage.Connection.State != ConnectionState.Open)
                    sqlCmdAddImage.Connection.Open();
                sqlCmdAddImage.ExecuteNonQuery();
                if (AutoRefreshPowerPathAfterUpload)
                {
                    si.PP.RefreshCaseView();
                    si.PP.CurrentCase.Tabs["Images"].Select();
                }

                if (UploadBasePath != null && UploadBasePath != "")
                    using (UNCAccessWithCredentials unc = new UNCAccessWithCredentials())
                        if (unc.NetUseWithCredentials(UploadBasePath, UploadUsername, UploadDomain, UploadPassword))
                        {
                            string PatientDir = Path.Combine(UploadBasePath, si.ParentCase.MRN);
                            string CaseDir = Path.Combine(PatientDir, si.ParentCase.Accession);
                            string CaseThumbnailDir = Path.Combine(CaseDir, "Thumb");
                            if (!Directory.Exists(CaseThumbnailDir))
                                Directory.CreateDirectory(CaseThumbnailDir);
                            string ImageFilename = si.ParentCase.Accession + " " + si.SpecimenLabel + " Image " + final_version.ToString() + ".jpg";
                            string ImagePath = Path.Combine(CaseDir, ImageFilename);
                            string ThumbPath = Path.Combine(CaseThumbnailDir, ImageFilename);
                            image.FullImage.Save(ImagePath);
                            image.ThumbnailImage.Save(ThumbPath);
                        }
                        else
                            throw new ApplicationException("Unable to save image to path " + UploadBasePath + System.Environment.NewLine + "Error " + unc.LastError.ToString());




            }





        }



    }


}
