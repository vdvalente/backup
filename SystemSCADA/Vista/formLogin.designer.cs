namespace SystemSCADA.Vista
{
    partial class formLogin
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
            this.t_splash = new System.Windows.Forms.Timer(this.components);
            this.t_Acceder = new System.Windows.Forms.Timer(this.components);
            this.txtUsusario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiarConfiEmpresa = new System.Windows.Forms.Button();
            this.btnMinimizarConfiEmpresa = new System.Windows.Forms.Button();
            this.btnCerrarConfiEmpresa = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineContraseña = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_splash
            // 
            this.t_splash.Interval = 150;
            this.t_splash.Tick += new System.EventHandler(this.t_splash_Tick);
            // 
            // t_Acceder
            // 
            this.t_Acceder.Tick += new System.EventHandler(this.t_Acceder_Tick);
            // 
            // txtUsusario
            // 
            this.txtUsusario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsusario.BackColor = System.Drawing.Color.White;
            this.txtUsusario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsusario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsusario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsusario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsusario.Location = new System.Drawing.Point(72, 323);
            this.txtUsusario.MaxLength = 50;
            this.txtUsusario.Name = "txtUsusario";
            this.txtUsusario.Size = new System.Drawing.Size(377, 20);
            this.txtUsusario.TabIndex = 0;
            this.txtUsusario.Text = "USUARIO...";
            this.txtUsusario.Enter += new System.EventHandler(this.txt_Ususario_Enter);
            this.txtUsusario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ususario_KeyPress);
            this.txtUsusario.Leave += new System.EventHandler(this.txt_Ususario_Leave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtContrasena.Location = new System.Drawing.Point(73, 354);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(374, 20);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "Contraseña...";
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            this.txtContrasena.Enter += new System.EventHandler(this.txt_Contrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contrasena_KeyPress);
            this.txtContrasena.Leave += new System.EventHandler(this.txt_Contrasena_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceder.BackColor = System.Drawing.Color.Silver;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Black;
            this.btnAcceder.Location = new System.Drawing.Point(74, 402);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(372, 33);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btn_Acceder_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.btnLimpiarConfiEmpresa);
            this.pnlLogin.Controls.Add(this.btnMinimizarConfiEmpresa);
            this.pnlLogin.Controls.Add(this.btnCerrarConfiEmpresa);
            this.pnlLogin.Controls.Add(this.btnAcceder);
            this.pnlLogin.Controls.Add(this.txtContrasena);
            this.pnlLogin.Controls.Add(this.txtUsusario);
            this.pnlLogin.Controls.Add(this.shapeContainer1);
            this.pnlLogin.Location = new System.Drawing.Point(2, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(539, 440);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemSCADA.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(165, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 249);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 23);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Universidad José Antonio Páez";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarConfiEmpresa
            // 
            this.btnLimpiarConfiEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLimpiarConfiEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarConfiEmpresa.FlatAppearance.BorderSize = 0;
            this.btnLimpiarConfiEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnLimpiarConfiEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnLimpiarConfiEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarConfiEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarConfiEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarConfiEmpresa.Image = global::SystemSCADA.Properties.Resources.settings;
            this.btnLimpiarConfiEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpiarConfiEmpresa.Location = new System.Drawing.Point(434, 3);
            this.btnLimpiarConfiEmpresa.Name = "btnLimpiarConfiEmpresa";
            this.btnLimpiarConfiEmpresa.Size = new System.Drawing.Size(33, 31);
            this.btnLimpiarConfiEmpresa.TabIndex = 3;
            this.btnLimpiarConfiEmpresa.UseVisualStyleBackColor = false;
            this.btnLimpiarConfiEmpresa.Click += new System.EventHandler(this.btnLimpiarConfiEmpresa_Click);
            // 
            // btnMinimizarConfiEmpresa
            // 
            this.btnMinimizarConfiEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarConfiEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarConfiEmpresa.FlatAppearance.BorderSize = 0;
            this.btnMinimizarConfiEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnMinimizarConfiEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnMinimizarConfiEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarConfiEmpresa.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizarConfiEmpresa.Location = new System.Drawing.Point(466, 3);
            this.btnMinimizarConfiEmpresa.Name = "btnMinimizarConfiEmpresa";
            this.btnMinimizarConfiEmpresa.Size = new System.Drawing.Size(33, 33);
            this.btnMinimizarConfiEmpresa.TabIndex = 4;
            this.btnMinimizarConfiEmpresa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimizarConfiEmpresa.UseVisualStyleBackColor = false;
            this.btnMinimizarConfiEmpresa.Click += new System.EventHandler(this.btn_Minimizar_Click_1);
            // 
            // btnCerrarConfiEmpresa
            // 
            this.btnCerrarConfiEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarConfiEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarConfiEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCerrarConfiEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnCerrarConfiEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnCerrarConfiEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarConfiEmpresa.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrarConfiEmpresa.Location = new System.Drawing.Point(499, 3);
            this.btnCerrarConfiEmpresa.Name = "btnCerrarConfiEmpresa";
            this.btnCerrarConfiEmpresa.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarConfiEmpresa.TabIndex = 5;
            this.btnCerrarConfiEmpresa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrarConfiEmpresa.UseVisualStyleBackColor = false;
            this.btnCerrarConfiEmpresa.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineContraseña});
            this.shapeContainer1.Size = new System.Drawing.Size(539, 440);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 538;
            this.lineShape1.Y1 = 41;
            this.lineShape1.Y2 = 41;
            // 
            // lineContraseña
            // 
            this.lineContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineContraseña.BorderColor = System.Drawing.Color.Blue;
            this.lineContraseña.BorderWidth = 4;
            this.lineContraseña.Enabled = false;
            this.lineContraseña.Name = "lineContraseña";
            this.lineContraseña.X1 = 0;
            this.lineContraseña.X2 = 538;
            this.lineContraseña.Y1 = 391;
            this.lineContraseña.Y2 = 392;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 443);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

#endregion
        private System.Windows.Forms.Timer t_splash;
        private System.Windows.Forms.Timer t_Acceder;
        private System.Windows.Forms.TextBox txtUsusario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnCerrarConfiEmpresa;
        private System.Windows.Forms.Button btnMinimizarConfiEmpresa;
        private System.Windows.Forms.Button btnLimpiarConfiEmpresa;
        private System.Windows.Forms.Panel pnlLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineContraseña;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        //private SystemSCADA.Vistas.uCtrlBoton uCtrlBotonPrueba;
    }
}