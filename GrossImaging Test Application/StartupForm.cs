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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            this.txtDomain.Text = Environment.UserDomainName;
            this.txtDomainUsername.Text = Environment.UserName;
        }

        AcquisitionForm f;
        PowerPathWrapper.Powerpath pp;

        private void button3_Click(object sender, EventArgs e)
        {
            if (pp != null)
                pp.CaseContextChanged -= pp_CaseContextChanged;

            pp = new PowerPathWrapper.Powerpath(
                        this.txtServer.Text,
                        this.txtDatabase.Text,
                        this.txtUsername.Text,
                        this.txtPassword.Text,
                        @"C:\Program Files\Tamtron\PowerPath Client\|C:\Program Files (x86)\Tamtron\PowerPath Client\",
                        @"([A-Z][A-Z]?-?)(\d{1,2}-)(\d{1,6})",
                        false,
                        false,
                        true,
                        false
                    );

            pp.CaseContextChanged += new PowerPathWrapper.Powerpath.CaseContextChangedEventHandler(pp_CaseContextChanged);
            pp.RaiseCaseContextChangedEvents(this);
            pp.Start();
        }

        void pp_CaseContextChanged(PowerPathWrapper.PPCase PowerPathCase)
        {
            if (PowerPathCase == null)
            {
                this.lblAccession.Text = "";
                this.lstSpecimens.DataSource = null;
            }
            else
            {
                this.lblAccession.Text = PowerPathCase.Accession;
                PowerPathWrapper.PPCase ppcase = pp.FullPowerPathCase(this.lblAccession.Text, false);
                List<SpecimenInfo> specimens = new List<SpecimenInfo>();
                foreach (PowerPathWrapper.PPSpecimen specimen in ppcase.Specimens)
                {
                    SpecimenInfo si = new SpecimenInfo();
                    si.ParentCase = ppcase;
                    si.ID = specimen.ID;
                    si.SpecimenLabel = specimen.SpecimenLabel;
                    si.Description = specimen.Description;
                    si.PP = pp;
                    specimens.Add(si);
                }
                lstSpecimens.DataSource = specimens;
            }
        }



        private void btnSetContext_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
                f = new AcquisitionForm();
            f.Specimen = (SpecimenInfo) this.lstSpecimens.SelectedItem;
            f.PrinterName = this.txtPrinterName.Text;
            f.Uploader.UploadBasePath = this.txtShareFolder.Text;
            f.Uploader.UploadUsername = this.txtDomainUsername.Text;
            f.Uploader.UploadDomain = this.txtDomain.Text;
            f.Uploader.UploadPassword = this.txtDomainPassword.Text;
            int maxDimension;
            if (Int32.TryParse(this.txtMaximumImageDimension.Text, out maxDimension))
                f.Uploader.MaximumPictureDimension = maxDimension;
            f.Show();
            f.BringToFront();
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstSpecimens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
