using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using AForge.Video.FFMPEG;
using SystemSCADA.Controlador;
using System.IO.Ports;
using System.Media;

namespace SystemSCADA.Vista
{
    public partial class FormInterfaz : Form
    {
        SerialPort Puerto = new SerialPort("COM2", 9100, Parity.None, 8, StopBits.One);
        SerialPort Puerto_Serial = new SerialPort("COM4", 9100, Parity.None, 8, StopBits.One);
        private const string Keys = "+{PRTSC}";
        SoundPlayer Sonido;
        int IdArea;
        VideoFileWriter writer = new VideoFileWriter();
        int Tiempo = 0;
        Bitmap pantalla = null;
        public FormInterfaz(int IdAreaDeTrabajo)
        {
            IdArea = IdAreaDeTrabajo;
            InitializeComponent();
            this.toolTip1.SetToolTip(this.picLuzApagada, "Si esta en gris sin titilar no hay movimiento");
            this.toolTip1.SetToolTip(this.picLuzEncendida, "Si esta en rojo titilando existe movimiento");
        }


        // variable para la lista de dispositivos
        private FilterInfoCollection Dispositivos;
        //variable para la fuente de video 
        private VideoCaptureDevice FuenteDeVideo;
        //variable para la deteccion 
        MotionDetector detector;
        float NivelDeDeteccion;
        int a = 0;

        #region Mover Form
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void moverForm(object sender, MouseEventArgs e)
        {
            if (Cursor == Cursors.Default)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xF012, 0);
            }
        }
        #endregion
 
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void FormInterfaz_Load(object sender, EventArgs e)
        {
            //Inicializar variable detector 
            detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeDeteccion = 0;
            //lista de dispositivos de entrada de video 
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositivos)
            {
                cmbCamara.Items.Add(x.Name);
            }
            cmbCamara.SelectedIndex = 0;
            
            //iniciar recepcion de imagen 
            videoSourcePlayer1.Start();
            string path =ClaseVideosDelSistema.pathVideo();
            path = path + ".avi";
            writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);
            Tiempo = 0;
            Timer_Grabacion.Start();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // establecer el dispositivo seleccionado como fuente 
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[cmbCamara.SelectedIndex].MonikerString);
            //iniciar el control
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //iniciar recepcion de imagen 
            videoSourcePlayer1.Start();
            Timer_Humo.Enabled = true;
            Timer_Temperatura.Enabled = true;
            btnIniciar.Enabled = false;
           
        }

        public void ComunicacionPuertoSerie()
        {

            // Controlamos que el puerto indicado esté operativo
            try
            {
                // Abrimos el puerto serie
                string c;
                Puerto.Open();
                Puerto.ReadTimeout = 3000;
                textBox1.Text = Puerto.ReadLine()/*+"°C"*/;
                c = textBox1.Text;
                int i = c.IndexOf('\r');
                c = c.Substring(0, c.IndexOf("\r"));
                string a = c.Replace(".", ",");
                aGauge1.Value = Convert.ToSingle(a);
                Puerto.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //timer_Temperatura.Enabled = true;
                Puerto.Close();
            }
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            //detener recepcion de imagen 
            videoSourcePlayer1.SignalToStop();
            if (picLuzApagada.Visible == false)
            {
                picLuzApagada.Visible = true;
            }
            btnIniciar.Enabled = true;
            NivelDeDeteccion = 0;
            Timer_Humo.Enabled = false;
            //Timer_Temperatura.Enabled = false;
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NivelDeDeteccion = detector.ProcessFrame(image);
        }
       
        private void Timer_Movimiento_Tick(object sender, EventArgs e)
        {
            if(NivelDeDeteccion > 0.0001)
            {
                picLuzApagada.Visible = !picLuzApagada.Visible;
                
                //SaveRecord();
            }
            else
            {
                picLuzApagada.Visible = true;
            }
        }


        //private void SaveRecord()
        //{
        //    int width = 320;
        //    int height = 240;

        //    // create instance of video writer
        //    VideoFileWriter writer = new VideoFileWriter();
        //    // create new video file
        //    writer.Open("test.avi", width, height, 25, VideoCodec.MPEG4);
        //    // create a bitmap to save into the video file
        //    Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        //    // write 1000 video frames
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        image.SetPixel(i % width, i % height, Color.Red);
        //        writer.WriteVideoFrame(image);
        //    }
        //    writer.Close();
        //}
        private void Timer_Humo_Tick(object sender, EventArgs e)
        {
            Timer_Humo.Enabled = false;
            try
            {
                string H;
                Puerto_Serial.Open();
                Puerto_Serial.ReadTimeout = 1500;
                txtHumo.Text = Puerto_Serial.ReadLine();
                H = txtHumo.Text;
                H = H.Replace("\r", "");
                if (H == "1")
                {
                    Sonido = new SoundPlayer(@"C:\Users\victo\Documents\Victor Daniel\TesisScada\Smoke Alarm.wav");
                    Sonido.Play();
                    txtHumo.Visible = true;
                    txtHumo.Text = "Peligro Incendio";
                    txtHumo.BackColor = Color.Red;
                    switch (a)
                    {
                        case 0:
                            picAlarmaApagada.Visible = true;
                            picAlarmaEncendiendo.Visible = false;
                            picAlarmaEncendida.Visible = false;
                            a = 1;
                            break;
                        case 1:
                            picAlarmaApagada.Visible = false;
                            picAlarmaEncendiendo.Visible = true;
                            picAlarmaEncendida.Visible = false;
                            a = 2;
                            break;
                        case 2:
                            picAlarmaEncendida.Visible = true;
                            picAlarmaEncendiendo.Visible = false;
                            picLuzApagada.Visible = false;
                            a = 0;
                            break;
                    }    
                }
                else
                {
                    txtHumo.Visible = false;
                    picLuzApagada.Visible = true;
                }
                picLuzApagada.Visible = true;
                Puerto_Serial.Close();
                Timer_Humo.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Puerto_Serial.Close();
                Timer_Humo.Enabled = true;
            }
        }

        private void Timer_Temperatura_Tick(object sender, EventArgs e)
        {
            Timer_Temperatura.Enabled = false;
            ComunicacionPuertoSerie();
            Timer_Temperatura.Enabled = true;
        }

        private void Timer_Grabacion_Tick(object sender, EventArgs e)
        {
            Timer_Grabacion.Stop();
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
            Timer_Grabacion.Start();
        }
    }

}
