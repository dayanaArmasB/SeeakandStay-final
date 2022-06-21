using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;
using System.Media;

namespace AvanzandoProyecto
{
    public partial class Form3 : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer("backsound1.wav");
        bool on;
        public Form3()
        {
            InitializeComponent();
            iniciomusica();
        }
      
        #region cerraryminimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region desplazarform
        int m, mx, my;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }  
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        #endregion 


        private void btnEncuentra_Click(object sender, EventArgs e)
        {
          
            if (Registrarse.idioma=="ingles")
            {
                AbrirFormHija(new FrmRegistroEN());
            }
            else
            {
                AbrirFormHija(new FrmRegistroES());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form9());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEncuentra_TextChanged(object sender, EventArgs e)
        {
            if (Registrarse.idioma=="ingles")
            {
                btnEncuentra.Text ="find your destiny";
            }
        }

        private void btn_musica_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Bitmap icono = new Bitmap("icon_play.png");
                btn_musica.Image = icono;
                soundPlayer.Play();
                on = false;
            }
            else
            {
                Bitmap icono = new Bitmap("icon_mute.png");
                btn_musica.Image = icono;
                soundPlayer.Stop();
                on = true;
            }
        }

        public void iniciomusica()
        {
            Bitmap icono = new Bitmap("icon_play.png");
            btn_musica.Image = icono;
            soundPlayer.Play();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {


            AbrirFormHija(new Form5());
        }
        private void AbrirFormHija (object formhija)
        {
            if (this.panelcontenedor.Controls.Count>0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
           
        }

       
    }
}
