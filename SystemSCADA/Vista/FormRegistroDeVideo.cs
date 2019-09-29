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
    public partial class FormRegistroDeVideo: Form
    {
        public event EventHandler Actualizar;
        public FormRegistroDeVideo()
        {
            InitializeComponent();
        }
      

        private void BtnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(163, 51, 59);
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(150, 150, 150);
        }

     

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            SeleccionDeAreaDeTrabajo frm = new SeleccionDeAreaDeTrabajo();
            frm.Show();
            this.Hide();
        }

      

        private void FormRegistroDeUsr_Load(object sender, EventArgs e)
        {
            ClaseVideosDelSistema.setDgrw(ref dgrvUsuarios, "usp_ConsultaGrabaciones");
            dgrvUsuarios.Enabled = true;
            
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

       
        
    }
}
