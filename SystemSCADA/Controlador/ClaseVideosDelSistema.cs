using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
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
        public delegate void Detector(float Movimiento);
        public event Detector detectar;
        public BackgroundWorker cnnBkgWkr { get; set; }
        public BackgroundWorker accBkgWkr { get; set; }
        private const string Keys = "+{PRTSC}";
        int Tiempo = 0;
        Bitmap pantalla = null;
        string sConect;
        private Thread trd;
        
        public ClaseVideosDelSistema()
        {
            
        }


        public void Detectar(float Deteccion)
        {
            if (Deteccion > 0.0001)
            {
                Invoke(detectar, true);
            }
        }
        //public void iniciarVideo(bool Activar)
        //{
        //    if (Activar)
        //    {
        //        string path = pathVideo();
        //        path = path + ".avi";
        //        writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);
        //        cnnBkgWkr = new BackgroundWorker();
        //        cnnBkgWkr.DoWork += _accBkgWrkr_DoWork;
        //        cnnBkgWkr.RunWorkerCompleted += _accBkgWrkr_RunWorkerCompleted;
        //        cnnBkgWkr.RunWorkerAsync(status);
        //    }
        //    else
        //    {
        //        cnnBkgWkr.RunWorkerAsync(status);
        //    }
        //}
        //private void _accBkgWrkr_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    bool sts = (bool)e.Argument;
        //    try
        //    { 
        //        while (sts)
        //        {
        //            //enviar la pulsación equivalente a May + ImprPant
        //            SendKeys.SendWait(Keys);
        //            //asignar al Bitmap el contenido del portapapeles
        //            pantalla = ((Bitmap)(Clipboard.GetDataObject().GetData("Bitmap")));
        //            writer.WriteVideoFrame(pantalla);
        //            Application.DoEvents();
        //        }
        //    }catch(Exception ex)
        //    {
        //        ClaseComunes.MsjShow(ex.Message, 1, 1);
        //    }
        //}
        //private void _accBkgWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs connectEventArgs)
        //{
        //    writer.Close();
        //}

        //private void _cnnBkgWrkr_DoWork(object sender, DoWorkEventArgs workEventArgs)
        //{
        //    string sArgIn = (string)workEventArgs.Argument;
        //    bool bCnn = (sArgIn == "1");
        //    if (bCnn)
        //    {
        //        sConect = "1";
        //        try
        //        {
        //            string path = pathVideo();
        //            path = path + ".avi";
        //            writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);

        //            workEventArgs.Result = "Conexión Exitosa";
        //        }
        //        catch (Exception ex)
        //        {
        //            workEventArgs.Result = ex.HResult;
        //            ClaseComunes.MsjShow(ex.Message, 1, 1, FormAbrir: true);
        //        }
        //    }
        //    else
        //    {
        //        sConect = "0";
        //        try
        //        {
        //            writer.Close();
        //            Application.DoEvents();
        //            workEventArgs.Result = "Desconexión Exitosa";
        //        }
        //        catch (Exception ex)
        //        {
        //            workEventArgs.Result = ex.HResult;
        //            ClaseComunes.MsjShow(ex.Message, 1, 1, FormAbrir: true);
        //        }
        //    }
        //}

        //public void iniciarVideo(bool Activar)
        //{
        //    if (Activar)
        //    {
        //        string path = pathVideo();
        //        path = path + ".avi";
        //        writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);
        //        trd = new Thread(Grabar);
        //        trd.IsBackground = true;
        //    }
        //    else
        //    {
        //        trd = new Thread(Grabar);
        //    }
        //}
        //void Grabar()
        //{
        //    string path = pathVideo();
        //    path = path + ".avi";
        //    writer.Open(path, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 6, VideoCodec.MPEG4);
        //    while (status)
        //    {
        //        //enviar la pulsación equivalente a May + ImprPant
        //        SendKeys.SendWait(Keys);
        //        //asignar al Bitmap el contenido del portapapeles
        //        pantalla = ((Bitmap)(Clipboard.GetDataObject().GetData("Bitmap")));
        //        writer.WriteVideoFrame(pantalla);
        //        Application.DoEvents();
        //    }
        //    writer.Close();
        //}
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

    }
}
