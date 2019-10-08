namespace SystemSCADA.Vista
{
    partial class FormRegistroDeVideo
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
            this.pnlRegistroDeUsr = new System.Windows.Forms.Panel();
            this.pnlCofiguracionPerfil = new System.Windows.Forms.Panel();
            this.lblCofigurarPerfil = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.btnGuardarPerfil = new System.Windows.Forms.Button();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgrvUsuarios = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlRegistroDeUsr.SuspendLayout();
            this.pnlCofiguracionPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroDeUsr
            // 
            this.pnlRegistroDeUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlRegistroDeUsr.Controls.Add(this.pnlCofiguracionPerfil);
            this.pnlRegistroDeUsr.Controls.Add(this.pnlBotones);
            this.pnlRegistroDeUsr.Controls.Add(this.btnCerrar);
            this.pnlRegistroDeUsr.Controls.Add(this.btnMinimizar);
            this.pnlRegistroDeUsr.Controls.Add(this.lblTitulo);
            this.pnlRegistroDeUsr.Controls.Add(this.dgrvUsuarios);
            this.pnlRegistroDeUsr.Controls.Add(this.shapeContainer1);
            this.pnlRegistroDeUsr.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroDeUsr.Name = "pnlRegistroDeUsr";
            this.pnlRegistroDeUsr.Size = new System.Drawing.Size(1385, 787);
            this.pnlRegistroDeUsr.TabIndex = 0;
            // 
            // pnlCofiguracionPerfil
            // 
            this.pnlCofiguracionPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCofiguracionPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnlCofiguracionPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCofiguracionPerfil.Controls.Add(this.lblCofigurarPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.txtNombrePerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.imgPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.btnGuardarPerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.lblNombrePerfil);
            this.pnlCofiguracionPerfil.Controls.Add(this.shapeContainer2);
            this.pnlCofiguracionPerfil.Location = new System.Drawing.Point(12, 508);
            this.pnlCofiguracionPerfil.Name = "pnlCofiguracionPerfil";
            this.pnlCofiguracionPerfil.Size = new System.Drawing.Size(258, 99);
            this.pnlCofiguracionPerfil.TabIndex = 78;
            // 
            // lblCofigurarPerfil
            // 
            this.lblCofigurarPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCofigurarPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblCofigurarPerfil.Location = new System.Drawing.Point(4, 4);
            this.lblCofigurarPerfil.Name = "lblCofigurarPerfil";
            this.lblCofigurarPerfil.Size = new System.Drawing.Size(124, 24);
            this.lblCofigurarPerfil.TabIndex = 75;
            this.lblCofigurarPerfil.Text = "Buscar Registro";
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
            this.imgPerfil.Image = global::SystemSCADA.Properties.Resources.clipboard;
            this.imgPerfil.Location = new System.Drawing.Point(7, 57);
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
            this.btnGuardarPerfil.Image = global::SystemSCADA.Properties.Resources.Buscar;
            this.btnGuardarPerfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarPerfil.Location = new System.Drawing.Point(207, 36);
            this.btnGuardarPerfil.Name = "btnGuardarPerfil";
            this.btnGuardarPerfil.Size = new System.Drawing.Size(30, 22);
            this.btnGuardarPerfil.TabIndex = 72;
            this.btnGuardarPerfil.UseVisualStyleBackColor = false;
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
            this.shapeContainer2.Size = new System.Drawing.Size(254, 95);
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
            this.lineShape2.X2 = 256;
            this.lineShape2.Y1 = 28;
            this.lineShape2.Y2 = 28;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Location = new System.Drawing.Point(3, 690);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1379, 80);
            this.pnlBotones.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::SystemSCADA.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(1288, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 61);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.BtnEliminar_MouseHover);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1330, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1293, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(44, 38);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1263, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registros Del sistema en las area de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgrvUsuarios
            // 
            this.dgrvUsuarios.AllowUserToAddRows = false;
            this.dgrvUsuarios.AllowUserToDeleteRows = false;
            this.dgrvUsuarios.AllowUserToResizeColumns = false;
            this.dgrvUsuarios.AllowUserToResizeRows = false;
            this.dgrvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgrvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgrvUsuarios.Location = new System.Drawing.Point(3, 53);
            this.dgrvUsuarios.Name = "dgrvUsuarios";
            this.dgrvUsuarios.Size = new System.Drawing.Size(1371, 425);
            this.dgrvUsuarios.TabIndex = 0;
            this.dgrvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgrvUsuarios_CellContentClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1385, 787);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 1384;
            this.lineShape1.Y1 = 44;
            this.lineShape1.Y2 = 44;
            // 
            // FormRegistroDeVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlRegistroDeUsr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroDeVideo";
            this.Text = "FormRegistroDeUsr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegistroDeUsr_Load);
            this.pnlRegistroDeUsr.ResumeLayout(false);
            this.pnlCofiguracionPerfil.ResumeLayout(false);
            this.pnlCofiguracionPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroDeUsr;
        private System.Windows.Forms.DataGridView dgrvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlCofiguracionPerfil;
        private System.Windows.Forms.Label lblCofigurarPerfil;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Button btnGuardarPerfil;
        private System.Windows.Forms.Label lblNombrePerfil;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}