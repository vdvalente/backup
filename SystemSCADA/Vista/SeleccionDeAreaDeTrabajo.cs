using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSCADA.Controlador;
using SystemSCADA.Vista;
using System.Windows.Forms;

namespace SystemSCADA.Vista
{
    public partial class SeleccionDeAreaDeTrabajo : Form
    {
        bool respuesta;
        public SeleccionDeAreaDeTrabajo()
        {
            InitializeComponent();
        }
        private void BtnLabComputacion_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(1);
                frm.Show();
            } 
            Hide();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            respuesta = ClaseComunes.MsjShow("¿Seguro que desea salir?",3,2,"SistemaSCADA");
            if (respuesta)
            {
                Application.Exit();
            }
        }
        private void BtnLabElectronica_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(2);
                frm.Show();
            }
            Hide();
        }

        private void BtnSalon_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(3);
                frm.Show();
            }
            Hide();
        }

        private void BtnRegistrarUsr_Click(object sender, EventArgs e)
        {
            if (ClaseComunes.chkPermiso(true, 3, claseControlUsuario.UserName))
            {
                Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "FormRegistroDeUsr").SingleOrDefault<Form>();
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
                    FormRegistroDeUsr frm = new FormRegistroDeUsr();
                    frm.Show();
                }
                Hide();
            }
        }

        private void BtnCrearPerfil_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "PerfilesDelSistema").SingleOrDefault<Form>();
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
                FormPerfilesDelSistema frm = new FormPerfilesDelSistema();
                frm.Show();
            }
            Hide();
        }

        private void BtnConfBD_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Configurar Conexion con el Servidor de Base de Datos").SingleOrDefault<Form>();
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
                formConexionBD frm = new formConexionBD();
                frm.Show();
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            respuesta = ClaseComunes.MsjShow("¿Desea Cerrar la Sesión?", 3, 2);
            if (respuesta)
            {
                formLogin frm = new formLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void BtnSalonClases4424_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(4);
                frm.Show();
            }
            Hide();
        }

        private void BtnBancoBNC_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(5);
                frm.Show();
            }
            Hide();
        }

        private void BtnRegistroVideo_Click(object sender, EventArgs e)
        {
            if (ClaseComunes.chkPermiso(true, 3, claseControlUsuario.UserName))
            {
                Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "FormRegistroDeUsr").SingleOrDefault<Form>();
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
                    FormRegistroDeVideo frm = new FormRegistroDeVideo();
                    frm.Show();
                }
                Hide();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnLuncheria_Click(object sender, EventArgs e)
        {
            Form g_ExisteFormulario = Application.OpenForms.OfType<SeleccionDeAreaDeTrabajo>().Where(pre => pre.Text == "Principal").SingleOrDefault<Form>();
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
                FormInterfaz frm = new FormInterfaz(6);
                frm.Show();
            }
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnlAyuda.Visible = true;
            string usuario, perfil, video, basededatos, trabajo;
            usuario = "registrar usuario: en esta opción agrega los datos personales del usuario y se le asigna un perfil según las actividades que maneje en el sistema";
            perfil = "Crear Perfil: Registre los perfiles del sistema asignando los permisos que crea que es conveniente, o tambien puede mofificar un perfil ya creado o sus permisos.";
            video = "Registro de video: En esta area puede ver y eliminar los videos que el sistema lleva registrado";
            basededatos = "Configuracion Base de datos: Configure las credenciales de la Base de datos del sistema";
            trabajo = "Seleccione un area de trabajo haciendo click en la imagen para que lo lleve al area del sistema scada y pueda monitorear el espacio seleccionado.";
            txtAyuda.Text = usuario + Environment.NewLine + perfil + Environment.NewLine + video + Environment.NewLine + basededatos + Environment.NewLine + trabajo;
            txtAyuda.ReadOnly = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            pnlAyuda.Visible = false;
        }
    }
}
