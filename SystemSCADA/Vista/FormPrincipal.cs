﻿using System;
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
using SystemSCADA.Modelo;
using System.IO.Ports;
using System.Media;
using System.Threading;

namespace SystemSCADA.Vista
{
    public partial class FormInterfaz : Form
    {
        //SerialPort Puerto = new SerialPort("COM2", 9100, Parity.None, 8, StopBits.One);
        //SerialPort Puerto_Serial = new SerialPort("COM4", 9100, Parity.None, 8, StopBits.One);
        private const string Keys = "+{PRTSC}";
        SoundPlayer Sonido;
        Thread trd; 
        int IdArea;
        ClaseVideosDelSistema video = new ClaseVideosDelSistema();
        SensorDeHumo sensorH = new SensorDeHumo();
        ClaseTemperatura temp = new ClaseTemperatura();
        VideoFileWriter writer = new VideoFileWriter();
        int Tiempo = 0;
        Bitmap pantalla = null;
        bool mensajeEnviado = true;
        string path = ClaseVideosDelSistema.pathVideo();
        public FormInterfaz()
        {
            InitializeComponent();
        }

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
            SeleccionDeAreaDeTrabajo frm = new SeleccionDeAreaDeTrabajo();
            frm.Show();
            this.Hide();
            if (videoSourcePlayer1.IsRunning)
            {
                videoSourcePlayer1.Stop();
                ClaseVideosDelSistema.GuardarVideo();
            } 
            video.InicialLectura(0);
            sensorH.InicialLectura(0);
            temp.InicialLectura(0);
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
            
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // establecer el dispositivo seleccionado como fuente 
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[cmbCamara.SelectedIndex].MonikerString);
            //iniciar el control
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //iniciar recepcion de imagen 
            videoSourcePlayer1.Start();
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            Tiempo = 0;
            ClaseVideosDelSistema.path = path;
            ClaseVideosDelSistema.idAreadeTrabajo = IdArea;
            video.Movimiento = new ClaseVideosDelSistema.DetectarMovi(Deteccion);
            sensorH.SensorHumo = new SensorDeHumo.DetectarHumo(DetectorHumo);
            temp.Temperatura = new ClaseTemperatura.DetectarTemperatura(ComunicacionPuertoSerie);
            video.InicialLectura(1);
            sensorH.InicialLectura(1);
            temp.InicialLectura(1);
            ////video.iniciarVideo(true);
        }
        private void Deteccion()
        {
            if (NivelDeDeteccion > 0.0001)
            {
                picLuzApagada.Visible = !picLuzApagada.Visible;

                //SaveRecord();
            }
            else
            {
                picLuzApagada.Visible = true;
            }
        }
        public void ComunicacionPuertoSerie(Single temp)
        {
            aGauge1.Value = temp;
            textBox1.Text = temp + "C°";
            if (temp >= 55)
            {
                Sonido = new SoundPlayer(@"C:\Users\victo\Documents\Victor Daniel\TesisScada\Smoke Alarm.wav");
                Sonido.Play();
                txtHumo.Visible = true;
                txtHumo.Text = "Peligro Incendio";
                txtHumo.BackColor = Color.Red;

                if (mensajeEnviado)
                {
                    claseMetodosBaseDeDatos conexionDB = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA,
                    claseControlBaseDeDatos.SQLPasssistemaSCADA);
                    string correo = conexionDB.ScalarText("Select email from dbo.Usuario where Perfil_Id = 1", "Error recuperando el dato").Trim().ToString();
                    string area = conexionDB.ScalarText("Select Nombre from dbo.AreaDeTrabajo where Id_AreaDeTrabajo = " + IdArea, "Error buscando el area de trabajo");
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    msg.To.Add(correo);
                    msg.Subject = "SISTEMA SCADA";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;
                    msg.Body = "Se detecto humo por el puerto COM2 en el area de trabajo " + area + " por favor acudir de inmediato";
                    msg.BodyEncoding = System.Text.Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.From = new System.Net.Mail.MailAddress("victordanielvalente92@gmail.com");

                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("victordanielvalente92@gmail.com", "vic92tor");

                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com"; //mail.dominio.com
                    try
                    {
                        cliente.Send(msg);
                        mensajeEnviado = false;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al enviar" + ex.Message);
                    }
                }
            }
            // Controlamos que el puerto indicado esté operativo
            //try
            //{
            //     Abrimos el puerto serie
            //    string c;
            //    Puerto.Open();
            //    Puerto.ReadTimeout = 3000;
            //    textBox1.Text = Puerto.ReadLine()/*+"°C"*/;
            //    c = textBox1.Text;
            //    int i = c.IndexOf('\r');
            //    c = c.Substring(0, c.IndexOf("\r"));
            //    string a = c.Replace(".", ",");
            //    if (Convert.ToDecimal(a) > 55)
            //    {
            //        Sonido = new SoundPlayer(@"C:\Users\victo\Documents\Victor Daniel\TesisScada\Smoke Alarm.wav");
            //        Sonido.Play();
            //        txtHumo.Visible = true;
            //        txtHumo.Text = "Peligro Incendio";
            //        txtHumo.BackColor = Color.Red;
            //    }
            //    aGauge1.Value = Convert.ToSingle(a);
            //    Puerto.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //timer_Temperatura.Enabled = true;
            //    Puerto.Close();
            //}
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            //detener recepcion de imagen 
            videoSourcePlayer1.SignalToStop();
            if (picLuzApagada.Visible == false)
            {
                picLuzApagada.Visible = true;
            }
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
            NivelDeDeteccion = 0;
            ClaseVideosDelSistema.GuardarVideo();
            video.InicialLectura(0);
            sensorH.InicialLectura(0);
            temp.InicialLectura(0);
            //ClaseVideosDelSistema.status = false;
            //video.iniciarVideo(false);

            
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NivelDeDeteccion = detector.ProcessFrame(image);
        }


        //private void Timer_Humo_Tick(object sender, EventArgs e)
        //{
        //    Timer_Humo.Enabled = false;
        //    try
        //    {
        //        string H;
        //        Puerto_Serial.Open();
        //        Puerto_Serial.ReadTimeout = 1500;
        //        txtHumo.Text = Puerto_Serial.ReadLine();
        //        H = txtHumo.Text;
        //        H = H.Replace("\r", "");
        //        if (H == "1")
        //        {
        //            DetectorHumo();
        //        }
        //        else
        //        {
        //            txtHumo.Visible = false;
        //            picLuzApagada.Visible = true;
        //        }
        //        picLuzApagada.Visible = true;
        //        Puerto_Serial.Close();
        //        Timer_Humo.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.Message);
        //        Puerto_Serial.Close();
        //        Timer_Humo.Enabled = true;
        //    }
        //}

        private void  DetectorHumo()
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
            if (mensajeEnviado)
            {
                claseMetodosBaseDeDatos conexionDB = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA,
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
                string correo = conexionDB.ScalarText("Select email from dbo.Usuario where Perfil_Id = 1", "Error recuperando el dato").Trim().ToString();
                string area = conexionDB.ScalarText("Select Nombre from dbo.AreaDeTrabajo where Id_AreaDeTrabajo = " + IdArea, "Error buscando el area de trabajo");
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(correo);
                msg.Subject = "SISTEMA SCADA";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = "Se detecto humo por el puerto COM2 en el area de trabajo "+area +" por favor acudir de inmediato";
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("victordanielvalente92@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("victordanielvalente92@gmail.com", "vic92tor");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com"; //mail.dominio.com
                try
                {
                    cliente.Send(msg);
                    mensajeEnviado = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al enviar" + ex.Message);
                }
                
            }
        }

       
    }

}
