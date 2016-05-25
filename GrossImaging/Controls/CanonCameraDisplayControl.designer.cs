namespace GrossImaging
{
    partial class CanonCameraDisplayControl
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
            this.btnTakePictureAF = new System.Windows.Forms.Button();
            this.pnlCapture = new System.Windows.Forms.Panel();
            this.LiveViewPicBox = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblFPS = new System.Windows.Forms.Label();
            this.btnShowHideDebug = new System.Windows.Forms.Button();
            this.pnlLiveViewControls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FocusNear3Button = new System.Windows.Forms.Button();
            this.FocusFar1Button = new System.Windows.Forms.Button();
            this.FocusFar3Button = new System.Windows.Forms.Button();
            this.FocusNear1Button = new System.Windows.Forms.Button();
            this.FocusNear2Button = new System.Windows.Forms.Button();
            this.btnTakePictureNoAF = new System.Windows.Forms.Button();
            this.FocusFar2Button = new System.Windows.Forms.Button();
            this.btnAutoFocus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbDebug = new System.Windows.Forms.ListBox();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlLiveViewControls.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTakePictureAF
            // 
            this.btnTakePictureAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePictureAF.Location = new System.Drawing.Point(397, 7);
            this.btnTakePictureAF.Name = "btnTakePictureAF";
            this.btnTakePictureAF.Size = new System.Drawing.Size(168, 47);
            this.btnTakePictureAF.TabIndex = 0;
            this.btnTakePictureAF.Text = "Capture - AF";
            this.btnTakePictureAF.UseVisualStyleBackColor = true;
            this.btnTakePictureAF.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // pnlCapture
            // 
            this.pnlCapture.Controls.Add(this.LiveViewPicBox);
            this.pnlCapture.Controls.Add(this.pnlControls);
            this.pnlCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCapture.Location = new System.Drawing.Point(0, 87);
            this.pnlCapture.Name = "pnlCapture";
            this.pnlCapture.Size = new System.Drawing.Size(695, 299);
            this.pnlCapture.TabIndex = 1;
            // 
            // LiveViewPicBox
            // 
            this.LiveViewPicBox.BackColor = System.Drawing.SystemColors.Control;
            this.LiveViewPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiveViewPicBox.Location = new System.Drawing.Point(0, 0);
            this.LiveViewPicBox.Name = "LiveViewPicBox";
            this.LiveViewPicBox.Size = new System.Drawing.Size(695, 184);
            this.LiveViewPicBox.TabIndex = 3;
            this.LiveViewPicBox.TabStop = false;
            this.LiveViewPicBox.SizeChanged += new System.EventHandler(this.LiveViewPicBox_SizeChanged);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblFPS);
            this.pnlControls.Controls.Add(this.btnShowHideDebug);
            this.pnlControls.Controls.Add(this.pnlLiveViewControls);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 184);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(695, 115);
            this.pnlControls.TabIndex = 13;
            // 
            // lblFPS
            // 
            this.lblFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFPS.Location = new System.Drawing.Point(630, 82);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(62, 16);
            this.lblFPS.TabIndex = 20;
            this.lblFPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowHideDebug
            // 
            this.btnShowHideDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHideDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHideDebug.Location = new System.Drawing.Point(650, 6);
            this.btnShowHideDebug.Name = "btnShowHideDebug";
            this.btnShowHideDebug.Size = new System.Drawing.Size(42, 15);
            this.btnShowHideDebug.TabIndex = 18;
            this.btnShowHideDebug.Text = "Debug";
            this.btnShowHideDebug.UseVisualStyleBackColor = true;
            this.btnShowHideDebug.Click += new System.EventHandler(this.btnShowHideDebug_Click);
            // 
            // pnlLiveViewControls
            // 
            this.pnlLiveViewControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLiveViewControls.Controls.Add(this.label1);
            this.pnlLiveViewControls.Controls.Add(this.btnTakePictureAF);
            this.pnlLiveViewControls.Controls.Add(this.FocusNear3Button);
            this.pnlLiveViewControls.Controls.Add(this.FocusFar1Button);
            this.pnlLiveViewControls.Controls.Add(this.FocusFar3Button);
            this.pnlLiveViewControls.Controls.Add(this.FocusNear1Button);
            this.pnlLiveViewControls.Controls.Add(this.FocusNear2Button);
            this.pnlLiveViewControls.Controls.Add(this.btnTakePictureNoAF);
            this.pnlLiveViewControls.Controls.Add(this.FocusFar2Button);
            this.pnlLiveViewControls.Controls.Add(this.btnAutoFocus);
            this.pnlLiveViewControls.Location = new System.Drawing.Point(51, 0);
            this.pnlLiveViewControls.Name = "pnlLiveViewControls";
            this.pnlLiveViewControls.Size = new System.Drawing.Size(573, 115);
            this.pnlLiveViewControls.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manual Focus";
            // 
            // FocusNear3Button
            // 
            this.FocusNear3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear3Button.Location = new System.Drawing.Point(30, 14);
            this.FocusNear3Button.Name = "FocusNear3Button";
            this.FocusNear3Button.Size = new System.Drawing.Size(41, 47);
            this.FocusNear3Button.TabIndex = 9;
            this.FocusNear3Button.Text = "<<<";
            this.FocusNear3Button.UseVisualStyleBackColor = true;
            this.FocusNear3Button.Click += new System.EventHandler(this.FocusNear3Button_Click);
            // 
            // FocusFar1Button
            // 
            this.FocusFar1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar1Button.Location = new System.Drawing.Point(177, 14);
            this.FocusFar1Button.Name = "FocusFar1Button";
            this.FocusFar1Button.Size = new System.Drawing.Size(41, 47);
            this.FocusFar1Button.TabIndex = 12;
            this.FocusFar1Button.Text = ">";
            this.FocusFar1Button.UseVisualStyleBackColor = true;
            this.FocusFar1Button.Click += new System.EventHandler(this.FocusFar1Button_Click);
            // 
            // FocusFar3Button
            // 
            this.FocusFar3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar3Button.Location = new System.Drawing.Point(275, 14);
            this.FocusFar3Button.Name = "FocusFar3Button";
            this.FocusFar3Button.Size = new System.Drawing.Size(41, 47);
            this.FocusFar3Button.TabIndex = 10;
            this.FocusFar3Button.Text = ">>>";
            this.FocusFar3Button.UseVisualStyleBackColor = true;
            this.FocusFar3Button.Click += new System.EventHandler(this.FocusFar3Button_Click);
            // 
            // FocusNear1Button
            // 
            this.FocusNear1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear1Button.Location = new System.Drawing.Point(128, 14);
            this.FocusNear1Button.Name = "FocusNear1Button";
            this.FocusNear1Button.Size = new System.Drawing.Size(41, 47);
            this.FocusNear1Button.TabIndex = 7;
            this.FocusNear1Button.Text = "<";
            this.FocusNear1Button.UseVisualStyleBackColor = true;
            this.FocusNear1Button.Click += new System.EventHandler(this.FocusNear1Button_Click);
            // 
            // FocusNear2Button
            // 
            this.FocusNear2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear2Button.Location = new System.Drawing.Point(79, 14);
            this.FocusNear2Button.Name = "FocusNear2Button";
            this.FocusNear2Button.Size = new System.Drawing.Size(41, 47);
            this.FocusNear2Button.TabIndex = 8;
            this.FocusNear2Button.Text = "<<";
            this.FocusNear2Button.UseVisualStyleBackColor = true;
            this.FocusNear2Button.Click += new System.EventHandler(this.FocusNear2Button_Click);
            // 
            // btnTakePictureNoAF
            // 
            this.btnTakePictureNoAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePictureNoAF.Location = new System.Drawing.Point(397, 61);
            this.btnTakePictureNoAF.Name = "btnTakePictureNoAF";
            this.btnTakePictureNoAF.Size = new System.Drawing.Size(168, 47);
            this.btnTakePictureNoAF.TabIndex = 3;
            this.btnTakePictureNoAF.Text = "Capture - No AF";
            this.btnTakePictureNoAF.UseVisualStyleBackColor = true;
            this.btnTakePictureNoAF.Click += new System.EventHandler(this.btnTakePictureNoAF_Click);
            // 
            // FocusFar2Button
            // 
            this.FocusFar2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar2Button.Location = new System.Drawing.Point(226, 14);
            this.FocusFar2Button.Name = "FocusFar2Button";
            this.FocusFar2Button.Size = new System.Drawing.Size(41, 47);
            this.FocusFar2Button.TabIndex = 11;
            this.FocusFar2Button.Text = ">>";
            this.FocusFar2Button.UseVisualStyleBackColor = true;
            this.FocusFar2Button.Click += new System.EventHandler(this.FocusFar2Button_Click);
            // 
            // btnAutoFocus
            // 
            this.btnAutoFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoFocus.Location = new System.Drawing.Point(88, 64);
            this.btnAutoFocus.Name = "btnAutoFocus";
            this.btnAutoFocus.Size = new System.Drawing.Size(168, 47);
            this.btnAutoFocus.TabIndex = 4;
            this.btnAutoFocus.Text = "AutoFocus";
            this.btnAutoFocus.UseVisualStyleBackColor = true;
            this.btnAutoFocus.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(695, 26);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Camera Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDebug
            // 
            this.lbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDebug.FormattingEnabled = true;
            this.lbDebug.Location = new System.Drawing.Point(0, 0);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(695, 61);
            this.lbDebug.TabIndex = 3;
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.lbDebug);
            this.pnlDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDebug.Location = new System.Drawing.Point(0, 26);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(695, 61);
            this.pnlDebug.TabIndex = 15;
            this.pnlDebug.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(695, 26);
            this.pnlTop.TabIndex = 17;
            // 
            // CanonCameraDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCapture);
            this.Controls.Add(this.pnlDebug);
            this.Controls.Add(this.pnlTop);
            this.Name = "CanonCameraDisplayControl";
            this.Size = new System.Drawing.Size(695, 386);
            this.Load += new System.EventHandler(this.CanonCameraDisplayControl_Load);
            this.pnlCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlLiveViewControls.ResumeLayout(false);
            this.pnlLiveViewControls.PerformLayout();
            this.pnlDebug.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakePictureAF;
        private System.Windows.Forms.Panel pnlCapture;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnTakePictureNoAF;
        private System.Windows.Forms.Button btnAutoFocus;
        private System.Windows.Forms.PictureBox LiveViewPicBox;
        private System.Windows.Forms.Button FocusFar3Button;
        private System.Windows.Forms.Button FocusFar2Button;
        private System.Windows.Forms.Button FocusFar1Button;
        private System.Windows.Forms.Button FocusNear1Button;
        private System.Windows.Forms.Button FocusNear2Button;
        private System.Windows.Forms.Button FocusNear3Button;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDebug;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnShowHideDebug;
        private System.Windows.Forms.Panel pnlLiveViewControls;
        private System.Windows.Forms.Label lblFPS;

    }
}
