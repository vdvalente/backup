namespace SystemSCADA.Vista
{
    partial class SeleccionDeAreaDeTrabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionDeAreaDeTrabajo));
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLabComp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalones = new System.Windows.Forms.Label();
            this.btnSalon = new System.Windows.Forms.Button();
            this.btnLabElectronica = new System.Windows.Forms.Button();
            this.btnLabComputacion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarUsr = new System.Windows.Forms.Button();
            this.btnRegistroVideo = new System.Windows.Forms.Button();
            this.btnConfBD = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 1385;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1370, 749);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1279, 23);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Seleccione El Area que desea inspeccionar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabComp
            // 
            this.lblLabComp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabComp.Location = new System.Drawing.Point(23, 299);
            this.lblLabComp.Name = "lblLabComp";
            this.lblLabComp.Size = new System.Drawing.Size(287, 23);
            this.lblLabComp.TabIndex = 8;
            this.lblLabComp.Text = "Laboratorio de Computación";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Laboratorio de Electronica";
            // 
            // lblSalones
            // 
            this.lblSalones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalones.Location = new System.Drawing.Point(963, 302);
            this.lblSalones.Name = "lblSalones";
            this.lblSalones.Size = new System.Drawing.Size(262, 23);
            this.lblSalones.TabIndex = 12;
            this.lblSalones.Text = "Salones de clase";
            this.lblSalones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalon
            // 
            this.btnSalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalon.Image = global::SystemSCADA.Properties.Resources.salon;
            this.btnSalon.Location = new System.Drawing.Point(954, 127);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(278, 147);
            this.btnSalon.TabIndex = 11;
            this.btnSalon.UseVisualStyleBackColor = true;
            this.btnSalon.Click += new System.EventHandler(this.BtnSalon_Click);
            // 
            // btnLabElectronica
            // 
            this.btnLabElectronica.FlatAppearance.BorderSize = 0;
            this.btnLabElectronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabElectronica.Image = global::SystemSCADA.Properties.Resources.Electronica;
            this.btnLabElectronica.Location = new System.Drawing.Point(478, 131);
            this.btnLabElectronica.Name = "btnLabElectronica";
            this.btnLabElectronica.Size = new System.Drawing.Size(280, 145);
            this.btnLabElectronica.TabIndex = 9;
            this.btnLabElectronica.UseVisualStyleBackColor = true;
            this.btnLabElectronica.Click += new System.EventHandler(this.BtnLabElectronica_Click);
            // 
            // btnLabComputacion
            // 
            this.btnLabComputacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLabComputacion.FlatAppearance.BorderSize = 0;
            this.btnLabComputacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabComputacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLabComputacion.Image")));
            this.btnLabComputacion.Location = new System.Drawing.Point(38, 138);
            this.btnLabComputacion.Name = "btnLabComputacion";
            this.btnLabComputacion.Size = new System.Drawing.Size(256, 136);
            this.btnLabComputacion.TabIndex = 7;
            this.btnLabComputacion.UseVisualStyleBackColor = true;
            this.btnLabComputacion.Click += new System.EventHandler(this.BtnLabComputacion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1320, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 37);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1288, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 37);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnConfBD);
            this.panel1.Controls.Add(this.btnRegistroVideo);
            this.panel1.Controls.Add(this.btnRegistrarUsr);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 40);
            this.panel1.TabIndex = 13;
            // 
            // btnRegistrarUsr
            // 
            this.btnRegistrarUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistrarUsr.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsr.Location = new System.Drawing.Point(3, 2);
            this.btnRegistrarUsr.Name = "btnRegistrarUsr";
            this.btnRegistrarUsr.Size = new System.Drawing.Size(122, 35);
            this.btnRegistrarUsr.TabIndex = 0;
            this.btnRegistrarUsr.Text = "Registrar Usuario";
            this.btnRegistrarUsr.UseVisualStyleBackColor = false;
            this.btnRegistrarUsr.MouseLeave += new System.EventHandler(this.BtnRegistrarUsr_MouseLeave);
            this.btnRegistrarUsr.MouseHover += new System.EventHandler(this.BtnRegistrarUsr_MouseHover);
            // 
            // btnRegistroVideo
            // 
            this.btnRegistroVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistroVideo.FlatAppearance.BorderSize = 0;
            this.btnRegistroVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroVideo.Location = new System.Drawing.Point(126, 1);
            this.btnRegistroVideo.Name = "btnRegistroVideo";
            this.btnRegistroVideo.Size = new System.Drawing.Size(122, 36);
            this.btnRegistroVideo.TabIndex = 1;
            this.btnRegistroVideo.Text = "Registros de Video";
            this.btnRegistroVideo.UseVisualStyleBackColor = false;
            this.btnRegistroVideo.MouseLeave += new System.EventHandler(this.BtnRegistroVideo_MouseLeave);
            this.btnRegistroVideo.MouseHover += new System.EventHandler(this.BtnRegistroVideo_MouseHover);
            // 
            // btnConfBD
            // 
            this.btnConfBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfBD.FlatAppearance.BorderSize = 0;
            this.btnConfBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfBD.Location = new System.Drawing.Point(249, 1);
            this.btnConfBD.Name = "btnConfBD";
            this.btnConfBD.Size = new System.Drawing.Size(160, 36);
            this.btnConfBD.TabIndex = 2;
            this.btnConfBD.Text = "Configuracion Base de datos";
            this.btnConfBD.UseVisualStyleBackColor = false;
            this.btnConfBD.MouseLeave += new System.EventHandler(this.BtnConfBD_MouseLeave);
            this.btnConfBD.MouseHover += new System.EventHandler(this.BtnConfBD_MouseHover);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(409, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(160, 36);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.MouseLeave += new System.EventHandler(this.BtnCerrarSesion_MouseLeave);
            this.btnCerrarSesion.MouseHover += new System.EventHandler(this.BtnCerrarSesion_MouseHover);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Blue;
            this.lineShape2.BorderWidth = 4;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape2.X1 = -1;
            this.lineShape2.X2 = 1382;
            this.lineShape2.Y1 = 44;
            this.lineShape2.Y2 = 44;
            // 
            // SeleccionDeAreaDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSalones);
            this.Controls.Add(this.btnSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLabElectronica);
            this.Controls.Add(this.lblLabComp);
            this.Controls.Add(this.btnLabComputacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionDeAreaDeTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionDeAreaDeTrabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLabComputacion;
        private System.Windows.Forms.Label lblLabComp;
        private System.Windows.Forms.Button btnLabElectronica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Label lblSalones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfBD;
        private System.Windows.Forms.Button btnRegistroVideo;
        private System.Windows.Forms.Button btnRegistrarUsr;
        private System.Windows.Forms.Button btnCerrarSesion;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}