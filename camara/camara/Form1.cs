using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using AForge.Video;
using System.IO;
using AForge.Video.VFW;
using System.Diagnostics;
using AForge.Vision.Motion;
using System.Threading;

namespace camara
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private const string Keys = "+{PRTSC}";
        private int Tiempo = 0;
        private Bitmap pantalla = null;
        private bool _isRecording = false;
        // variable para la lista de dispositivos
        private FilterInfoCollection Dispositivos;
        //variable para la fuente de video 
        private VideoCaptureDevice FuenteDeVideo;
        //variable para la deteccion 
        MotionDetector detector;
        float NivelDeDeteccion;
        VideoFileWriter writer = new VideoFileWriter();

        ScreenRecorder ffmpeg = new ScreenRecorder();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializar variable detector 
            detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeDeteccion = 0;
            //lista de dispositivos de entrada de video 
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo x in Dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
           
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // establecer el dispositivo seleccionado como fuente 
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            //iniciar el control
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //iniciar recepcion de imagen 
            videoSourcePlayer1.Start();
            writer.Open("test.avi", Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,6, VideoCodec.MPEG4);
            Tiempo = 0;
            timer2.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //detener recepcion de imagen 
            videoSourcePlayer1.SignalToStop();
            Tiempo = 1;
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NivelDeDeteccion = detector.ProcessFrame(image);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text = NivelDeDeteccion.ToString();
            textBox1.Text = string.Format("{0:00.0000}", NivelDeDeteccion);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int width = 320;
            int height = 240;

            // create instance of video writer
            VideoFileWriter writer = new VideoFileWriter();
            // create new video file
            writer.Open("test.avi", width, height, 25, VideoCodec.MPEG4);
            // create a bitmap to save into the video file
            Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            // write 1000 video frames
            for (int i = 0; i < 1000; i++)
            {
                image.SetPixel(i % width, i % height, Color.Red);
                writer.WriteVideoFrame(image);
            }
            writer.Close();



            //Thread T = new Thread(capture);
            //T.Start();

            //string path;

            //try
            //{

            //    path = Path.GetFullPath("video.avi");
            //    this.StartRec(path); 
            //}
            //catch (PathTooLongException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            ////catch (Exception exc)
            ////{
            ////    MessageBox.Show(exc.StackTrace);
            ////}
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            //crear variable Bitmap
            
            // write 1000 video frames
            
            //enviar la pulsación equivalente a May + ImprPant
            SendKeys.SendWait(Keys);
            //asignar al Bitmap el contenido del portapapeles
            pantalla = ((Bitmap)(Clipboard.GetDataObject().GetData("Bitmap")));
            writer.WriteVideoFrame(pantalla);
            Application.DoEvents();
            if (Tiempo == 1)
            {
                writer.Close();
                MessageBox.Show("Fuiste grabado");
                return;
            }
            timer2.Start();
        }
        //void capture()
        //{
        //    while (true)
        //    {
        //        Bitmap bn = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        //        Graphics g = Graphics.FromImage(bn);
        //        g.CopyFromScreen(0, 0, 0, 0, bn.Size);
        //        pictureBox1.Image = bn;
        //    }
        //}



        //private void StartRec(string path)
        //{

        //    if (_isRecording == false)
        //    {
        //        this.SetScreenArea();

        //        this.SetVisible(true);

        //        this._frameCount = 0;

        //        string fullName = string.Format(@"{0}\{1}_{2}.avi", path, Environment.UserName.ToUpper(), DateTime.Now.ToString("d_MMM_yyyy_HH_mm_ssff"));
        //        int BitRate = 1000;
        //        int framerate = 25;
        //        // Save File option
        //        this._writer.Open(
        //            fullName,
        //            this._width,
        //            this._height,
        //            framerate,
        //            VideoCodec.MPEG4,BitRate);

        //        // Start main work
        //        this.StartRecord();
        //    }
        //}
        //private void SetScreenArea()
        //{
        //    // get entire desktop area size
        //    string screenName = @"Select ALL";
        //    if (string.Compare(screenName, @"Select ALL", StringComparison.OrdinalIgnoreCase) == 0)
        //    {
        //        foreach (Screen screen in Screen.AllScreens)
        //        {
        //            this._screenArea = Rectangle.Union(_screenArea, screen.Bounds);
        //        }
        //    }
        //    else
        //    {
        //        this._screenArea = Screen.AllScreens.First(scr => scr.DeviceName.Equals(screenName)).Bounds;
        //        this._width = this._screenArea.Width;
        //        this._height = this._screenArea.Height;
        //    }
        //}

        //private void SetVisible(bool visible)
        //{
        //    this.button1.Enabled = !visible;
        //    this.btnSave.Enabled = visible;
        //    this._isRecording = visible;
        //}

        //private void StartRecord() //Object stateInfo
        //{
        //    // create screen capture video source
        //    this._streamVideo = new ScreenCaptureStream(this._screenArea);

        //    // set NewFrame event handler
        //    this._streamVideo.NewFrame += new NewFrameEventHandler(this.video_NewFrame);

        //    // start the video source
        //    this._streamVideo.Start();

        //    // _stopWatch
        //    this._stopWatch.Start();
        //}

        //private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    if (this._isRecording)
        //    {
        //        this._frameCount++;
        //        this._writer.WriteVideoFrame(eventArgs.Frame);
        //    }
        //    else
        //    {
        //        _stopWatch.Reset();
        //        Thread.Sleep(500);
        //        _streamVideo.SignalToStop();
        //        Thread.Sleep(500);
        //        _writer.Close();
        //    }
        //}
        //private void saveVideo()
        //{
        //    saveAvi = new SaveFileDialog();

        //    if (saveAvi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        int h = captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
        //        int w = captureDevice.VideoDevice.VideoResolution.FrameSize.Width;
        //        writer.Open(saveAvi.FileName, w, h, 25, VideoCodec.Default, 5000000);
        //        writer.WriteVideoFrame(video);

        //        //AVIwriter.Open(saveAvi.FileName, w, h);
        //        butStop.Text = "Stop Record";
        //        //FinalVideo = captureDevice.VideoDevice;
        //        //FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
        //        //FinalVideo.Start();
        //    }
        //}
    }
}
