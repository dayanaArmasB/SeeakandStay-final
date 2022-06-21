using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AvanzandoProyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cboIdioma.SelectedIndex == 1)
            {
                Registrarse.idioma = "ingles";
                Form3 b = new Form3();
                
               
                MessageBox.Show("Se ha seleccionado el idioma inglés correctamente", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (cboIdioma.SelectedIndex == 0)
            {
                Registrarse.idioma = "español";
                MessageBox.Show("Se ha seleccionado el idioma español correctamente", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
