﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSCADA.Controlador;

namespace SystemSCADA.Vista
{
    public partial class FormPerfilesDelSistema : Form
    {
        bool G_NuevoModificar = false;
        public FormPerfilesDelSistema()
        {
            InitializeComponent();
        }

        private void BtnGuardarPerfil_Click(object sender, EventArgs e)
        {
            bool respuesta;
            if (G_NuevoModificar)
            {
                claseControlPerfil.Nombre = txtNombrePerfil.Text.ToString();
                claseControlPerfil.IdPerfil = Convert.ToInt32(dgvPerfil.CurrentRow.Cells["cId"].Value.ToString());
                G_NuevoModificar = true;
            }
            else
            {
                claseControlPerfil.Nombre = txtNombrePerfil.Text;
                claseControlPerfil.IdPerfil = 0;
            }
            if (txtNombrePerfil.Text == "")
            {
                respuesta = ClaseComunes.MsjShow("Se debe introducir un nombre para el perfil", 1, 4);
                return;
            }
            if (!G_NuevoModificar)
            {
                respuesta = ClaseComunes.MsjShow("¿Desea registrar un nuevo Perfil de Usuario?", 3, 2);
            }
            else
            {
                respuesta = ClaseComunes.MsjShow("¿Desea modificar el Perfil del Usuario?", 3, 2);
            }
            if (G_NuevoModificar == false)
            {
                if (claseControlPerfil.VerificarExitenciaPerfil())
                {
                    ClaseComunes.MsjShow("El nombre del perfil no se encuentra disponible.", 1, 3);
                    return;
                }
            }
            // si el registro existe, y desea modifcarlo, procedemos a mostrar los datos en el formulario y habilitar el boton modificar  
            if (respuesta)
            {
                UseWaitCursor = true; Application.DoEvents();
                dgvModulo.EndEdit();
                claseControlPerfil.GuardarPerfil(dgvModulo);
                claseControlPerfil.setDgrw(ref dgvPerfil, "usp_ConsultaPerfil", "ListaPerfil", 0);
                claseControlPerfil.setDgrw(ref dgvModulo, "usp_ConsultaPermisos", "ListaModulo", Convert.ToInt32(dgvPerfil.CurrentRow.Cells["cId"].Value.ToString()));
                BtnCancelarPerfil_Click(this, EventArgs.Empty);
            }
            UseWaitCursor = false; Application.DoEvents();
            dgvPerfil.Enabled = true;
            btnRefrescarPerfil.Enabled = true;
            btnNuevoPerfil.Enabled = true;
            btnBorrarPerfil.Enabled = true;
        }

        private void BtnCancelarPerfil_Click(object sender, EventArgs e)
        {
            dgvPerfil.Enabled = true;
            btnRefrescarPerfil.Enabled = true;
            btnNuevoPerfil.Enabled = true;
            btnBorrarPerfil.Enabled = true;
            btnRefrescarPerfil.Enabled = true;
            btnModificarPerfil.Enabled = true;
            btnBorrarPerfil.Enabled = true;
            UseWaitCursor = true; Application.DoEvents();
            pnlCofiguracionPerfil.Visible = false;
            dgvPerfil.Focus();
            UseWaitCursor = false; Application.DoEvents();
        }

        private void FormPerfilesDelSistema_Load(object sender, EventArgs e)
        {
            claseControlPerfil.setDgrw(ref dgvPerfil, "usp_ConsultaPerfil", "ListaPerfil", 0);
            claseControlPerfil.setDgrw(ref dgvModulo, "usp_ConsultaPermisos", "ListaModulo", Convert.ToInt32(dgvPerfil.CurrentRow.Cells["Codigo"].Value.ToString()));
        }


        private void BtnNuevoPerfil_Click(object sender, EventArgs e)
        {
            pnlConfPerfiles.Visible = true;
        }
    }
}