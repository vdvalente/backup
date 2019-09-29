namespace SystemSCADA.Vista
{
    partial class FormPerfilesDelSistema
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
            this.pnlConfPerfiles = new System.Windows.Forms.Panel();
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
            this.btnRefrescarPerfil = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnModificarPerfil = new System.Windows.Forms.Button();
            this.btnBorrarPerfil = new System.Windows.Forms.Button();
            this.btnNuevoPerfil = new System.Windows.Forms.Button();
            this.pnlCofiguracionPerfil = new System.Windows.Forms.Panel();
            this.lblCofigurarPerfil = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.btnGuardarPerfil = new System.Windows.Forms.Button();
            this.btnCancelarPerfil = new System.Windows.Forms.Button();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvModulo = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTituloPerfil = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlConfPerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.pnlCofiguracionPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfPerfiles
            // 
            this.pnlConfPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlConfPerfiles.Controls.Add(this.dgvPerfil);
            this.pnlConfPerfiles.Controls.Add(this.btnRefrescarPerfil);
            this.pnlConfPerfiles.Controls.Add(this.pnlBotones);
            this.pnlConfPerfiles.Controls.Add(this.pnlCofiguracionPerfil);
            this.pnlConfPerfiles.Controls.Add(this.dgvModulo);
            this.pnlConfPerfiles.Controls.Add(this.btnCerrar);
            this.pnlConfPerfiles.Controls.Add(this.btnMinimizar);
            this.pnlConfPerfiles.Controls.Add(this.lblTituloPerfil);
            this.pnlConfPerfiles.Controls.Add(this.shapeContainer1);
            this.pnlConfPerfiles.Location = new System.Drawing.Point(0, 0);
            this.pnlConfPerfiles.Name = "pnlConfPerfiles";
            this.pnlConfPerfiles.Size = new System.Drawing.Size(1385, 787);
            this.pnlConfPerfiles.TabIndex = 0;
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Location = new System.Drawing.Point(31, 96);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.Size = new System.Drawing.Size(160, 444);
            this.dgvPerfil.TabIndex = 80;
            this.dgvPerfil.SelectionChanged += new System.EventHandler(this.DgvPerfil_SelectionChanged);
            // 
            // btnRefrescarPerfil
            // 
            this.btnRefrescarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRefrescarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescarPerfil.FlatAppearance.BorderSize = 0;
            this.btnRefrescarPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnRefrescarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnRefrescarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarPerfil.Image = global::SystemSCADA.Properties.Resources.refresh;
            this.btnRefrescarPerfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefrescarPerfil.Location = new System.Drawing.Point(1307, 55);
            this.btnRefrescarPerfil.Name = "btnRefrescarPerfil";
            this.btnRefrescarPerfil.Size = new System.Drawing.Size(33, 35);
            this.btnRefrescarPerfil.TabIndex = 79;
            this.btnRefrescarPerfil.UseVisualStyleBackColor = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pnlBotones.Controls.Add(this.btnModificarPerfil);
            this.pnlBotones.Controls.Add(this.btnBorrarPerfil);
            this.pnlBotones.Controls.Add(this.btnNuevoPerfil);
            this.pnlBotones.Location = new System.Drawing.Point(0, 688);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1347, 80);
            this.pnlBotones.TabIndex = 78;
            // 
            // btnModificarPerfil
            // 
            this.btnModificarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnModificarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPerfil.FlatAppearance.BorderSize = 0;
            this.btnModificarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(241)))), ((int)(((byte)(52)))));
            this.btnModificarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPerfil.Image = global::SystemSCADA.Properties.Resources.pencil;
            this.btnModificarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPerfil.Location = new System.Drawing.Point(1154, 11);
            this.btnModificarPerfil.Name = "btnModificarPerfil";
            this.btnModificarPerfil.Size = new System.Drawing.Size(97, 61);
            this.btnModificarPerfil.TabIndex = 8;
            this.btnModificarPerfil.Text = "Modificar";
            this.btnModificarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPerfil.UseVisualStyleBackColor = false;
            this.btnModificarPerfil.Click += new System.EventHandler(this.BtnModificarPerfil_Click);
            // 
            // btnBorrarPerfil
            // 
            this.btnBorrarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnBorrarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPerfil.FlatAppearance.BorderSize = 0;
            this.btnBorrarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnBorrarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPerfil.Image = global::SystemSCADA.Properties.Resources.delete;
            this.btnBorrarPerfil.Location = new System.Drawing.Point(1257, 11);
            this.btnBorrarPerfil.Name = "btnBorrarPerfil";
            this.btnBorrarPerfil.Size = new System.Drawing.Size(83, 61);
            this.btnBorrarPerfil.TabIndex = 7;
            this.btnBorrarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarPerfil.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPerfil
            // 
            this.btnNuevoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnNuevoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPerfil.FlatAppearance.BorderSize = 0;
            this.btnNuevoPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(241)))), ((int)(((byte)(52)))));
            this.btnNuevoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPerfil.Image = global::SystemSCADA.Properties.Resources.profile_p;
            this.btnNuevoPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPerfil.Location = new System.Drawing.Point(1055, 11);
            this.btnNuevoPerfil.Name = "btnNuevoPerfil";
            this.btnNuevoPerfil.Size = new System.Drawing.Size(93, 61);
            this.btnNuevoPerfil.TabIndex = 5;
            this.btnNuevoPerfil.Text = "Nuevo";
            this.btnNuevoPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPerfil.UseVisualStyleBackColor = false;
            this.btnNuevoPerfil.Click += new System.EventHandler(this.BtnNuevoPerfil_Click);
            // 
            // pnlCofiguracionPerfil
            // 
            this.pnlCofiguracionPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCofiguracionPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnlCofiguracionPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCofiguracionPerfil.Controls.Add(this.lblCofigurarPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.txtNombrePerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.imgPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.btnGuardarPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.btnCancelarPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.lblNombrePerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.shapeContainer2);
            this.pnlCofiguracionPerfil.Location = new System.Drawing.Point(30, 562);
            this.pnlCofiguracionPerfil.Name = "pnlCofiguracionPerfil";
            this.pnlCofiguracionPerfil.Size = new System.Drawing.Size(213, 105);
            this.pnlCofiguracionPerfil.TabIndex = 77;
            this.pnlCofiguracionPerfil.Visible = false;
            // 
            // lblCofigurarPerfil
            // 
            this.lblCofigurarPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCofigurarPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblCofigurarPerfil.Location = new System.Drawing.Point(4, 4);
            this.lblCofigurarPerfil.Name = "lblCofigurarPerfil";
            this.lblCofigurarPerfil.Size = new System.Drawing.Size(124, 24);
            this.lblCofigurarPerfil.TabIndex = 75;
            this.lblCofigurarPerfil.Text = "Crear Perfil";
            this.lblCofigurarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePerfil.Location = new System.Drawing.Point(58, 36);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(152, 22);
            this.txtNombrePerfil.TabIndex = 71;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = global::SystemSCADA.Properties.Resources.login;
            this.imgPerfil.Location = new System.Drawing.Point(13, 62);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(36, 40);
            this.imgPerfil.TabIndex = 74;
            this.imgPerfil.TabStop = false;
            // 
            // btnGuardarPerfil
            // 
            this.btnGuardarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPerfil.FlatAppearance.BorderSize = 0;
            this.btnGuardarPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnGuardarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnGuardarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPerfil.Image = global::SystemSCADA.Properties.Resources.save;
            this.btnGuardarPerfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarPerfil.Location = new System.Drawing.Point(137, 62);
            this.btnGuardarPerfil.Name = "btnGuardarPerfil";
            this.btnGuardarPerfil.Size = new System.Drawing.Size(33, 35);
            this.btnGuardarPerfil.TabIndex = 72;
            this.btnGuardarPerfil.UseVisualStyleBackColor = false;
            this.btnGuardarPerfil.Click += new System.EventHandler(this.BtnGuardarPerfil_Click);
            // 
            // btnCancelarPerfil
            // 
            this.btnCancelarPerfil.BackColor = System.Drawing.Color.Red;
            this.btnCancelarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPerfil.FlatAppearance.BorderSize = 0;
            this.btnCancelarPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnCancelarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnCancelarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPerfil.Image = global::SystemSCADA.Properties.Resources.prohibition;
            this.btnCancelarPerfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelarPerfil.Location = new System.Drawing.Point(177, 62);
            this.btnCancelarPerfil.Name = "btnCancelarPerfil";
            this.btnCancelarPerfil.Size = new System.Drawing.Size(33, 35);
            this.btnCancelarPerfil.TabIndex = 73;
            this.btnCancelarPerfil.UseVisualStyleBackColor = false;
            this.btnCancelarPerfil.Click += new System.EventHandler(this.BtnCancelarPerfil_Click);
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfil.Location = new System.Drawing.Point(2, 37);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(56, 17);
            this.lblNombrePerfil.TabIndex = 70;
            this.lblNombrePerfil.Text = "Nombre";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(211, 103);
            this.shapeContainer2.TabIndex = 76;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.Blue;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape1";
            this.lineShape2.X1 = 4;
            this.lineShape2.X2 = 211;
            this.lineShape2.Y1 = 28;
            this.lineShape2.Y2 = 28;
            // 
            // dgvModulo
            // 
            this.dgvModulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.dgvModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulo.Location = new System.Drawing.Point(191, 96);
            this.dgvModulo.Name = "dgvModulo";
            this.dgvModulo.Size = new System.Drawing.Size(1156, 444);
            this.dgvModulo.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1307, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1274, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 35);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // lblTituloPerfil
            // 
            this.lblTituloPerfil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPerfil.Location = new System.Drawing.Point(12, 9);
            this.lblTituloPerfil.Name = "lblTituloPerfil";
            this.lblTituloPerfil.Size = new System.Drawing.Size(1186, 25);
            this.lblTituloPerfil.TabIndex = 1;
            this.lblTituloPerfil.Text = "Creación de Perfiles";
            this.lblTituloPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1385, 787);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 1350;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // FormPerfilesDelSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlConfPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerfilesDelSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilesDelSistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPerfilesDelSistema_Load);
            this.pnlConfPerfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlCofiguracionPerfil.ResumeLayout(false);
            this.pnlCofiguracionPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfPerfiles;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblTituloPerfil;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlCofiguracionPerfil;
        private System.Windows.Forms.Label lblCofigurarPerfil;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Button btnGuardarPerfil;
        private System.Windows.Forms.Button btnCancelarPerfil;
        private System.Windows.Forms.Label lblNombrePerfil;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnModificarPerfil;
        private System.Windows.Forms.Button btnBorrarPerfil;
        private System.Windows.Forms.Button btnNuevoPerfil;
        private System.Windows.Forms.Button btnRefrescarPerfil;
        private System.Windows.Forms.DataGridView dgvModulo;
        private System.Windows.Forms.DataGridView dgvPerfil;
    }
}