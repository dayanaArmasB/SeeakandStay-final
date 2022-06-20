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

namespace AvanzandoProyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Bitmap icono = new Bitmap("icon_play.png");
            btn_musica.Image = icono;
            cboIdioma.Text = "Español";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cboIdioma.SelectedIndex == 1)
            {
                Registrarse.idioma = "ingles";
                Form3 b = new Form3();
                
               
                MessageBox.Show("The English language has been selected correctly", "Idiom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (cboIdioma.SelectedIndex == 0)
            {
                Registrarse.idioma = "español";
                MessageBox.Show("Se ha seleccionado el idioma español correctamente", "Idioma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        SoundPlayer soundPlayer = new SoundPlayer("backsound1.wav");
        bool on;
      

        public void iniciomusica()
        {
            Bitmap icono = new Bitmap("icon_play.png");
            btn_musica.Image = icono;
            soundPlayer.Play();
        }


        private void btn_musica_Click_1(object sender, EventArgs e)
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
    }
}
