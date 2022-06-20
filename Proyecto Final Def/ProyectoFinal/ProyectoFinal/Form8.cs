using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvanzandoProyecto;
using ProyectoFinal;

namespace ProyectoFinal
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

      

        private void cboContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboContinent.SelectedIndex == 0)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Japan");
                cboCountry.Items.Add("China");
                cboCountry.Items.Add("Indonesia");
            }

            if (cboContinent.SelectedIndex == 1)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Nigeria");
                cboCountry.Items.Add("Ghana");
                cboCountry.Items.Add("South Africa");
            }

            if (cboContinent.SelectedIndex == 2)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Peru");
                cboCountry.Items.Add("Argentina");
                cboCountry.Items.Add("Chile");
            }

            if (cboContinent.SelectedIndex == 3)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Mexico");
                cboCountry.Items.Add("United States");
                cboCountry.Items.Add("Canada");
            }

            if (cboContinent.SelectedIndex == 4)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Ukraine");
                cboCountry.Items.Add("Germany");
                cboCountry.Items.Add("France");
            }

            if (cboContinent.SelectedIndex == 5)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("New Zealand");
                cboCountry.Items.Add("Australia");
                cboCountry.Items.Add("New Guinea");
            }
        }
        
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboContinent.SelectedIndex == 0 || cboContinent.SelectedIndex == 1 || cboContinent.SelectedIndex == 2 || cboContinent.SelectedIndex == 3
               || cboContinent.SelectedIndex == 4 || cboContinent.SelectedIndex == 5) && (cboCountry.SelectedIndex == 0 || cboCountry.SelectedIndex == 1
               || cboCountry.SelectedIndex == 2) && (cboEstudios.SelectedIndex == 0 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 2)
               && (cboGender.SelectedIndex == 0 || cboGender.SelectedIndex == 1 || cboGender.SelectedIndex == 2) && Convert.ToInt32(txtAge.Text) < 100)
                {
                    for (int i = 0; i < 21; i++)
                    {
                        Registrarse.bolsa[i] = 12345;
                    }


                    try
                    {
                        //FRANCIA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 5000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "Francia:5000" + "\r\n";
                            Registrarse.bolsa[0] = 5000;
                        }

                        //INGLATERRA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 5000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "Inglaterra:5000" + "\r\n";
                            Registrarse.bolsa[1] = 5000;
                        }

                        //ESPAÑA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 5000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "España:5000" + "\r\n";
                            Registrarse.bolsa[2] = 5000;
                        }

                        //ITALIA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 5000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "Italia:5000" + "\r\n";
                            Registrarse.bolsa[3] = 5000;
                        }


                        //EEUU
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 10000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25 && cboContinent.SelectedIndex == 4)
                        {
                            Registrarse.paisEncontrado += "Estados unidos:10000" + "\r\n";
                            Registrarse.bolsa[4] = 10000;
                        }
                        //CANADA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 10000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25 && cboContinent.SelectedIndex == 4)
                        {
                            Registrarse.paisEncontrado += "Canada:10000" + "\r\n";
                            Registrarse.bolsa[5] = 10000;
                        }

                        //ALEMANIA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 10000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25 && cboContinent.SelectedIndex == 4)
                        {
                            Registrarse.paisEncontrado += "Alemania:10000" + "\r\n";
                            Registrarse.bolsa[6] = 10000;
                        }

                        //SUIZA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 10000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "Suiza:10000" + "\r\n";
                            Registrarse.bolsa[7] = 10000;
                        }

                        //HOLANDA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 10000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 25)
                        {
                            Registrarse.paisEncontrado += "Holanda:10000" + "\r\n";
                            Registrarse.bolsa[8] = 10000;
                        }

                        //BRASIL
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 2000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Brasil:2000" + "\r\n";
                            Registrarse.bolsa[9] = 2000;
                        }

                        //ARGENTINA
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 2000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Argentina:2000" + "\r\n";
                            Registrarse.bolsa[10] = 2000;
                        }

                        //COLOMBIA
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 2000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Colombia:2000" + "\r\n";
                            Registrarse.bolsa[11] = 2000;
                        }

                        //MEXICO
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 2000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Mexico:2000" + "\r\n";
                            Registrarse.bolsa[12] = 2000;
                        }

                        //BOLIVIA
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 1000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Bolivia:1000" + "\r\n";
                            Registrarse.bolsa[13] = 1000;
                        }

                        //PARAGUAY
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) > 1000 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Paraguay:1000" + "\r\n";
                            Registrarse.bolsa[14] = 1000;
                        }

                        //VENEZUELA
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) >= 0 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Venezuela:0" + "\r\n";
                            Registrarse.bolsa[15] = 0;
                        }

                        //PERU
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) >= 0 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Peru:0" + "\r\n";
                            Registrarse.bolsa[16] = 0;
                        }

                        //SALVADOR
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) >= 0 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Salvador:0" + "\r\n";
                            Registrarse.bolsa[17] = 0;
                        }

                        //HONDURAS
                        if ((rbSi.Checked == true || rbNo.Checked == true) && Convert.ToInt32(txtBag.Text) >= 0 && (cboEstudios.SelectedIndex == 2 || cboEstudios.SelectedIndex == 1 || cboEstudios.SelectedIndex == 0) && Convert.ToInt32(txtAge.Text) > 18)
                        {
                            Registrarse.paisEncontrado += "Honduras:0" + "\r\n";
                            Registrarse.bolsa[18] = 0;
                        }

                        //RUSIA
                        if (rbSi.Checked == true && Convert.ToInt32(txtBag.Text) > 5000 && cboEstudios.SelectedIndex == 2 && Convert.ToInt32(txtAge.Text) > 18 && cboContinent.SelectedIndex == 4)
                        {
                            Registrarse.paisEncontrado += "Rusia:5000" + "\r\n";
                            Registrarse.bolsa[19] = 0;
                        }

                        PaisEncontrado objeto = new PaisEncontrado();
                        objeto.ShowDialog();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ingrese valores validos por favor");
                        Limpiar.limpiarBoton(cboCountry, cboContinent, cboEstudios, cboGender, txtAge, txtBag, rbSi, rbNo);
                    }
                }

                else
                {
                    MessageBox.Show("Enter values valides please");
                    Limpiar.limpiarBoton(cboCountry, cboContinent, cboEstudios, cboGender, txtAge, txtBag, rbSi, rbNo);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Ingrese valores validos por favor");
                Limpiar.limpiarBoton(cboCountry, cboContinent, cboEstudios, cboGender, txtAge, txtBag, rbSi, rbNo);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.limpiarBoton(cboCountry, cboContinent, cboEstudios, cboGender,txtAge, txtBag,rbSi,rbNo);
        }
    }
}
