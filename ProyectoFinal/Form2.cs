using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AvanzandoProyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            leedatos();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {

                if (txtContraseña.Text == txtConfir.Text)
                {
                    Registrarse.usu = txtUsuario.Text;
                    Registrarse.contra = txtContraseña.Text;
                    Registrarse.confir = txtConfir.Text;
                    string guardado = "";
                    guardado += Registrarse.usu + ",";
                    guardado += Registrarse.confir;
                    StreamWriter writer = File.AppendText("c:\\data\\UsuariosRegistrados.txt");
                    writer.WriteLine(guardado);
                    writer.Close();

                    MessageBox.Show("Te has registrado con éxito", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    leedatos();                  
                }

                else { MessageBox.Show("Los datos ingresados no han sido correctos"); }
            }
            else
            {
                MessageBox.Show("No se aceptan cadenas vacias de texto");
            }
           
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*gb2.Visible = true;
            gb2.Enabled = false;*/
        }
        public void leedatos()
        {
            StreamReader lector = new StreamReader("c:\\data\\UsuariosRegistrados.txt");
            dgvDatos.Rows.Clear();
            string linea = "";
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(',');
                    dgvDatos.Rows.Add(datos);
                }
            } while (linea != null);
            lector.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }    
}
