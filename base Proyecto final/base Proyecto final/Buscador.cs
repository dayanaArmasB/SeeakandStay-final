using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_Proyecto_final
{
    public partial class Buscador : Form
    {
        List<Pais> ListaPaises = new List<Pais>();
        List<Pais> ListaPaisesFiltrados = new List<Pais>();
        public Buscador()
        {
            InitializeComponent();
            ObtenerTodosPaises();
            //cmbBolsaViaje.Text = "0";
        }

        private void cmbContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ListDefault = new[] { "Seleccionar País" };
            //var ListNorthAmerica = new[] { "Canadá", "USA", "mexico" };
            //var ListAsia = new[] { "Rusia", "China", "Japón", "corea" };
            //var ListEurope = new[] { "Francia", "España", "Alemania", "italia","Paises bajos" };
            //var ListOceania = new[] { "Australia", "Nueva Zelanda" };
            //var ListSouthAmerica = new[] { "argentina", "chile", "bolivia", "Ecuador", "Colombia, Peru" };
            //var ListCenterAmerica = new[] { "Honduras", "guatemala", "costa rica", "puerto rico" };
            //switch (cmbContinente.Text)
            //{
            //    case "America de norte":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListNorthAmerica;
            //        break;
            //    case "Asia":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListAsia;
            //        break;
            //    case "Europa":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListEurope;
            //        break;
            //    case "Oceania":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListOceania;
            //        break;
            //    case "America del sur":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListSouthAmerica;
            //        break;
            //    case "Centro America":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListCenterAmerica;
            //        break;
            //    case "Seleccionar Continente":
            //        cmbPais.DataSource = null;
            //        cmbPais.DataSource = ListDefault;
            //        break;
            //}
        }

        private void ckbBengali_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbArabe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbAleman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //LimpiarDatos();
            //preparacion de datos a filtrar
            bool _reqvisa = false;
            bool IgnorarVisa = false;
            bool _reqTenerfam = false; 
            bool IgnorarFamilia = false;

            if (rbVisaSi.Checked)
                _reqvisa = true;
            else if (rbVisaNo.Checked)
                _reqvisa = false;
            else
                IgnorarVisa = true;

            if (rbFamiliaSi.Checked)
                _reqTenerfam = true;
            else if (rbFamiliaNo.Checked)
                _reqTenerfam = false;
            else
                IgnorarFamilia = true;
            
            
            List<string> listaseelccion = new List<string>();

            if (ckbEspañol.Checked) listaseelccion.Add("Español");
            if (ckbAleman.Checked) listaseelccion.Add("Deutsch");
            if (ckbFinlandes.Checked) listaseelccion.Add("Finlandés");
            if (ckbIngles.Checked) listaseelccion.Add("English");
            if (ckbRuso.Checked) listaseelccion.Add("русская");
            if (ckbPortugues.Checked) listaseelccion.Add("Português");
            if (ckbNoruego.Checked) listaseelccion.Add("Norsk");
            if (ckbFinlandes.Checked) listaseelccion.Add("Suomalainen");
            if (ckbItaliano.Checked) listaseelccion.Add("Italiano");

            if (Convert.ToDecimal(cmbBolsaViaje.Text) <= 0)
                cmbBolsaViaje.Text = "0";

            decimal bolsa = Convert.ToDecimal(cmbBolsaViaje.Text);

            //se trae todos los elements de la lista Países definidas
            var SQL = from item in ListaPaises
                      select item;
            // se agregan restricciones si es que están seleccionadas
            if (!IgnorarVisa) 
            SQL = SQL.Where(p => p.visa == _reqvisa);
            if (!IgnorarFamilia)
            SQL = SQL.Where(p => p.Tenerfamilia == _reqTenerfam);
            if (bolsa > 0)
            SQL = SQL.Where(p => p.bolsa_viaje <= bolsa);
            if (listaseelccion.Count > 0)
            SQL = SQL.Where(p => p.idiomas.Any(y => listaseelccion.Contains(y)));
            
            //La expresión LINQ se convierte a Lista 
            ListaPaisesFiltrados = (SQL).ToList();

            //se llena la grilla
            dgvPaises.DataSource = ListaPaisesFiltrados;
        }

        //private void LimpiarDatos()
        //{
        //    dgvPaises.DataSource = null;
        //}
        //private void ValidarDatos()
        //{
        //    if (cmbBolsaViaje.Text =="")
        //    {
        //        cmbBolsaViaje.Text = "4000";
        //    }
        //}

        private void ObtenerTodosPaises()
        {
            
            //Europa (nombre, familia, presupuesto, visa, idiomas)
            Pais p1 = new Pais("Alemania", false, 4000, true, new List<String> {"Deutsch" }); 
            Pais p2 = new Pais("USA", true, 4000, true, new List<String> {"English" });
            Pais p3 = new Pais("Francia", false, 4000, true, new List<String> {"Français" });
            Pais p4 = new Pais("Canadá", true, 4000, false, new List<String> {"Français", "English" });
            Pais p5 = new Pais("Noruega", true, 4000, false, new List<String> { "Norsk", "English" });
            Pais p6 = new Pais("Finlandia", false, 4000, false, new List<String> {"Suomalainen" });
            Pais p7 = new Pais("Italia", true, 3200, true, new List<String> {"Itaiano"});

            //Latam (nombre, familia, presupuesto, visa, idiomas)
            Pais p8 = new Pais("Perú", false, 2126, true, new List<String> {"Quechua", "Español","Aimara"});
            Pais p9 = new Pais("Venezuela", false, 3432, false, new List<String> {"Español" });
            Pais p10 = new Pais("Colombia", false, 3456, true, new List<String> {"Español" });
            Pais p11 = new Pais("Chile", false, 3432, false, new List<String> {"Español" });
            Pais p12 = new Pais("Bolivia", false, 2126, true, new List<String> {"Quechua", "Español", "Aimara"});
            Pais p13 = new Pais("Ecuador", false, 1500, false, new List<String> {"Español" });
            Pais p14 = new Pais("Brasil", false, 2100, false, new List<String> {"Português" });

            //Asia (nombre, familia, presupuesto, visa, idiomas)
            Pais p15 = new Pais("Rusia", false, 3100, true, new List<String> { "русская" });

            ListaPaises.Add(p1);
            ListaPaises.Add(p2);
            ListaPaises.Add(p3);
            ListaPaises.Add(p4);
            ListaPaises.Add(p5);
            ListaPaises.Add(p6);
            ListaPaises.Add(p7);
            ListaPaises.Add(p8);
            ListaPaises.Add(p9);
            ListaPaises.Add(p10);
            ListaPaises.Add(p11);
            ListaPaises.Add(p12);
            ListaPaises.Add(p13);
            ListaPaises.Add(p14);
            ListaPaises.Add(p15);
        }

        private void rbVisaSi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
