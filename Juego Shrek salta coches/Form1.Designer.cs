namespace Juego_Shrek_salta_coches
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.chuek = new System.Windows.Forms.PictureBox();
            this.Carretera = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chuek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // chuek
            // 
            this.chuek.BackColor = System.Drawing.Color.Transparent;
            this.chuek.Image = global::Juego_Shrek_salta_coches.Properties.Resources.Shrek;
            this.chuek.Location = new System.Drawing.Point(25, 240);
            this.chuek.Name = "chuek";
            this.chuek.Size = new System.Drawing.Size(61, 56);
            this.chuek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chuek.TabIndex = 3;
            this.chuek.TabStop = false;
            // 
            // Carretera
            // 
            this.Carretera.Image = ((System.Drawing.Image)(resources.GetObject("Carretera.Image")));
            this.Carretera.Location = new System.Drawing.Point(-12, 298);
            this.Carretera.Name = "Carretera";
            this.Carretera.Size = new System.Drawing.Size(931, 10);
            this.Carretera.TabIndex = 2;
            this.Carretera.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Location = new System.Drawing.Point(222, 57);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(84, 49);
            this.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnReset.TabIndex = 4;
            this.BtnReset.TabStop = false;
            this.BtnReset.Visible = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 359);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.Carretera);
            this.Controls.Add(this.chuek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.chuek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox chuek;
        private System.Windows.Forms.PictureBox Carretera;
        private System.Windows.Forms.PictureBox BtnReset;
    }
}

