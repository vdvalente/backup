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
    }
}
