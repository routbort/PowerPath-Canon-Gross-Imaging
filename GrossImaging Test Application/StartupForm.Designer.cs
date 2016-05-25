namespace GrossImaging
{
    partial class StartupForm
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
            this.btnSetContext = new System.Windows.Forms.Button();
            this.lstSpecimens = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblAccession = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomainUsername = new System.Windows.Forms.TextBox();
            this.txtDomainPassword = new System.Windows.Forms.TextBox();
            this.txtShareFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaximumImageDimension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetContext
            // 
            this.btnSetContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetContext.Location = new System.Drawing.Point(389, 260);
            this.btnSetContext.Name = "btnSetContext";
            this.btnSetContext.Size = new System.Drawing.Size(245, 35);
            this.btnSetContext.TabIndex = 0;
            this.btnSetContext.Text = "GO";
            this.btnSetContext.UseVisualStyleBackColor = true;
            this.btnSetContext.Click += new System.EventHandler(this.btnSetContext_Click);
            // 
            // lstSpecimens
            // 
            this.lstSpecimens.FormattingEnabled = true;
            this.lstSpecimens.Location = new System.Drawing.Point(391, 87);
            this.lstSpecimens.Name = "lstSpecimens";
            this.lstSpecimens.Size = new System.Drawing.Size(245, 108);
            this.lstSpecimens.TabIndex = 14;
            this.lstSpecimens.SelectedIndexChanged += new System.EventHandler(this.lstSpecimens_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hook/Start Powerpath";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 227);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 20);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Text = "P148577";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(12, 201);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(144, 20);
            this.txtDatabase.TabIndex = 9;
            this.txtDatabase.Text = "Test";
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(12, 175);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(144, 20);
            this.txtServer.TabIndex = 8;
            this.txtServer.Text = "powerpathtest";
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lblAccession
            // 
            this.lblAccession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccession.Location = new System.Drawing.Point(387, 39);
            this.lblAccession.Name = "lblAccession";
            this.lblAccession.Size = new System.Drawing.Size(245, 24);
            this.lblAccession.TabIndex = 15;
            this.lblAccession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(12, 65);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(107, 20);
            this.txtDomain.TabIndex = 16;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "PowerPath login information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDomainUsername
            // 
            this.txtDomainUsername.Location = new System.Drawing.Point(12, 91);
            this.txtDomainUsername.Name = "txtDomainUsername";
            this.txtDomainUsername.Size = new System.Drawing.Size(107, 20);
            this.txtDomainUsername.TabIndex = 18;
            // 
            // txtDomainPassword
            // 
            this.txtDomainPassword.Location = new System.Drawing.Point(12, 117);
            this.txtDomainPassword.Name = "txtDomainPassword";
            this.txtDomainPassword.Size = new System.Drawing.Size(107, 20);
            this.txtDomainPassword.TabIndex = 19;
            this.txtDomainPassword.UseSystemPasswordChar = true;
            // 
            // txtShareFolder
            // 
            this.txtShareFolder.Location = new System.Drawing.Point(12, 39);
            this.txtShareFolder.Name = "txtShareFolder";
            this.txtShareFolder.Size = new System.Drawing.Size(293, 20);
            this.txtShareFolder.TabIndex = 20;
            this.txtShareFolder.Text = "\\\\mymdafiles\\plm8\\Pathology\\Gross Imaging - PathStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Image share information";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(179, 133);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(140, 20);
            this.txtPrinterName.TabIndex = 22;
            this.txtPrinterName.Text = "LIS Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Printer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Max image dimension (for downsample)";
            // 
            // txtMaximumImageDimension
            // 
            this.txtMaximumImageDimension.Location = new System.Drawing.Point(182, 197);
            this.txtMaximumImageDimension.Name = "txtMaximumImageDimension";
            this.txtMaximumImageDimension.Size = new System.Drawing.Size(140, 20);
            this.txtMaximumImageDimension.TabIndex = 24;
            this.txtMaximumImageDimension.Text = "1000";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaximumImageDimension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShareFolder);
            this.Controls.Add(this.txtDomainPassword);
            this.Controls.Add(this.txtDomainUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.lblAccession);
            this.Controls.Add(this.lstSpecimens);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSetContext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartupForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gross Imaging Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetContext;
        private System.Windows.Forms.ListBox lstSpecimens;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblAccession;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomainUsername;
        private System.Windows.Forms.TextBox txtDomainPassword;
        private System.Windows.Forms.TextBox txtShareFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaximumImageDimension;
    }
}