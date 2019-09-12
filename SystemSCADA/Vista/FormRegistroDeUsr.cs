using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSCADA.Controlador;
using System.Windows.Forms;

namespace SystemSCADA.Vista
{
    public partial class FormRegistroDeUsr : Form
    {
        public FormRegistroDeUsr()
        {
            InitializeComponent();
        }

        private void BtnNuevo_MouseHover(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.FromArgb(135, 241, 52);
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.FromArgb(150, 150, 150);
        }

      
        private void BtnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(135, 241, 52);

        }

        private void BtnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(150, 150, 150);
        }

        private void BtnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(163, 51, 59);
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(150, 150, 150);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevoUsuario.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            SeleccionDeAreaDeTrabajo frm = new SeleccionDeAreaDeTrabajo();
            frm.Show();
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlNuevoUsuario.Visible = false;
        }

        private void BtnCancelarAsignacion_Click(object sender, EventArgs e)
        {
            pnlCreacionUsr.Visible = false;
            pnlNuevoUsuario.Visible = true;
        }

        private void FormRegistroDeUsr_Load(object sender, EventArgs e)
        {
            claseControlUsuario.llenarCmbPerfil(ref cmbPerfiles);
            LlenarForm(); //Se llenan los campos con la informacion correspondiente 
            
        }

        private void LlenarForm()
        {

            txtDireccionConfiUsuario.Text = claseControlUsuario.Direccion;
            txtNombreConfiUsuario.Text = claseControlUsuario.Nombre;
            txtApellidoConfiUsuario.Text = claseControlUsuario.Apellido;
            txtCedulaConfiUsuario.Text = claseControlUsuario.Cedula;
            txtTlfConfiUsuario.Text = claseControlUsuario.Tlf;
            cmbPerfiles.SelectedValue = claseControlUsuario.IdPerfil;
            txtCorreoConfiUsuario.Text = claseControlUsuario.Correo;
            txtUsuario.Text = claseControlUsuario.UserName;
            txtContraseña.Text = claseControlUsuario.Contraseña;
            chbEstatusConfiUsuario.Checked = claseControlUsuario.Estatus;

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            pnlCreacionUsr.Visible = true;
            pnlNuevoUsuario.Visible = false;
        }

        /*****************************************************************************************************************************************************
        Descripcion: Cuando se activa este evento se ejecutan multiples procedimientos para guaradar en la base de datos.
        *****************************************************************************************************************************************************/
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            claseControlUsuario entidad = new claseControlUsuario();

            claseControlUsuario.Direccion = txtDireccionConfiUsuario.Text;
            claseControlUsuario.Nombre = txtNombreConfiUsuario.Text;
            claseControlUsuario.Cedula = txtCedulaConfiUsuario.Text;
            claseControlUsuario.Tlf = txtTlfConfiUsuario.Text;
            claseControlUsuario.IdPerfil = Convert.ToInt32(cmbPerfiles.SelectedValue);
            claseControlUsuario.Contraseña = ClaseComunes.ObtenerHash(txtContraseña.Text);
            claseControlUsuario.Apellido = txtApellidoConfiUsuario.Text;
            claseControlUsuario.UserName = txtUsuario.Text;
            claseControlUsuario.Correo = txtCorreoConfiUsuario.Text;
            claseControlUsuario.Estatus = Convert.ToBoolean(chbEstatusConfiUsuario.Checked);


            if (!entidad.ValidarCampos())
                return;

            if (entidad.VerificarExitenciaUsuario())
            {
                ClaseComunes.MsjShow("La cedula ya se encuentra registrada en el sistema.", 1, 3);

                return;
            }

            if (entidad.GuardarUsuario())
            {
                ClaseComunes.MsjShow("El Registro se Guardo Exitosamente", 1, 5);

                if (Text == "Nuevo")
                {
                    btnLimpiarConfiUsuario_Click(sender, e);
                    claseControlUsuario.IdUsuario = 0;
                }
                else
                {
                    Close();
                }
                Actualizar?.Invoke(sender, e);
            }
        }
    }
}
