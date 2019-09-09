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
    public partial class formLogin : Form
    {
        int tiempo; /*Variable que en combinacion a la propiedad interval del t_Splash y el t_Acceder(timers) 
                      controla la duracion de la animacion Inicial y la animacion de acceso*/

        //SystemSCADA.Vistas.Fuente fuentes = new SystemSCADA.Vistas.Fuente();
        //List<Control> Objetos = new List<Control>();

        public formLogin()
        {
            InitializeComponent();
        }

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
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Evento Load del Formulario que inicializa la variable Tiempo en 3, activa el t_Splash
        y optiene el tamaño del monitor para ubicar el panel de login en el centro 
        *****************************************************************************************************************************************************/
        private void frm_Login_Load(object sender, EventArgs e)
        {
            tiempo = 3;
            t_splash.Enabled = true;
            txtUsusario.Text = "admin";
            txtContrasena.Text = "admin";
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Evento Tick del t_Splash que se Ejecuta cada 0.15s mientras este activo, si la variable tiempo es mayor a 0 le resta 1 y en caso contrario inactiva el 
        t_Splash y cambia a "true" la propiedad Visible del panel de Login
        *****************************************************************************************************************************************************/
        private void t_splash_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo -= 1;
            }
            else
            {
                t_splash.Enabled = false;
                pnlLogin.Visible = true;
            }
        }


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Click del boton de Acceder, Inicializa la variable Tiempo en 2 y comprueba que los datos del usuario 
        existan y esten correctos usando el metodo "chkUsuario" de la clase "claseControlUsuario" de ser correctos dichos datos 
        cambia la propiedad visible del panel de login a "false" y activa el t_Acceder
        *****************************************************************************************************************************************************/
        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            tiempo = 2;
            //pic_Fondo.Image = Properties.Resources.gifFondo2;
            //pnlLogin.Visible = false;
            // t_Acceder.Enabled = true;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                claseControlUsuario InstanciaUsuario = new claseControlUsuario();
                claseControlUsuario.UserName = txtUsusario.Text.ToString();
                claseControlUsuario.Contraseña = txtContrasena.Text.ToString();

                if (InstanciaUsuario.chkUsuario())
                {
                    pnlLogin.Visible = false;
                    t_Acceder.Enabled = true;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
            }


        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Evento Tick del t_Acceder que se Ejecuta cada 0.1s mientras este activo, si la variable tiempo es mayor a 0 le resta 1 y en caso contrario inactiva el 
        t_Acceder, muestra un mensaje de bienvenido e instancia el formulario principal para mostrarlo y ocultar el formulario de login
        *****************************************************************************************************************************************************/
        private void t_Acceder_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo -= 1;
            }
            else
            {
                t_Acceder.Enabled = false;
                MessageBox.Show("Bienvenido, " + claseUsuarioAct.NombreUsuario + ".", "SistemaSCADA", MessageBoxButtons.OK);

                Form g_ExisteFormulario = Application.OpenForms.OfType<FormInterfaz>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
                if (g_ExisteFormulario != null)
                {
                    if (g_ExisteFormulario.WindowState == FormWindowState.Minimized)
                    {
                        g_ExisteFormulario.WindowState = FormWindowState.Normal;
                    }
                    g_ExisteFormulario.BringToFront();
                }
                else
                {

                    SeleccionDeAreaDeTrabajo frm = new SeleccionDeAreaDeTrabajo();
                    frm.Show();
                }
                Hide();
                txtUsusario.Text = "Usuario...";
                txtUsusario.ForeColor = Color.Gray;

                txtContrasena.Text = "Contraseña...";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
                pnlLogin.Visible = true;
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para borrar el campo usuario a darle enter en el input
        *****************************************************************************************************************************************************/
        private void txt_Ususario_Enter(object sender, EventArgs e)
        {
            if (txtUsusario.Text == "Usuario...")
            {
                txtUsusario.Text = "";
                
                txtUsusario.ForeColor = Color.LightGray;
            }
        }

        /*****************************************************************************************************************************************************
       Nombre del Creador: Victor Valente
       Fecha de Creacion: ----
       Descripcion: Procedimiento para colocar un texto para el caso de que no se pase el mouse por encima del en el input
       *****************************************************************************************************************************************************/
        private void txt_Ususario_Leave(object sender, EventArgs e)
        {
            if (txtUsusario.Text == "")
            {
                txtUsusario.Text = "Usuario...";
                
                txtUsusario.ForeColor = Color.Gray;
            }
        }


        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para borrar el campo al darle enter en el input
        *****************************************************************************************************************************************************/
        private void txt_Contrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña...")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }


        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para colocar un texto para el caso de que no se pase el mouse por encima del en el input
        *****************************************************************************************************************************************************/
        private void txt_Contrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña...";
                
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para salir de la aplicacion
        *****************************************************************************************************************************************************/
        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para minimizar la ventana
        *****************************************************************************************************************************************************/
        private void btn_Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para mostrar la ventana de la conexion de la base de datos para el caso de que no exista una configuracion
        *****************************************************************************************************************************************************/
        private void btnLimpiarConfiEmpresa_Click(object sender, EventArgs e)
        {
            formConexionBD frm = new formConexionBD();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                frm.BringToFront();
            }
        }
        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para validar con el enter, si hay un campo vacio
        *****************************************************************************************************************************************************/
        private void txt_Ususario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsusario.Text.Trim() == "")
                {
                    MessageBox.Show("Se debe especificar el Usuario", "SistemaSCADA", MessageBoxButtons.OK);
                    txtUsusario.Focus();
                }
                else
                {
                    txtContrasena.Focus();
                }
            }
        }

        /*****************************************************************************************************************************************************
        Nombre del Creador: Victor Valente
        Fecha de Creacion: ----
        Descripcion: Procedimiento para validar el input contrasena con el enter
        *****************************************************************************************************************************************************/
        private void txt_Contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtContrasena.Text.Trim() == "")
                {
                    MessageBox.Show("Se debe especificar la Clave de acceso del usuario", "Sistema SCADA", MessageBoxButtons.OK);
                    txtContrasena.Focus();
                }
                else
                {
                    btn_Acceder_Click(this, EventArgs.Empty);
                }
            }

        }

        private void pbMiraContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = false;
        }

        private void pbMiraContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
