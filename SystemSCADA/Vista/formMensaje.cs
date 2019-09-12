using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSCADA.Vista
{
    public partial class formMensaje : Form
    {
        public bool g_boolRespuesta;
        //public bool choose = false;

        public formMensaje(string msj, int botones, int icono, string titulo = ".::Sistema SCADA::.", int tamaño = 1)
        {
            InitializeComponent();
            txtMensaje.Text = msj;            
            lblTituloMSJ.Text = titulo;

            //Seleccion de botones del mensaje
            switch (botones)
            {
                case 1:
                    //Solo Boton Aceptar
                    btnBoton1.Location = new Point(252, 141);
                    btnBoton1.Size = new Size(152, 35);
                    btnBoton1.TextImageRelation = TextImageRelation.Overlay;
                    btnBoton1.Text = "Aceptar";

                    btnBoton2.Visible = false;
                    break;
                case 2:
                    //Boton Aceptar y Cancelar
                    btnBoton1.Location = new Point(94, 141);
                    btnBoton1.Size = new Size(152, 35);
                    btnBoton1.TextImageRelation = TextImageRelation.Overlay;
                    btnBoton1.Text = "Aceptar";
                    btnBoton1.Visible = true;

                    btnBoton2.Location = new Point(252, 141);
                    btnBoton2.Size = new Size(152, 35);
                    btnBoton2.TextImageRelation = TextImageRelation.Overlay;
                    btnBoton2.Text = "Cancelar";
                    btnBoton2.Visible = true;
                    break;
                case 3:
                    //Boton Si y No
                    btnBoton1.Location = new Point(260, 141);
                    btnBoton1.Size = new Size(69, 35);
                    btnBoton1.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnBoton1.Text = "Si";
                    btnBoton1.Visible = true;

                    btnBoton2.Location = new Point(335, 141);
                    btnBoton2.Size = new Size(69, 35);
                    btnBoton2.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnBoton2.Text = "No";
                    btnBoton2.Visible = true;
                    break;
                case 4:
                    //Botones "Asignacion Remota" y "En Planta"
                    btnBoton1.Location = new Point(10, 141);
                    btnBoton1.Size = new Size(190, 35);
                    btnBoton1.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnBoton1.Text = "Asignación Remota";
                    btnBoton1.Visible = true;
                    //btnBoton1.Image = SystemSCADA.Properties.Resources.global;

                    btnBoton2.Location = new Point(210, 141);
                    btnBoton2.Size = new Size(195, 35);
                    btnBoton2.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnBoton2.Text = "Asignación En Planta";
                    btnBoton2.Visible = true;
                    //btnBoton2.Image = SystemSCADA.Properties.Resources.place;

                    txtMensaje.Location = new Point(65, 70);
                    txtMensaje.ScrollBars = ScrollBars.None;
                    txtMensaje.TextAlign = HorizontalAlignment.Center;
                    txtMensaje.Font = new Font(Font.FontFamily, 10);
                    break;
            }

            //Seleccion de tamaño(Ancho) de la ventana 
            switch (tamaño)
            {
                //Tamaño por defecto
                case 1:
                    Width = 414;
                    break;
                case 2:
                    Width = 514;
                    break;
                case 3:
                    Width = 950;

                    break;
            }
            lblTituloMSJ.Location = new Point(pnlTituloMSJ.Width / 2 - lblTituloMSJ.Width / 2, lblTituloMSJ.Location.Y);

            //Seleccion de icono del mensaje
            switch (icono)
            {
                case 1:
                    //Error
                    pbImagenMensaje.Image = Properties.Resources.Error_64;
                    break;
                case 2:
                    //Pregunta
                    pbImagenMensaje.Image = Properties.Resources.Pregunta_64;
                    break;
                case 3:
                    //Informacion
                    pbImagenMensaje.Image = Properties.Resources.Info_64;
                    break;
                case 4:
                    //Cancelar
                    pbImagenMensaje.Image = Properties.Resources.Cancelar_64;
                    break;
                case 5:
                    //Exitoso
                    pbImagenMensaje.Image = Properties.Resources.Exitoso_64;
                    break;
            }
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

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            g_boolRespuesta = true;
            Close();
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {
            g_boolRespuesta = false;
            Close();
        }
	
	}
    }