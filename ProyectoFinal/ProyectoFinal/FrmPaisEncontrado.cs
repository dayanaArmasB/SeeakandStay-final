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
    public partial class FrmPaisEncontrado : Form
    {
        public FrmPaisEncontrado(List<Pais> lspaises)
        {
            InitializeComponent();
            dgvPaises.DataSource = lspaises; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region desplazarform
        int m, mx, my;
       
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

            }
        }
        #endregion 
        private void PaisEncontrado_Load(object sender, EventArgs e)
        {

        }


    }
}
