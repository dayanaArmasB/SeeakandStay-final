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

namespace AvanzandoProyecto
{
   
    
    public partial class PaisEncontrado : Form
    {
        
        public PaisEncontrado()
        {
           
            
            string acumulado = "";
            InitializeComponent();
           
            lblEditable.Text ="Los paises a los que puede viajar son :" + "\r\n" + Registrarse.paisEncontrado;


            if (Registrarse.paisEncontrado == "")
            {
                lblEditable.Text = "No se ha encontrado paises disponibles para usted";
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Registrarse.paisEncontrado = "";
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


        private void btnEncuentra_Click(object sender, EventArgs e)
        {
            if (Registrarse.paisEncontrado=="")
            {
                lblOrdenar.Text = "No hay paises para ordenar";
            }
           
           
            int aux;
            for (int i = 0; i < Registrarse.bolsa.Length; i++)
            {
                for (int j = i + 1; j < Registrarse.bolsa.Length; j++)
                {
                    if (Registrarse.bolsa[i] > Registrarse.bolsa[j])
                    {
                        
                            aux = Registrarse.bolsa[i];
                            Registrarse.bolsa[i] = Registrarse.bolsa[j];
                            Registrarse.bolsa[j] = aux;
                        
                        
                    }
                }
            }
            mostrarVector(lblOrdenar, Registrarse.bolsa);

        }
        private void mostrarVector(Label txt, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (Registrarse.bolsa[i]!=12345)
                {
                    txt.Text += vector[i] + "\r\n ";
                }
                
            }
        }

    }
}
