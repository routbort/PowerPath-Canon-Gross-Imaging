using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrossImaging
{
    public partial class SpecimenInfoControl : UserControl
    {
        public SpecimenInfoControl()
        {
            InitializeComponent();
        }

        SpecimenInfo _Specimen = null;
        public SpecimenInfo Specimen
        {
            get { return _Specimen; }
            set { _Specimen = value; SetUI(); }

        }

        public void SetUI()
        {
            if (Specimen == null)
            {
                this.lblPatient.Text = "No current context";
                this.lblAccession.Text = "Import into PowerPath disabled";
                this.lblSpecimen.Text = "";
                this.lblPatient.ForeColor = Color.Red;
                this.lblAccession.ForeColor = Color.Red;

            }
            else
            {
                this.lblPatient.Text = Specimen.ParentCase.MRN + " " + Specimen.ParentCase.PatientFullName;
                this.lblAccession.Text = Specimen.ParentCase.Accession;
                this.lblSpecimen.Text = Specimen.SpecimenLabel + " - " + Specimen.Description;
                this.lblPatient.ForeColor = Color.Black;
                this.lblAccession.ForeColor = Color.Black;
            }
        }


    }
}
