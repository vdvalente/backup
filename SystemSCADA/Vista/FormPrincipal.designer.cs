namespace SystemSCADA.Vista
{
    partial class FormInterfaz
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            this.pnl_InterfazScada = new System.Windows.Forms.Panel();
            this.picAlarmaApagada = new System.Windows.Forms.PictureBox();
            this.picAlarmaEncendiendo = new System.Windows.Forms.PictureBox();
            this.txtHumo = new System.Windows.Forms.TextBox();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.picLuzApagada = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblAlarma = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAlarmaEncendida = new System.Windows.Forms.PictureBox();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.picLuzEncendida = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_Movimiento = new System.Windows.Forms.Timer(this.components);
            this.Timer_Temperatura = new System.Windows.Forms.Timer(this.components);
            this.Timer_Humo = new System.Windows.Forms.Timer(this.components);
            this.pnl_InterfazScada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaApagada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaEncendiendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuzApagada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaEncendida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuzEncendida)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_InterfazScada
            // 
            this.pnl_InterfazScada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_InterfazScada.Controls.Add(this.picAlarmaApagada);
            this.pnl_InterfazScada.Controls.Add(this.picAlarmaEncendiendo);
            this.pnl_InterfazScada.Controls.Add(this.txtHumo);
            this.pnl_InterfazScada.Controls.Add(this.aGauge1);
            this.pnl_InterfazScada.Controls.Add(this.picLuzApagada);
            this.pnl_InterfazScada.Controls.Add(this.btnCerrar);
            this.pnl_InterfazScada.Controls.Add(this.btnMinimizar);
            this.pnl_InterfazScada.Controls.Add(this.lblTemperatura);
            this.pnl_InterfazScada.Controls.Add(this.lblAlarma);
            this.pnl_InterfazScada.Controls.Add(this.lblTitulo);
            this.pnl_InterfazScada.Controls.Add(this.label1);
            this.pnl_InterfazScada.Controls.Add(this.picAlarmaEncendida);
            this.pnl_InterfazScada.Controls.Add(this.lblIndicador);
            this.pnl_InterfazScada.Controls.Add(this.cmbCamara);
            this.pnl_InterfazScada.Controls.Add(this.videoSourcePlayer1);
            this.pnl_InterfazScada.Controls.Add(this.btnIniciar);
            this.pnl_InterfazScada.Controls.Add(this.btnDetener);
            this.pnl_InterfazScada.Controls.Add(this.label6);
            this.pnl_InterfazScada.Controls.Add(this.textBox1);
            this.pnl_InterfazScada.Controls.Add(this.shapeContainer2);
            this.pnl_InterfazScada.Controls.Add(this.picLuzEncendida);
            this.pnl_InterfazScada.Location = new System.Drawing.Point(0, 0);
            this.pnl_InterfazScada.Name = "pnl_InterfazScada";
            this.pnl_InterfazScada.Size = new System.Drawing.Size(1385, 787);
            this.pnl_InterfazScada.TabIndex = 0;
            // 
            // picAlarmaApagada
            // 
            this.picAlarmaApagada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAlarmaApagada.Image = global::SystemSCADA.Properties.Resources.alarma3;
            this.picAlarmaApagada.Location = new System.Drawing.Point(1164, 85);
            this.picAlarmaApagada.Name = "picAlarmaApagada";
            this.picAlarmaApagada.Size = new System.Drawing.Size(165, 113);
            this.picAlarmaApagada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmaApagada.TabIndex = 38;
            this.picAlarmaApagada.TabStop = false;
            // 
            // picAlarmaEncendiendo
            // 
            this.picAlarmaEncendiendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAlarmaEncendiendo.Image = global::SystemSCADA.Properties.Resources.alarma2;
            this.picAlarmaEncendiendo.Location = new System.Drawing.Point(1164, 85);
            this.picAlarmaEncendiendo.Name = "picAlarmaEncendiendo";
            this.picAlarmaEncendiendo.Size = new System.Drawing.Size(165, 113);
            this.picAlarmaEncendiendo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmaEncendiendo.TabIndex = 39;
            this.picAlarmaEncendiendo.TabStop = false;
            // 
            // txtHumo
            // 
            this.txtHumo.Location = new System.Drawing.Point(1194, 204);
            this.txtHumo.Name = "txtHumo";
            this.txtHumo.Size = new System.Drawing.Size(100, 20);
            this.txtHumo.TabIndex = 37;
            this.txtHumo.Visible = false;
            // 
            // aGauge1
            // 
            this.aGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel1.Color = System.Drawing.Color.Red;
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel1.Text = null;
            aGaugeLabel2.Color = System.Drawing.Color.Red;
            aGaugeLabel2.Name = "GaugeLabel";
            aGaugeLabel2.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel2.Text = null;
            this.aGauge1.GaugeLabels.Add(aGaugeLabel1);
            this.aGauge1.GaugeLabels.Add(aGaugeLabel2);
            aGaugeRange1.Color = System.Drawing.Color.Red;
            aGaugeRange1.EndValue = 60F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "Critico";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 45F;
            aGaugeRange2.Color = System.Drawing.Color.Yellow;
            aGaugeRange2.EndValue = 45F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "Advertencia";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 35F;
            aGaugeRange3.Color = System.Drawing.Color.Lime;
            aGaugeRange3.EndValue = 35F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "Bien";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 0F;
            aGaugeRange4.Color = System.Drawing.Color.Blue;
            aGaugeRange4.EndValue = 0F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "Frio";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = -20F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange1);
            this.aGauge1.GaugeRanges.Add(aGaugeRange2);
            this.aGauge1.GaugeRanges.Add(aGaugeRange3);
            this.aGauge1.GaugeRanges.Add(aGaugeRange4);
            this.aGauge1.Location = new System.Drawing.Point(1146, 280);
            this.aGauge1.MaxValue = 60F;
            this.aGauge1.MinValue = -20F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 24;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // picLuzApagada
            // 
            this.picLuzApagada.Image = global::SystemSCADA.Properties.Resources.Button_off;
            this.picLuzApagada.Location = new System.Drawing.Point(836, 55);
            this.picLuzApagada.Name = "picLuzApagada";
            this.picLuzApagada.Size = new System.Drawing.Size(80, 82);
            this.picLuzApagada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLuzApagada.TabIndex = 8;
            this.picLuzApagada.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1328, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 37);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1295, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 36);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(1142, 463);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(207, 19);
            this.lblTemperatura.TabIndex = 25;
            this.lblTemperatura.Text = "Estado de la Temperatura";
            // 
            // lblAlarma
            // 
            this.lblAlarma.AutoSize = true;
            this.lblAlarma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarma.Location = new System.Drawing.Point(1174, 55);
            this.lblAlarma.Name = "lblAlarma";
            this.lblAlarma.Size = new System.Drawing.Size(134, 19);
            this.lblAlarma.TabIndex = 26;
            this.lblAlarma.Text = "Sensor De Humo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1307, 28);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "SCADA SYSTEM ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moverForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Seleccione el dispositivo ";
            // 
            // picAlarmaEncendida
            // 
            this.picAlarmaEncendida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAlarmaEncendida.Image = global::SystemSCADA.Properties.Resources.alarma;
            this.picAlarmaEncendida.Location = new System.Drawing.Point(1164, 85);
            this.picAlarmaEncendida.Name = "picAlarmaEncendida";
            this.picAlarmaEncendida.Size = new System.Drawing.Size(165, 113);
            this.picAlarmaEncendida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmaEncendida.TabIndex = 30;
            this.picAlarmaEncendida.TabStop = false;
            // 
            // lblIndicador
            // 
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicador.Location = new System.Drawing.Point(590, 72);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(213, 23);
            this.lblIndicador.TabIndex = 5;
            this.lblIndicador.Text = "Sensor De Movimiento";
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(277, 85);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(121, 21);
            this.cmbCamara.TabIndex = 34;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 144);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(1136, 616);
            this.videoSourcePlayer1.TabIndex = 31;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayer1_NewFrame);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(16, 56);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(101, 23);
            this.btnIniciar.TabIndex = 32;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.Location = new System.Drawing.Point(16, 85);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(101, 23);
            this.btnDetener.TabIndex = 33;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1152, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Temperatura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1277, 510);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "0.00C°";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1383, 785);
            this.shapeContainer2.TabIndex = 36;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 1385;
            this.lineShape1.Y1 = 45;
            this.lineShape1.Y2 = 45;
            // 
            // picLuzEncendida
            // 
            this.picLuzEncendida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLuzEncendida.Image = global::SystemSCADA.Properties.Resources.Button_on;
            this.picLuzEncendida.Location = new System.Drawing.Point(836, 56);
            this.picLuzEncendida.Name = "picLuzEncendida";
            this.picLuzEncendida.Size = new System.Drawing.Size(80, 81);
            this.picLuzEncendida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLuzEncendida.TabIndex = 6;
            this.picLuzEncendida.TabStop = false;
            // 
            // Timer_Movimiento
            // 
            this.Timer_Movimiento.Enabled = true;
            this.Timer_Movimiento.Interval = 200;
            this.Timer_Movimiento.Tick += new System.EventHandler(this.Timer_Movimiento_Tick);
            // 
            // Timer_Temperatura
            // 
            this.Timer_Temperatura.Enabled = true;
            this.Timer_Temperatura.Interval = 1000;
            this.Timer_Temperatura.Tick += new System.EventHandler(this.Timer_Temperatura_Tick);
            // 
            // Timer_Humo
            // 
            this.Timer_Humo.Interval = 2000;
            this.Timer_Humo.Tick += new System.EventHandler(this.Timer_Humo_Tick);
            // 
            // FormInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnl_InterfazScada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInterfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInterfaz_Load);
            this.pnl_InterfazScada.ResumeLayout(false);
            this.pnl_InterfazScada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaApagada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaEncendiendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuzApagada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmaEncendida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuzEncendida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_InterfazScada;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIndicador;
        private System.Windows.Forms.PictureBox picLuzEncendida;
        private System.Windows.Forms.PictureBox picLuzApagada;
        public System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblAlarma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picAlarmaEncendida;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Timer Timer_Movimiento;
        private System.Windows.Forms.Timer Timer_Temperatura;
        private System.Windows.Forms.Timer Timer_Humo;
        private System.Windows.Forms.TextBox txtHumo;
        private System.Windows.Forms.PictureBox picAlarmaEncendiendo;
        private System.Windows.Forms.PictureBox picAlarmaApagada;
    }
}

