using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSCADA.Controlador
{
    class SensorDeHumo : Form
    {
        public BackgroundWorker cnnBkgWkr { get; set; }
        public int Tiempo { get; set; }
        private System.Windows.Forms.Timer Timer_SensorHumo;
        SerialPort Puerto_Serial = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
        string sArgIn;
        string Humo;
        public delegate void DetectarHumo();
        public DetectarHumo SensorHumo = null;

        public SensorDeHumo()
        {
            Timer_SensorHumo = new System.Windows.Forms.Timer
            {
                Interval = 100
            };
            Timer_SensorHumo.Tick += new EventHandler(this.Timer_SensorHumo_Tick);

            cnnBkgWkr = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
        }

        public void InicialLectura(int Aux)
        {
            this.Show();
            this.Hide();

            cnnBkgWkr.DoWork += _cnnBkgWrkr_DoWork;
            cnnBkgWkr.RunWorkerCompleted += _cnnBkgWrkr_RunWorkerCompleted;
            if (Aux == 1)
                cnnBkgWkr.RunWorkerAsync("1");
            else
                cnnBkgWkr.RunWorkerAsync("0");

        }

        private void Timer_SensorHumo_Tick(object sender, EventArgs e)
        {
            Timer_SensorHumo.Enabled = false;
            
            try
            {
                if (Tiempo != 1)
                {
                    string H;
                    Puerto_Serial.Open();
                    Puerto_Serial.ReadTimeout = 3000;
                    Humo = Puerto_Serial.ReadLine();
                    H = Humo;
                    H = H.Replace("\r", "");
                    if (H == "1")
                    {
                        this.Invoke(SensorHumo);
                    }
                    else
                    {
                    }
                    Puerto_Serial.Close();
                }
                else
                {
                    Puerto_Serial.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Puerto_Serial.Close();
            }

            Timer_SensorHumo.Enabled = true;
        }

        private void _cnnBkgWrkr_DoWork(object sender, DoWorkEventArgs workEventArgs)
        {
            sArgIn = (string)workEventArgs.Argument;
            //bool bCnn = (sArgIn == "1");
            //if (bCnn)
            //{
            //}
            //else
            //{
            //}
        }

        private void _cnnBkgWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs connectEventArgs)
        {
            if (sArgIn == "1")
                Timer_SensorHumo.Start();
            else
            {
                Tiempo = 1;
            }
        }
    }
}
