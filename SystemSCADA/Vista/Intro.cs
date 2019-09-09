using SystemSCADA.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSCADA.Vista
{
    public partial class Intro : Form
    {
        int Tiempo; /*Variable que en combinacion a la propiedad interval del t_Splash(timer) controla la duracion del splash*/
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            Tiempo = 5;
            t_Splash.Enabled = true;
        }

        private void T_Splash_Tick(object sender, EventArgs e)
        {
            if (Tiempo > 0)
            {
                Tiempo -= 1;
            }
            else
            {
                t_Splash.Enabled = false;
                Form frm;

                claseControlBaseDeDatos DB = new claseControlBaseDeDatos();
                string sParIni = "";

                string sPath = "";
                sPath = Directory.GetCurrentDirectory() + "\\parIni.ini";

                // Lee archivo de parametros. Si no existe lo crea
                if (!System.IO.File.Exists(sPath))
                {
                    using (FileStream fs = File.Create(sPath)) { }
                }

                try
                {
                    StreamReader file = new StreamReader(sPath);
                    if ((sParIni = file.ReadLine()) != null)
                    {
                        file.Close();
                    }
                    else
                    {
                        sParIni = "";
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe el archivo 'parIni.ini' de parámetros iniciales. \n"
                        + ex.Message,"Sistema SCADA", MessageBoxButtons.OK);
                }

                if (sParIni.Trim() == "")
                {
                    frm = new formConexionBD(true);
                }
                else
                {
                    claseControlBaseDeDatos ControlBD = new claseControlBaseDeDatos();
                    claseControlUsuario ControlUsuario = new claseControlUsuario();
                    string sDatPar = ControlBD.DesEncriptar(sParIni);

                    ControlBD.Guardar(
                        ClaseComunes.getCampo(ref sDatPar),
                        ClaseComunes.getCampo(ref sDatPar),
                        ClaseComunes.getCampo(ref sDatPar),
                        ClaseComunes.getCampo(ref sDatPar));
                    if (sDatPar != "")
                    {
                        ControlBD.GuardarERP(
                            Convert.ToInt32(ClaseComunes.getCampo(ref sDatPar)),
                            ClaseComunes.getCampo(ref sDatPar),
                            ClaseComunes.getCampo(ref sDatPar),
                            ClaseComunes.getCampo(ref sDatPar),
                            ClaseComunes.getCampo(ref sDatPar));
                    }

                    //Verificacion de datos de conexión
                    if (!DB.ProbarConeccion() || !DB.ProbarConeccionERP())
                    {
                        frm = new formConexionBD(true);
                    }
                    else
                    {
                        frm = new formLogin();

                    }
                }
                frm.Show();
                Hide();
            }
        }
    }
}
