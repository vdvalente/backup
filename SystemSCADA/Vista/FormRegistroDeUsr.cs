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
        public event EventHandler Actualizar;
        claseControlUsuario entidad = new claseControlUsuario();
        public FormRegistroDeUsr()
        {
            InitializeComponent();
        }
      
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (ClaseComunes.chkPermiso(false, 3, claseUsuarioAct.Usuario, 10))
            {
                //Se inicializan los campos del formulario
                claseControlUsuario.IdUsuario = 0;
                claseControlUsuario.Direccion = "";
                claseControlUsuario.Nombre = "";
                claseControlUsuario.Apellido = "";
                claseControlUsuario.Tlf = "";
                claseControlUsuario.Contraseña = "";
                claseControlUsuario.IdPerfil = 0;
                claseControlUsuario.UserName = "";
                claseControlUsuario.Correo = "";
                claseControlUsuario.UserName = "";
                claseControlUsuario.Cedula = "";
                claseControlUsuario.Estatus = true;
                pnlNuevoUsuario.Visible = true;
            }
                
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
            claseControlUsuario.setDgrw(ref dgrvUsuarios, "USP_ConsultaUsuario");
            dgrvUsuarios.ReadOnly = true;
            dgrvUsuarios.Columns["Estatus"].ReadOnly = false;
            claseControlUsuario.llenarCmbPerfil(ref cmbPerfiles);
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

            pnlCreacionUsr.Location = new System.Drawing.Point(490, 211);
            pnlCreacionUsr.Visible = true;
            pnlNuevoUsuario.Visible = false;
            txtUsuario.Focus();
        }
        private void LimpiarConfiUsuario()
        {
            txtDireccionConfiUsuario.Text = "";
            txtNombreConfiUsuario.Text = "";
            txtCedulaConfiUsuario.Text = "";
            txtTlfConfiUsuario.Text = "";
            cmbPerfiles.SelectedIndex = 0;
            txtContraseña.Text = "";
            txtApellidoConfiUsuario.Text = "";
            txtUsuario.Text = "";
            txtCorreoConfiUsuario.Text = "";
            chbEstatusConfiUsuario.Checked = true;
        }
        /*****************************************************************************************************************************************************
        Descripcion: Cuando se activa este evento se ejecutan multiples procedimientos para guaradar en la base de datos.
        *****************************************************************************************************************************************************/
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {

            claseControlUsuario.Direccion = txtDireccionConfiUsuario.Text;
            claseControlUsuario.Nombre = txtNombreConfiUsuario.Text;
            claseControlUsuario.Cedula = txtCedulaConfiUsuario.Text;
            claseControlUsuario.Tlf = txtTlfConfiUsuario.Text;
            claseControlUsuario.IdPerfil = Convert.ToInt32(cmbPerfiles.SelectedValue);
            claseControlUsuario.PassNew = ClaseComunes.ObtenerHash(txtContraseña.Text);
            claseControlUsuario.Apellido = txtApellidoConfiUsuario.Text;
            claseControlUsuario.UserNew = txtUsuario.Text;
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
                    LimpiarConfiUsuario();
                    claseControlUsuario.IdUsuario = 0;
                }
                else
                {
                    pnlCreacionUsr.Visible = false;
                    claseControlUsuario.setDgrw(ref dgrvUsuarios, "USP_ConsultaUsuario");
                }
                Actualizar?.Invoke(sender, e);
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
           
            if (ClaseComunes.chkPermiso(false, 3, claseUsuarioAct.Usuario, 20))
            {
                if (dgrvUsuarios.CurrentRow != null)
                {
                    //Se extraen los datos del campo seleccionado para la Modificacion
                    claseControlUsuario.IdUsuario = Convert.ToInt32(dgrvUsuarios.CurrentRow.Cells["Usuario_id"].Value);
                    claseControlUsuario.Nombre = dgrvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                    claseControlUsuario.Direccion = dgrvUsuarios.CurrentRow.Cells["Direccion"].Value.ToString();
                    claseControlUsuario.Apellido = dgrvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                    claseControlUsuario.Tlf = dgrvUsuarios.CurrentRow.Cells["Tlf"].Value.ToString();
                    claseControlUsuario.IdPerfil = Convert.ToInt32(dgrvUsuarios.CurrentRow.Cells["Perfil_Id"].Value);
                    claseControlUsuario.Contraseña = dgrvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    claseControlUsuario.UserName = dgrvUsuarios.CurrentRow.Cells["UserName"].Value.ToString();
                    claseControlUsuario.Correo = dgrvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                    claseControlUsuario.Cedula = dgrvUsuarios.CurrentRow.Cells["Cedula"].Value.ToString();
                    claseControlUsuario.Estatus = Convert.ToBoolean(dgrvUsuarios.CurrentRow.Cells["Estatus"].Value);

                    LlenarForm();
                    pnlNuevoUsuario.Visible = true;

                }
                else
                {
                    ClaseComunes.MsjShow("Seleccione Una Fila.", 1, 4);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ClaseComunes.chkPermiso(false, 3, claseUsuarioAct.Usuario, 30))
            {
                if (dgrvUsuarios.CurrentRow != null)
                {
                    string message = " ¿Desea eliminar el usuario?";
                    bool result;

                    // Displays the MessageBox.

                    result = ClaseComunes.MsjShow(message, 3, 2);

                    if (result)
                    {
                        claseControlUsuario.IdUsuario = Convert.ToInt32(dgrvUsuarios.CurrentRow.Cells["Usuario_id"].Value);
                        claseControlUsuario.ActualizarEstatus();
                        claseControlUsuario.setDgrw(ref dgrvUsuarios,"USP_ConsultaUsuario");
                    }
                }
                else
                {
                    ClaseComunes.MsjShow("Seleccione Una Fila.", 1, 4);
                }
            }
        }

        private void TxtNombreConfiUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtApellidoConfiUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCedulaConfiUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void TxtTlfConfiUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }
    }
}
