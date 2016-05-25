using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GrossImaging
{
    public partial class GrossImageForm : Form
    {

        public string PrinterName { get { return this.grossImageControl1.PrinterName; } set { this.grossImageControl1.PrinterName = value; } }
        public GrossImageControl GrossImageControl { get { return this.grossImageControl1; } }

        public GrossImageForm()
        {
            InitializeComponent();
            this.grossImageControl1.CloseRequested += new EventHandler(grossImageControl1_CloseRequested);
            this.grossImageControl1.RefreshPowerPath = true;

        }

        void grossImageControl1_CloseRequested(object sender, EventArgs e)
        {
            this.Close();
        }


        public void LoadImage(Image image)
        {
            this.grossImageControl1.Image = image;

        }


        public SpecimenInfo Specimen
        {
            get { return this.grossImageControl1.Specimen; }
            set
            {
                this.grossImageControl1.Specimen = value;
                if (value == null)
                    this.Text = "Gross Image - No PowerPath Specimen Context";
                else
                    this.Text = "Gross Image " + value.ParentCase.Accession + " Specimen " + Specimen.SpecimenLabel + " - " + Specimen.Description;
            }
        }


 

    }
}
