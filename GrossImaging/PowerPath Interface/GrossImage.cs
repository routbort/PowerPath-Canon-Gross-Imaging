using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;


namespace GrossImaging
{
    public class GrossImage
    {
        Image _FullImage = null;
        Image _ThumbnailImage = null;

        public Image FullImage { get { return _FullImage; } set { _FullImage = value; RebuildThumbnail(); } }
        public Image ThumbnailImage { get { return _ThumbnailImage; } }
        public byte[] FullImageData { get { return ImageToByte2(_FullImage); } }
        public byte[] ThumbnailImageData { get { return ImageToByte2(_ThumbnailImage); } }

        public static byte[] ImageToByte2(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Close();
                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        private void RebuildThumbnail()
        {
            _ThumbnailImage = _FullImage.GetThumbnailImage(225, 150, null, IntPtr.Zero);
        }



    }
}
