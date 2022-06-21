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
    public partial class FrmRegistroEN : Form
    {
        List<Pais> CountriesList = new List<Pais>();
        List<Pais> CountriesFilterList = new List<Pais>();
        public FrmRegistroEN()
        {
            InitializeComponent();
            ObtenerTodosPaises();
        }
              
        private void cboContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboContinent.SelectedIndex == 0)
            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Japan");
                cboCountry.Items.Add("China");
                cboCountry.Items.Add("Indonesia");
                cboCountry.Items.Add("Korea");
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
              
        private void btnAnalyze_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtAge.Text == "")
                    txtAge.Text = "0";

                if (!(int.Parse(txtAge.Text) >= 18) || !(int.Parse(txtAge.Text) <= 120))
                {
                    MessageBox.Show("Enter a valid age, please try again");
                    return;
                }

                //preparacion de datos a filtrar
                bool _reqvisa = false;
                bool IgnoreVisa = false;
                bool _reqTenerfam = false;
                bool IgnoreFamily = false;

                if (rbnVisaYES.Checked)
                    _reqvisa = true;
                else if (rbnVisaNOP.Checked)
                    _reqvisa = false;
                else
                    IgnoreVisa = true;

                if (rbnFamilyYES.Checked)
                    _reqTenerfam = true;
                else if (rbnFamilyNOP.Checked)
                    _reqTenerfam = false;
                else
                    IgnoreFamily = true;


                List<string> listaseelccion = new List<string>();

                if (ckbSpanish.Checked) listaseelccion.Add("Spanish");
                if (ckbGerman.Checked) listaseelccion.Add("German");
                if (ckbFinnish.Checked) listaseelccion.Add("Finnish");
                if (ckbEnglish.Checked) listaseelccion.Add("English");
                if (ckbRussian.Checked) listaseelccion.Add("Russian");
                if (ckbPortuguese.Checked) listaseelccion.Add("Portuguese");
                if (ckbNorwegian.Checked) listaseelccion.Add("Norwegian");
                if (ckbFrench.Checked) listaseelccion.Add("French");
                if (ckbItalian.Checked) listaseelccion.Add("Italian");
                if (ckbHindu.Checked) listaseelccion.Add("Hindu");
                if (ckbJapanesse.Checked) listaseelccion.Add("Japanesse");

                decimal bolsa = Convert.ToDecimal(NupDoBudget.Text);

                //se trae todos los elements de la lista Países definidas
                var SQL = from item in CountriesList
                          select item;
                // se agregan restricciones si es que están seleccionadas
                if (!IgnoreVisa)
                    SQL = SQL.Where(p => p.visa == _reqvisa);
                if (!IgnoreFamily)
                    SQL = SQL.Where(p => p.Tenerfamilia == _reqTenerfam);
                if (bolsa > 0)
                    SQL = SQL.Where(p => p.bolsa_viaje <= bolsa);
                if (listaseelccion.Count > 0)
                    SQL = SQL.Where(p => p.idiomas.Any(y => listaseelccion.Contains(y)));

                //La expresión LINQ se convierte a Lista 
                CountriesFilterList = (SQL).ToList();

                //se llena la grilla

                FrmPaisEncontrado objeto2 = new FrmPaisEncontrado(CountriesFilterList);
                objeto2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred, please enter valid data", "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void LimpiarDatos()
        {
            //dgvPaises.DataSource = null;
            txtAge.Clear();
            cboContinent.Text = null;
            cboStudies.Text = null;
            cboGender.Text = null;
            cboCountry.Text= null;
            NupDoBudget.Value = 1500;
            rbnFamilyYES.Checked = false;
            rbnFamilyNOP.Checked = false;
            rbnVisaNOP.Checked = false;
            rbnVisaYES.Checked = false;
            ckbEnglish.Checked = false;
            ckbFinnish.Checked = false;
            ckbFrench.Checked = false;
            ckbGerman.Checked = false;
            ckbItalian.Checked = false;
            ckbNorwegian.Checked = false;
            ckbPortuguese.Checked = false;
            ckbRussian.Checked = false;
            ckbSpanish.Checked = false;
        }
        
        private void ObtenerTodosPaises()
        {

            //Europa (nombre, familia, presupuesto, visa, idiomas)
            Pais p1 = new Pais("Germany", false, 4030, true, new List<String> { "German" });
            Pais p2 = new Pais("USA", true, 4210, true, new List<String> { "English" });
            Pais p3 = new Pais("France", false, 4560, true, new List<String> { "French" });
            Pais p4 = new Pais("Canada", true, 4000, false, new List<String> { "French", "English" });
            Pais p5 = new Pais("Norway", true, 5100, true, new List<String> { "Norwegian", "English" });
            Pais p6 = new Pais("Finland", false, 4920, false, new List<String> { "Finnish" });
            Pais p7 = new Pais("Italy", true, 3200, true, new List<String> { "Italian" });

            //Latam (nombre, familia, presupuesto, visa, idiomas)
            Pais p8 = new Pais("Peru", true, 2126, true, new List<String> { "Quechua", "Spanish", "Aimara" });
            Pais p9 = new Pais("Venezuela", false, 3432, false, new List<String> { "Spanish" });
            Pais p10 = new Pais("Colombia", false, 3456, true, new List<String> { "Spanish" });
            Pais p11 = new Pais("Chile", true, 3432, false, new List<String> { "Spanish" });
            Pais p12 = new Pais("Bolivia", false, 2126, true, new List<String> { "Quechua", "Spanish", "Aimara" });
            Pais p13 = new Pais("Ecuador", false, 1500, false, new List<String> { "Spanish" });
            Pais p14 = new Pais("Brasil", true, 2100, false, new List<String> { "Portuguese" });

            //Asia (nombre, familia, presupuesto, visa, idiomas)
            Pais p15 = new Pais("Russia", false, 3100, true, new List<String> { "Russian" });
            Pais p16 = new Pais("India", true, 3100, true, new List<String> { "Hindu" });
            Pais p17 = new Pais("Japan", false, 3100, false, new List<String> { "Japanisse" });

            CountriesList.Add(p1);
            CountriesList.Add(p2);
            CountriesList.Add(p3);
            CountriesList.Add(p4);
            CountriesList.Add(p5);
            CountriesList.Add(p6);
            CountriesList.Add(p7);
            CountriesList.Add(p8);
            CountriesList.Add(p9);
            CountriesList.Add(p10);
            CountriesList.Add(p11);
            CountriesList.Add(p12);
            CountriesList.Add(p13);
            CountriesList.Add(p14);
            CountriesList.Add(p15);
            CountriesList.Add(p16);
            CountriesList.Add(p17);
        }

        private void gbo2_Click(object sender, EventArgs e)
        {
            rbnFamilyYES.Checked = false;
            rbnFamilyNOP.Checked = false;
            rbnVisaNOP.Checked = false;
            rbnVisaYES.Checked = false;
        }

        private void FrmRegistroEN_Load(object sender, EventArgs e)
        {

        }

        private void gbo2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
