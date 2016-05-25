using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrossImaging
{
    public partial class AcquisitionForm : Form
    {
        public AcquisitionForm()
        {
            InitializeComponent();
            this.canonCameraDisplayControl1.KeepCameraAlive = true;
            this.canonCameraDisplayControl1.ImageAcquired += new CanonCameraDisplayControl.ImageAcquiredEventHandler(canonCameraDisplayControl1_ImageAcquired);
            
        }

        public GrossImageUploader Uploader { get { return this.canonCameraDisplayControl1.Uploader; } }
        public string PrinterName { get; set; }

        List<GrossImageForm> _GrossImageForms = new List<GrossImageForm>();

        void canonCameraDisplayControl1_ImageAcquired(Image image)
        {

            GrossImageForm gif = new GrossImageForm();
            gif.LoadImage(image);
            gif.Specimen = this.Specimen;
            gif.PrinterName = PrinterName;
            gif.GrossImageControl.Uploader = this.Uploader;
            gif.Show();
            _GrossImageForms.Add(gif);
            

        }

        void CloseAllGrossImageForms()
        {
            foreach (GrossImageForm gif in _GrossImageForms)
                if (gif != null && !gif.IsDisposed) gif.Close();
        }

        private void AcquisitionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllGrossImageForms();
        }


        public SpecimenInfo Specimen
        {
            get { return this.specimenInfoControl1.Specimen; }
            set { this.specimenInfoControl1.Specimen = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
