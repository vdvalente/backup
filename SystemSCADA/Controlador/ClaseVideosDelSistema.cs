using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using SystemSCADA.Vista;
using SystemSCADA.Modelo;
using AForge.Video.FFMPEG;


namespace SystemSCADA.Controlador
{
    class ClaseVideosDelSistema : Form 
    {
        /*****************************************************************************************************************************************************
        Descripcion: Conexion a la base de datos
        *****************************************************************************************************************************************************/
        static claseMetodosBaseDeDatos conexionBD;
        public static string path { set; get; }
        public static bool status { set; get; }
        public static int idAreadeTrabajo { set; get; }

        public BackgroundWorker cnnBkgWkr { get; set; }
        public int Tiempo { get; set; }

        private const string Keys = "+{PRTSC}";
        
        Bitmap pantalla = null;
        
        VideoFileWriter writer = new VideoFileWriter();

        private System.Windows.Forms.Timer Timer_Grabacion;

        string sArgIn;

        public delegate void DetectarMovi();
        public DetectarMovi Movimiento = null;

        public ClaseVideosDelSistema()
        {
            Timer_Grabacion = new System.Windows.Forms.Timer
            {
                Interval = 100
            };
            Timer_Grabacion.Tick += new EventHandler(this.Timer_Grabacion_Tick);

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
            path = path + ".avi";
            writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);
            cnnBkgWkr.DoWork += _cnnBkgWrkr_DoWork;
            cnnBkgWkr.RunWorkerCompleted += _cnnBkgWrkr_RunWorkerCompleted;
            if(Aux == 1)
                cnnBkgWkr.RunWorkerAsync("1");
            else
                cnnBkgWkr.RunWorkerAsync("0");

        }

        public static void EliminarVideo()
        {
            try
            {
                conexionBD.EjecutarText("DELETE FROM [dbo].[Grabaciones] WHERE Video = '" + path + "'", "Error obteniendo los datos");
            }catch(Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
            }
        }
        public static void setDgrw(ref DataGridView grv, string storeProcedure, string Busqueda = "")
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA,
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
            DataGridViewCheckBoxColumn sts = new DataGridViewCheckBoxColumn();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SqlParameter[] Parametros;
                Parametros = new SqlParameter[0];
                if (Busqueda != "")
                {
                    Parametros = new SqlParameter[1];
                    Parametros[0] = new SqlParameter();
                    Parametros[0].ParameterName = "@Busqueda";
                    Parametros[0].SqlDbType = SqlDbType.VarChar;
                    Parametros[0].Size = 150;
                    Parametros[0].Value = Busqueda;
                }

                grv.DataSource = conexionBD.TablaSP(ref Parametros, storeProcedure, "Error obteniendo los datos");


                grv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold, 0);

                grv.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Nombre"].HeaderText = "Area de Trabajo";
                grv.Columns["Nombre"].ReadOnly = true;
                grv.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grv.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Descripcion"].HeaderText = "Descripcion";
                grv.Columns["Descripcion"].ReadOnly = true;
                grv.Columns["Descripcion"].Width = 360;
                grv.Columns["Video"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Video"].HeaderText = "Ruta del Video";
                grv.Columns["Video"].Width= 390;
                grv.Columns["Video"].ReadOnly = true;
                grv.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grv.Columns["Fecha"].HeaderText = "Fecha";
                grv.Columns["Fecha"].ReadOnly = true;
                grv.Columns["Fecha"].Width = 150;
                grv.Columns.Insert(grv.Columns.Count, btn);
                grv.Columns[grv.Columns.Count - 1].Name = "Ir a la ruta del Video";
                grv.Columns[grv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grv.Columns["Id_AreaDeTrabajo"].Visible = false;
               
            }
            catch (SqlException SQLex)
            {
                MessageBox.Show(SQLex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GuardarVideo()
        {
            conexionBD = new claseMetodosBaseDeDatos(claseControlBaseDeDatos.SQlsistemaSCADA, claseControlBaseDeDatos.SQLNomDBsistemaSCADA, claseControlBaseDeDatos.SQLUsersistemaSCADA,
                claseControlBaseDeDatos.SQLPasssistemaSCADA);
            try
            {
                SqlParameter[] Parametros = new SqlParameter[2];

                Parametros[0] = new SqlParameter();
                Parametros[0].ParameterName = "@Id_AreaDeTrabajo";
                Parametros[0].SqlDbType = SqlDbType.Int;
                Parametros[0].Value = idAreadeTrabajo;

                Parametros[1] = new SqlParameter();
                Parametros[1].ParameterName = "@Video";
                Parametros[1].SqlDbType = SqlDbType.VarChar;
                Parametros[1].Size = 120;
                Parametros[1].Value =@Environment.CurrentDirectory+@"\"+path;

                conexionBD.EjecutarSP(ref Parametros, "dbo.usp_GuardarVideos", "Error guardanto los datos del Perfil");
            }
            catch (SqlException sqlex)
            {
                ClaseComunes.MsjShow(sqlex.Message, 1, 1);
            }
            catch (Exception ex)
            {
                ClaseComunes.MsjShow(ex.Message, 1, 1);
            }
        }
        public static string pathVideo()
        {
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = posibles.Length;
            Random obj = new Random();
            char letra;
            int longitudnuevacadena = 5;
            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                path += letra.ToString();
            }
            return path;
        }


        private void Timer_Grabacion_Tick(object sender, EventArgs e)
        {
            Timer_Grabacion.Stop();
            this.Invoke(Movimiento);
            //crear variable Bitmap
            
            // write 1000 video frames

            //enviar la pulsación equivalente a May + ImprPant
            SendKeys.Send(Keys);
            //asignar al Bitmap el contenido del portapapeles
            pantalla = ((Bitmap)(Clipboard.GetDataObject().GetData("Bitmap")));
            writer.WriteVideoFrame(pantalla);
            //Application.DoEvents();
            if (Tiempo == 1)
            {
                writer.Close();
                MessageBox.Show("Fuiste grabado");
                return;
            }
            Timer_Grabacion.Start();
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
            {
                Tiempo = 0;
                Timer_Grabacion.Start();
            }
            else
            {
                Tiempo = 1;
            }
        }
    }
}
