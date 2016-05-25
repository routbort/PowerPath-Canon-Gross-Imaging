using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GrossImaging
{
    public partial class GrossImageControl : UserControl
    {

        private string _PrinterName;
        public string PrinterName { get { return _PrinterName; } set { _PrinterName = value; } }

        public GrossImageControl()
        {
            InitializeComponent();
        }

        public Image Image
        {
            set { this.pbImage.Image = value; }
            get { return this.pbImage.Image; }
        }

        public GrossImageUploader Uploader { get; set; }

        public bool RefreshPowerPath { get; set; }

        public event EventHandler CloseRequested;

        public SpecimenInfo Specimen
        {
            get { return this.specimenInfoControl1.Specimen; }
            set
            {
                this.specimenInfoControl1.Specimen = value;
                this.btnImport.Enabled = (value != null);
                this.btnBoth.Enabled = (value != null);
            }
        }

        private void SignalClose()
        {
            if (this.CloseRequested != null) this.CloseRequested(this, new EventArgs());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void Import()
        {
            if (Uploader == null) throw new ApplicationException("Uploader object not initialized");
            Uploader.ImportPicture(this.specimenInfoControl1.Specimen, this.pbImage.Image, this.RefreshPowerPath);
            SignalClose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SignalClose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }


        private void Print()

        {
            if (PrinterName == null) throw new ApplicationException("Default printer not set");
            string PageHeader = null;
            if (Specimen == null)
                PageHeader = "Image - no context set";
            else
                PageHeader = Specimen.ParentCase.PatientFullName + " (" + Specimen.ParentCase.MRN + ")        " + Specimen.ParentCase.Accession + "        " + Specimen.SpecimenLabel + "-" + Specimen.Description;
            Print(PrinterName, PageHeader);
        
        }
        public void Print(string PrinterName, string PageHeader)
        {
            PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.DocumentName = "PathStation Gross Image Specimen";
            pd.DefaultPageSettings.PrinterSettings.PrinterName = PrinterName;
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Margins.Left = 50;
            pd.DefaultPageSettings.Margins.Right = 50;
            pd.PrintPage += (sender, args) =>
            {
                Font headerFont = new Font("Arial", 16);
                SizeF box = args.Graphics.MeasureString(PageHeader, headerFont);
                Rectangle textRect = args.MarginBounds;
                using (var sf = new StringFormat())
                {
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    args.Graphics.DrawString(PageHeader, headerFont, Brushes.Black, args.PageBounds.Left + (args.PageBounds.Width / 2), box.Height, sf);
                }
                Image i = this.pbImage.Image;
                Rectangle m = args.MarginBounds;
                if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) 
                    m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                else
                    m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                args.Graphics.DrawImage(i, m);
            };
            pd.Print();
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            Print();
            Import();
        }
    }
}
