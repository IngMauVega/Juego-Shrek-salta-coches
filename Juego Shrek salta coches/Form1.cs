using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Juego_Shrek_salta_coches
{
    public partial class Form1 : Form
    {
        int PosicionInicialPisoY = 296;
        int PosicionInicialpisoX = 5;
        int velocidad = 5;
        bool brincochuek;
        PictureBox cocheIzq = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }
        public void iniciarjuego()
        {

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Space)))
            {
                brincochuek = true;
            }        
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pospiso;
            pospiso = Carretera.Location.X - 5;
            Carretera.Location = new Point(pospiso, PosicionInicialPisoY);
            if (pospiso < -130)
            {
                pospiso = PosicionInicialpisoX;
                Carretera.Location = new Point(PosicionInicialpisoX, PosicionInicialPisoY);
            }
           
        }
        public void generarcoche()
        {

            PictureBox coche2 = new PictureBox();
            coche2.Image = Image.FromFile(Application.StartupPath + (@"\IMG\vocho.jpg"));
            coche2.Location = new Point(430, 260);
            coche2.BackColor = Color.Transparent;
            coche2.SizeMode = PictureBoxSizeMode.Zoom;            
            cocheIzq = coche2;
            this.Controls.Add(coche2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int lx = cocheIzq.Location.X;
            int ly = cocheIzq.Location.Y;
            this.Controls.Remove(cocheIzq);
            lx = lx - 15;
            PictureBox coche2 = new PictureBox();
            coche2.Image = Image.FromFile(Application.StartupPath + (@"\IMG\vocho.jpg"));
            coche2.Location = new Point(lx, ly);
            coche2.BackColor = Color.Transparent;
            coche2.SizeMode = PictureBoxSizeMode.StretchImage;
            cocheIzq = coche2;
            this.Controls.Add(coche2);
            // int puntuacion = Convert.ToInt32(lblpuntos.Text);
            if (coche2.Location.X < 0)
            {
                this.Controls.Remove(coche2);
                timer2.Interval = timer2.Interval - 5;
                if (timer2.Interval<=5)
                {
                    timer2.Interval = 8;
                }
                //puntuacion = puntuacion + 1;
                generarcoche();
            }
            if (chuek.Bounds.IntersectsWith(coche2.Bounds))
                {
                timer1.Stop(); timer2.Stop(); timer3.Stop();this.Controls.Remove(chuek);
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = Application.StartupPath + (@"\sonidos\uh.wav");
                player.Play();
                BtnReset.Visible = true;
            }

            }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (brincochuek)
            {
                int Brinco = chuek.Location.Y - 20;
                chuek.Location = new Point(chuek.Location.X, Brinco);
                if (Brinco <= 160)
                {
                    brincochuek = false;
                }
            }
            else
            {
                if (chuek.Location.Y < 250)
                {
                    int Brinco = chuek.Location.Y + 10;
                    chuek.Location = new Point(chuek.Location.X, Brinco);

                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            iniciarjuego();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
    }

