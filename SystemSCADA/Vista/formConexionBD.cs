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
    public partial class formConexionBD : Form
    {
        //Instrancia del controlador 
        claseControlBaseDeDatos ControladorDB = new claseControlBaseDeDatos();
        
        bool Llenando = false;
        bool ModoCerrar;    //Bandera para decidir forma de cerrar la ventana (true = finalizar aplicacion, false = cerrar formulario)
        bool CambioCredencial = false; //Bandera para decidir el reinicio de la aplicacion enc aso de cambiar las credenciales de conexion

        //Variables para el control de la animacion del formulario
        int pnlAct = 1;
        int Tick;

        public formConexionBD(bool ModoCerrar = false)
        {
            InitializeComponent();
            this.ModoCerrar = ModoCerrar;
        }


        /*****************************************************************************************************************************************************
        Nombre del Creador: Melanie Infante
        Fecha de Creacion: 13/09
        Descripcion: Evento de cierre de vista
        *****************************************************************************************************************************************************/
        private void btnCerrarConfiBD_Click(object sender, EventArgs e)
        {
            if (ModoCerrar)
            {
                MessageBox.Show("La aplicacion se cerra", "sistemaSCADA", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                Close();
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Melanie Infante
        Fecha de Creacion: 13/09
        Descripcion: Evento para minimizar la vista
        *****************************************************************************************************************************************************/
        private void btnMinimizarConfiBD_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Melanie Infante
        Fecha de Creacion: 13/09
        Descripcion: Seccion de codigo que permite mover la vista sin necesidad de bordes
        *****************************************************************************************************************************************************/
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

        /*****************************************************************************************************************************************************

        *****************************************************************************************************************************************************/
        private void formConexionBD_Load(object sender, EventArgs e)
        {
            txtServidorSystemSCADAConfiBD.Text = claseControlBaseDeDatos.SQlsistemaSCADA;
            txtBaseDatosSystemSCADAConfiBD.Text = claseControlBaseDeDatos.SQLNomDBsistemaSCADA;
            txtUsuarioSystemSCADAConfiBD.Text = claseControlBaseDeDatos.SQLUsersistemaSCADA;
            txtClaveSystemSCADAConfiBD.Text = claseControlBaseDeDatos.SQLPasssistemaSCADA;
        }
        /*****************************************************************************************************************************************************

        *****************************************************************************************************************************************************/
        private void btnPruebaSystemSCADAConfiBD_Click(object sender, EventArgs e)
        {
            if ((txtServidorSystemSCADAConfiBD.Text.ToUpper() != claseControlBaseDeDatos.SQlsistemaSCADA ||
                txtBaseDatosSystemSCADAConfiBD.Text.ToUpper() != claseControlBaseDeDatos.SQLNomDBsistemaSCADA) && !ModoCerrar)
            {
                CambioCredencial = true;
            }
            ControladorDB.Guardar(
                   txtServidorSystemSCADAConfiBD.Text.ToUpper(),
                   txtBaseDatosSystemSCADAConfiBD.Text.ToUpper(),
                   txtUsuarioSystemSCADAConfiBD.Text,
                   txtClaveSystemSCADAConfiBD.Text);
            if (!ControladorDB.ValidarCampos(1))
                return;

            if (!ControladorDB.ProbarConeccion())
            {
                return;
            }
            if (ControladorDB.ProbarConeccionERP())
            {
                
                if (MessageBox.Show("Prueba de Conexión con Base de Datos Exitosa." +
                "\n\n¿Desea Guardar las Credenciales?", "sistemaSCADA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(CambioCredencial)
                        if (MessageBox.Show("La aplicación se reiniciara al cambiar las credenciales de conexión. \n\n ¿Desea cambiarlas igualmente?","SCADA", MessageBoxButtons.YesNo)
                            ==DialogResult.No)
                        {
                            return;
                        }
                    btnGuardarConfiBD_Click(this, e);
                }
            }
            else
            {
                MessageBox.Show("Prueba de Conexión con Base de Datos Exitosa.", "Scada", MessageBoxButtons.OK);
            }
        }

        private void btnPruebaERPConfiBD_Click(object sender, EventArgs e)
        {
            ControladorDB.Guardar(
                   txtServidorSystemSCADAConfiBD.Text.ToUpper(),
                   txtBaseDatosSystemSCADAConfiBD.Text.ToUpper(),
                   txtUsuarioSystemSCADAConfiBD.Text,
                   txtClaveSystemSCADAConfiBD.Text);
            if (!ControladorDB.ValidarCampos(2))
                return;

            if (!ControladorDB.ProbarConeccionERP())
            {
                return;
            }
            if (ControladorDB.ProbarConeccion())
            {
                
                
                if (MessageBox.Show("Prueba de Conexión con Base de Datos Exitosa." +
                "\n\n¿Desea Guardar las Credenciales?","SCADA", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    btnGuardarConfiBD_Click(this, e);
                }
            }
            else
            {
                MessageBox.Show("Prueba de Conexión con Base de Datos ERP Exitosa.", "SistemaSCADA", MessageBoxButtons.OK);
            }
        }

        /*****************************************************************************************************************************************************

        *****************************************************************************************************************************************************/
        private void btnGuardarConfiBD_Click(object sender, EventArgs e)
        {
            if((txtServidorSystemSCADAConfiBD.Text.ToUpper() != claseControlBaseDeDatos.SQlsistemaSCADA || 
                txtBaseDatosSystemSCADAConfiBD.Text.ToUpper() != claseControlBaseDeDatos.SQLNomDBsistemaSCADA) && !ModoCerrar)
            {
                if(MessageBox.Show("La aplicación se reiniciara al cambiar las credenciales de conexión. /n ¿Desea cambiarlas igualmente?", "SCADA", MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }
                CambioCredencial = true;
            }
            ControladorDB.Guardar(
                    txtServidorSystemSCADAConfiBD.Text.ToUpper(),
                    txtBaseDatosSystemSCADAConfiBD.Text.ToUpper(),
                    txtUsuarioSystemSCADAConfiBD.Text,
                    txtClaveSystemSCADAConfiBD.Text);
            if (!ControladorDB.ValidarCampos(1))
                return;

            if (!ControladorDB.ProbarConeccion() || !ControladorDB.ProbarConeccionERP())
            { return; }

            string sTxtIni = ControladorDB.Encriptar(claseControlBaseDeDatos.SQlsistemaSCADA + ";" 
                + claseControlBaseDeDatos.SQLNomDBsistemaSCADA + ";" + claseControlBaseDeDatos.SQLUsersistemaSCADA + ";" 
                + claseControlBaseDeDatos.SQLPasssistemaSCADA + ";"
                + claseControlBaseDeDatos.ERP.ToString() + ";" + claseControlBaseDeDatos.ServERP + ";" 
                + claseControlBaseDeDatos.NomDBERP + ";" + claseControlBaseDeDatos.UserERP + ";" 
                + claseControlBaseDeDatos.PassERP);
            try
            {
                

                string sPath = "";
                sPath = Directory.GetCurrentDirectory() + "\\parIni.ini";

                StreamWriter file = new System.IO.StreamWriter(sPath);
                file.WriteLine(sTxtIni);
                file.Close();
                
                if (ModoCerrar)
                { 
                    formLogin frm = new formLogin();
                    frm.Show();
                }
                if(CambioCredencial)
                {
                    Application.Restart();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Scada", MessageBoxButtons.OK);
            }
        }


        



        /*****************************************************************************************************************************************************
        Nombre del Creador: Robert Perez Torrelles
        Fecha de Creacion: 8/11/18
        Descripcion: Seccion de codigo que contiene los eventos KeyPress de los textbox del formulario.
        Su funcion es de dar focus al siguiente control en caso de presionar la tecla 'Enter'.
        *****************************************************************************************************************************************************/
        #region Focus al dar enter
        private void txtServidorSystemSCADAConfiBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBaseDatosSystemSCADAConfiBD.Focus();
            }
        }

        private void txtBaseDatosSystemSCADAConfiBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUsuarioSystemSCADAConfiBD.Focus();
            }
        }

        private void txtUsuarioSystemSCADAConfiBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtClaveSystemSCADAConfiBD.Focus();
            }
        }

        private void txtClaveSystemSCADAConfiBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnPruebaSystemSCADAConfiBD.Focus();
            }
        }

        #endregion

       
    }
}



            