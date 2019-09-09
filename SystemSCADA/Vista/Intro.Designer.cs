namespace SystemSCADA.Vista
{
    partial class Intro
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
            this.t_Splash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // t_Splash
            // 
            this.t_Splash.Interval = 270;
            this.t_Splash.Tick += new System.EventHandler(this.T_Splash_Tick);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Intro";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t_Splash;
    }
}