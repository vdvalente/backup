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
    class ClaseTemperatura : Form
    {
        SerialPort Puerto = new SerialPort("COM2", 9100, Parity.None, 8, StopBits.One);
        public BackgroundWorker cnnBkgWkr { get; set; }
        public int Tiempo { get; set; }
        private System.Windows.Forms.Timer Timer_SensorTemperatura;
        string sArgIn;
        string Temp;
        public delegate void DetectarTemperatura(Single temperatura);
        public DetectarTemperatura Temperatura = null;

        public ClaseTemperatura()
        {
            Timer_SensorTemperatura = new System.Windows.Forms.Timer
            {
                Interval = 100
            };
            Timer_SensorTemperatura.Tick += new EventHandler(this.Timer_SensorTemperatura_Tick);

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
        private void Timer_SensorTemperatura_Tick(object sender, EventArgs e)
        {
            Timer_SensorTemperatura.Enabled = false;
            if (Tiempo != 1)
            {
                try
                {

                    string c;
                    Puerto.Open();
                    Puerto.ReadTimeout = 3000;
                    Temp = Puerto.ReadLine()/*+"°C"*/;
                    c = Temp;
                    int i = c.IndexOf('\r');
                    c = c.Substring(0, c.IndexOf("\r"));
                    string a = c.Replace(".", ",");
                    this.Invoke(Temperatura, Convert.ToSingle(a));
                    Puerto.Close();
                }
                catch (Exception ex)
                {
                    Puerto.Close();
                }
                Timer_SensorTemperatura.Enabled = true;
            }
            else
            {
                Timer_SensorTemperatura.Enabled = false;
            }
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
                Timer_SensorTemperatura.Start();
            else
            {
                Tiempo = 1;
            }
        }
    }
}
