using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GrossImaging
{
    public partial class CanonCameraDisplayControl : UserControl
    {

        #region Private members

        SDKHandler CameraHandler;
        List<Camera> CamList;
        Bitmap Evf_Bmp;
        int LVBw, LVBh, w, h;
        float LVBratio, LVration;
        bool ResizeNeeded;
        GrossImageUploader _Uploader = new GrossImageUploader();

        #endregion

        #region Events

        public delegate void ImageAcquiredEventHandler (Image image);
        public event ImageAcquiredEventHandler ImageAcquired;

        #endregion

        #region Constructors

        public CanonCameraDisplayControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Initialization and teardown

        private void CanonCameraDisplayControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    SetUI(false);
                    Initialize();
                    this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
                    OpenSession();
                    _Timer.Tick += new EventHandler(_Timer_Tick);
                }
                catch (System.DllNotFoundException ex)
                {
                    MessageBox.Show("Canon EDSDK Dlls not found.  Are they installed in the root of the application directory?");
                }
            }

        }

        void _Timer_Tick(object sender, EventArgs e)
        {
           
            this.lblFPS.Text = _imageCount.ToString() + " FPS";
            _imageCount = 0;
        }

        private void Initialize()
        {
            CameraHandler = new SDKHandler();
            CameraHandler.CameraAdded += new SDKHandler.CameraAddedHandler(CameraHandler_CameraAdded);
            CameraHandler.LiveViewUpdated += new SDKHandler.StreamUpdate(CameraHandler_LiveViewUpdated);
            CameraHandler.CameraHasShutdown += new EventHandler(CameraHandler_CameraHasShutdown);
            CameraHandler.ImageAcquired += new SDKHandler.ImageAcquiredHandler(CameraHandler_ImageAcquired);
            CameraHandler.CaptureError += new SDKHandler.CaptureErrorHandler(CameraHandler_CaptureError);
            CameraHandler.CameraWillShutdownSoon += new EventHandler(CameraHandler_CameraWillShutdownSoon);
            LVBw = LiveViewPicBox.Width;
            LVBh = LiveViewPicBox.Height;
        }

  



        private void OpenSession()
        {
            lbDebug.Items.Add("OpenSession");
            CloseSession();
            CamList = CameraHandler.GetCameraList();
            lbDebug.Items.Add(CamList.Count.ToString() + " cameras detected");

            if (CamList.Count > 1) throw new ApplicationException("More than one camera attached.  This is not currently supported");

            if (CamList.Count != 0)
            {
                CameraHandler.OpenSession(CamList[0]);
                CameraHandler.SetSetting(EDSDK.PropID_SaveTo, (uint)EDSDK.EdsSaveTo.Host);
                CameraHandler.SetCapacity();
                CameraHandler.StartLiveView();
                SetUI(true);
            }
            else
            { SetUI(false); }



        }

        private void CloseSession()
        {
            SetUI(false);
            lbDebug.Items.Add("CloseSession");
            this.Refresh();
            CameraHandler.CloseSession();

        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Deinitialize();
            CameraHandler.Dispose();
        }

        private void Deinitialize()
        {
            CameraHandler.CameraAdded -= CameraHandler_CameraAdded;
            CameraHandler.LiveViewUpdated -= CameraHandler_LiveViewUpdated;
            CameraHandler.CameraHasShutdown -= CameraHandler_CameraHasShutdown;
            CameraHandler.ImageAcquired -= CameraHandler_ImageAcquired;
            CameraHandler.CaptureError -= CameraHandler_CaptureError;
            CameraHandler.CameraWillShutdownSoon -= CameraHandler_CameraWillShutdownSoon;
        }

  
        #endregion

        #region Properties
 
        public bool KeepCameraAlive { get; set; }
        public  GrossImageUploader Uploader { get { return _Uploader; } }


        #endregion

        #region Internal logic


        void CameraHandler_CameraWillShutdownSoon(object sender, EventArgs e)
        {
            lbDebug.Items.Add("Camera shutdown imminent");
            if (this.KeepCameraAlive) CameraHandler.KeepAlive();
        }

        void CameraHandler_CaptureError(EosErrorCode error)
        {
            MessageBox.Show("Error acquiring image: " + error);
            SetButtonState(true);
        }

        private void CameraHandler_ImageAcquired(Image image)
        {
            SetButtonState(true);
            if (this.ImageAcquired != null)
                ImageAcquired(image);
        }

        private void CameraHandler_CameraAdded()
        {
            lbDebug.Items.Add("Camera added detected");
            OpenSession();
        }

        private void CameraHandler_CameraHasShutdown(object sender, EventArgs e)
        {
            lbDebug.Items.Add("Camera shutdown/removal detected");
            CloseSession();
            Initialize();
        }

        private void SetUI(bool Enabled)
        {
            this.pnlCapture.Visible = Enabled;
         //   this.LiveViewPicBox.Visible = Enabled;
          //  this.pnlLiveViewControls.Visible = Enabled;
            //this.listBox1.Enabled = Enabled;
            this.lblStatus.Text = (Enabled) ? "Connected" : "No camera connected";
            this.lblStatus.ForeColor = (Enabled) ? Color.Green : Color.Red;
            this.pnlTop.Visible = (Enabled) ? false : true;
            SetButtonState(Enabled);
            _Timer.Enabled = Enabled;
            _Timer.Interval = 1000;
            if (Enabled)
            {
                _Timer.Start();
                _imageCount = 0;
            }

        }

        delegate void SetButtonStateDelegate(bool Enabled);

        private void SetButtonState(bool Enabled)
        {
            if (this.InvokeRequired)
                this.Invoke(new SetButtonStateDelegate(SetButtonState), Enabled);
            else
            {
                foreach (Control c in this.pnlLiveViewControls.Controls)
                    if (c is Button) c.Enabled = Enabled;

           //     this.btnTakePictureAF.Enabled = Enabled;
             //   this.btnTakePictureNoAF.Enabled = Enabled;
               // this.btnAutoFocus.Enabled = Enabled;
              //  this.btnStdTake.Enabled = Enabled;
            }
        }

        int _imageCount;
      
        System.Windows.Forms.Timer _Timer = new Timer();


        private void CameraHandler_LiveViewUpdated(System.IO.Stream img)
        {
            try
            {
                using (Graphics g = LiveViewPicBox.CreateGraphics())
                {
                    {
                        Evf_Bmp = new Bitmap(img);
                        LVBratio = LVBw / (float)LVBh;
                        LVration = Evf_Bmp.Width / (float)Evf_Bmp.Height;
                        if (LVBratio < LVration)
                        {
                            w = LVBw;
                            h = (int)(LVBw / LVration);
                        }
                        else
                        {
                            w = (int)(LVBh * LVration);
                            h = LVBh;
                        }
                        if (ResizeNeeded)
                        {
                            g.Clear(System.Drawing.SystemColors.Control);
                            ResizeNeeded = false;
                        }
                       
                        g.DrawImage(Evf_Bmp, (LVBw - w) / 2, (LVBh - h) / 2, w, h);
                        _imageCount++;

                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error in LiveView updated - " + ex.Message);
                CameraHandler.StopLiveView();
            }
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            SetButtonState(false);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_Completely);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_OFF);

        }

        private void btnTakePictureNoAF_Click(object sender, EventArgs e)
        {
            SetButtonState(false);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_Completely_NonAF);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_OFF);
        }

        private void AutoFocus()
        {
            SetButtonState(false);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_Halfway);
            CameraHandler.PressShutterButton(EDSDK.EdsShutterButton.CameraCommand_ShutterButton_OFF);
            SetButtonState(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoFocus();
        }

        private void LiveViewPicBox_SizeChanged(object sender, EventArgs e)
        {
            LVBw = LiveViewPicBox.Width;
            LVBh = LiveViewPicBox.Height;
            ResizeNeeded = true;
        }

        #endregion

        private void btnStdTake_Click(object sender, EventArgs e)
        {
            SetButtonState(false);     
            CameraHandler.TakePhoto();

        }

        private void FocusNear3Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near3);
        }

        private void FocusNear2Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near2);
        }

        private void FocusNear1Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near1);
        }

        private void FocusFar1Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far1);
        }

        private void FocusFar2Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far2);
        }

        private void FocusFar3Button_Click(object sender, EventArgs e)
        {
            CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far3);
        }

        private void btnShowHideDebug_Click(object sender, EventArgs e)
        {
            this.pnlDebug.Visible = !this.pnlDebug.Visible;
            SetButtonState(true);
        }


    }
}
