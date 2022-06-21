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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsuario.Text = "Ingrese su usuario";
            txtPassword.Text = "Ingrese su contraseña";
            btnTapar.Enabled = false;
            btnTapar.Visible = false;
            btnMostrar.Enabled = true;
            btnMostrar.Visible = true;
        }
        int contador = 0;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form2 objetitoxd = new Form2();
           
            string[] arrayU = new string[12];
            string[] arrayC = new string[12];
            Registrarse.usuario = txtUsuario.Text;
            Registrarse.contraseña = txtPassword.Text;
        
            bool existe = false;

            if (txtUsuario.Text!="" && txtPassword.Text!="")
            {
                for (int i = 1; i < objetitoxd.dgvDatos.RowCount; i++)
                {
                    arrayU[i] += objetitoxd.dgvDatos.Rows[i].Cells[0].Value.ToString();
                    arrayC[i] += objetitoxd.dgvDatos.Rows[i].Cells[1].Value.ToString();

                }
                for (int i = 1; i < objetitoxd.dgvDatos.RowCount; i++)
                {
                    if (Registrarse.usuario == arrayU[i])
                    {
                        existe = true;
                        if (Registrarse.contraseña == arrayC[i])
                        {
                            //pontodoelcodigo
                            Form3 objeto = new Form3();
                            objeto.ShowDialog();
                            continue;
                        }
                        if (Registrarse.usuario == arrayU[i] && Registrarse.contraseña != arrayC[i])
                        {
                            contador++;
                            if (contador < 3) { MessageBox.Show("Contraseña incorrecta"); }
                            if (contador >= 3) { MessageBox.Show("Mucho we"); }
                        }
                    }
                }
                if (existe == false) { MessageBox.Show("La cuenta no existe"); }
            }
            
            if (txtUsuario.Text == "" && txtPassword.Text == "") { MessageBox.Show("No se ha ingresado ni usuario ni contraseña"); }
            else
            {
                if (txtUsuario.Text == "") { MessageBox.Show("No se ha ingresado un usuario"); }
                if (txtPassword.Text == "") { MessageBox.Show("No se ha ingresado una contraseña"); }
                if (txtUsuario.Text == " ") { MessageBox.Show("No se ha ingresado un usuario"); }
                if (txtPassword.Text == " ") { MessageBox.Show("No se ha ingresado una contraseña"); }
                if (txtUsuario.Text == "   ") { MessageBox.Show("No se ha ingresado un usuario"); }
                if (txtPassword.Text == "   ") { MessageBox.Show("No se ha ingresado una contraseña"); }
                if (txtUsuario.Text == "    ") { MessageBox.Show("No se ha ingresado un usuario"); }
                if (txtPassword.Text == "    ") { MessageBox.Show("No se ha ingresado una contraseña"); }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form2 objeto = new Form2();
            objeto.ShowDialog();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";          
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

       
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (btnTapar.Visible == false)
            {
                btnMostrar.Enabled = false;
                btnMostrar.Visible = false;
                txtPassword.UseSystemPasswordChar = false;
                btnTapar.Enabled = true;
                btnTapar.Visible = true;
            }
        }

        private void btnTapar_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnMostrar.Visible == false)
            {
                btnTapar.Enabled = false;
                btnTapar.Visible = false;
                txtPassword.UseSystemPasswordChar = true;
                btnMostrar.Enabled = true;
                btnMostrar.Visible = true;
            }
        }

        #region cerraryminimizar
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }
        #endregion

        #region mover_formulario
        //para mover el form
        int m, mx, my;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my=e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

            }
        }


        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        #endregion
    }
}