namespace GrossImaging
{
    partial class SpecimenInfoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblAccession = new System.Windows.Forms.Label();
            this.lblSpecimen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(0, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(396, 25);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "MRN";
            // 
            // lblAccession
            // 
            this.lblAccession.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccession.Location = new System.Drawing.Point(0, 25);
            this.lblAccession.Name = "lblAccession";
            this.lblAccession.Size = new System.Drawing.Size(396, 25);
            this.lblAccession.TabIndex = 1;
            this.lblAccession.Text = "Accession";
            // 
            // lblSpecimen
            // 
            this.lblSpecimen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpecimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecimen.Location = new System.Drawing.Point(0, 50);
            this.lblSpecimen.Name = "lblSpecimen";
            this.lblSpecimen.Size = new System.Drawing.Size(396, 25);
            this.lblSpecimen.TabIndex = 2;
            this.lblSpecimen.Text = "Specimen";
            // 
            // SpecimenInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSpecimen);
            this.Controls.Add(this.lblAccession);
            this.Controls.Add(this.lblPatient);
            this.Name = "SpecimenInfoControl";
            this.Size = new System.Drawing.Size(396, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblAccession;
        private System.Windows.Forms.Label lblSpecimen;
    }
}
