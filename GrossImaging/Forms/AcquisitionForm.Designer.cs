namespace GrossImaging
{
    partial class AcquisitionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canonCameraDisplayControl1 = new GrossImaging.CanonCameraDisplayControl();
            this.specimenInfoControl1 = new GrossImaging.SpecimenInfoControl();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // canonCameraDisplayControl1
            // 
            this.canonCameraDisplayControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canonCameraDisplayControl1.KeepCameraAlive = false;
            this.canonCameraDisplayControl1.Location = new System.Drawing.Point(0, 85);
            this.canonCameraDisplayControl1.Name = "canonCameraDisplayControl1";
            this.canonCameraDisplayControl1.Size = new System.Drawing.Size(884, 577);
            this.canonCameraDisplayControl1.TabIndex = 0;
            // 
            // specimenInfoControl1
            // 
            this.specimenInfoControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.specimenInfoControl1.Location = new System.Drawing.Point(0, 0);
            this.specimenInfoControl1.Name = "specimenInfoControl1";
            this.specimenInfoControl1.Size = new System.Drawing.Size(580, 85);
            this.specimenInfoControl1.Specimen = null;
            this.specimenInfoControl1.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.specimenInfoControl1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 85);
            this.pnlTop.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(770, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AcquisitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.canonCameraDisplayControl1);
            this.Controls.Add(this.pnlTop);
            this.Name = "AcquisitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gross Image Acquisition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcquisitionForm_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CanonCameraDisplayControl canonCameraDisplayControl1;
        private SpecimenInfoControl specimenInfoControl1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
    }
}