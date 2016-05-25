namespace GrossImaging
{
    partial class GrossImageForm
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
            this.grossImageControl1 = new GrossImaging.GrossImageControl();
            this.SuspendLayout();
            // 
            // grossImageControl1
            // 
            this.grossImageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossImageControl1.Location = new System.Drawing.Point(0, 0);
            this.grossImageControl1.Name = "grossImageControl1";
            this.grossImageControl1.RefreshPowerPath = false;
            this.grossImageControl1.Size = new System.Drawing.Size(784, 562);
            this.grossImageControl1.Specimen = null;
            this.grossImageControl1.TabIndex = 0;
            // 
            // GrossImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grossImageControl1);
            this.Name = "GrossImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrossImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GrossImageControl grossImageControl1;
    }
}