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
    public partial class FrmRegistroES : Form
    {
        List<Pais> ListaPaises = new List<Pais>();
        //lista de paises extraida de LINQ
        List<Pais> ListaPaisesFiltrados = new List<Pais>();
        
        public FrmRegistroES()
        {
            InitializeComponent();
            //METODO DE CARGA DE PAISES A PENAS SE EJECUTE EL PROGRAMA (DENTRO DE LISTA PAISES)
            ObtenerTodosPaises();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            try
            {
                ////RESTRICCION DE LLENADO DE DATOS
                //if ((cboContinente.SelectedValue == null) || (txtEdad.Text == null) || (cboEstudios.SelectedValue == null) || (cboGenero.SelectedValue == null) || (cboGenero.SelectedValue == null) || (cboPais.SelectedValue == null))
                //{
                //    MessageBox.Show("Llene todos los datos por favor");
                //    return;
                //}


                //RESTRICCION DE LLENADO DEl DATO EDAD
                if (!(int.Parse(txtEdad.Text) >= 18) || !(int.Parse(txtEdad.Text) <= 120))
                {
                    MessageBox.Show("Ingrese una edad válida, por favor volver a intentar");
                    return;
                }

                //preparacion de datos a filtrar
                bool _reqvisa = false;
                bool IgnorarVisa = false;
                bool _reqTenerfam = false;
                bool IgnorarFamilia = false;

                if (rbnVisaSI.Checked)
                    _reqvisa = true;
                else if (rbnVisaNO.Checked)
                    _reqvisa = false;
                else
                    IgnorarVisa = true;

                if (rbnFamiliaSI.Checked)
                    _reqTenerfam = true;
                else if (rbnFamiliaNO.Checked)
                    _reqTenerfam = false;
                else
                    IgnorarFamilia = true;

                //Creacion de una sub lista para los paises 
                List<string> listaseelccion = new List<string>();

                if (ckbEspañol.Checked) listaseelccion.Add("Español");
                if (ckbAleman.Checked) listaseelccion.Add("Alemán");
                if (ckbFinlandes.Checked) listaseelccion.Add("Finlandés");
                if (ckbIngles.Checked) listaseelccion.Add("Inglés");
                if (ckbRuso.Checked) listaseelccion.Add("Ruso");
                if (ckbPortugues.Checked) listaseelccion.Add("Portugués");
                if (ckbNoruego.Checked) listaseelccion.Add("Noruego");
                if (ckbFrances.Checked) listaseelccion.Add("Francés");
                if (ckbItaliano.Checked) listaseelccion.Add("Italiano");
                if (ckbIndú.Checked) listaseelccion.Add("Indú");
                if (ckbJapones.Checked) listaseelccion.Add("Japonés");
                

                decimal bolsa = Convert.ToDecimal(NupDoBolsaViaje.Text);

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

                //se llena la grilla que se encuentra en otro from (frmPaisEncontrado)
                FrmPaisEncontrado objeto2 = new FrmPaisEncontrado(ListaPaisesFiltrados);
                objeto2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado, por favor vuelta intentarlo","Error");
            }
        }

        private void cboContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboContinente.SelectedIndex == 0)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Japon");
                cboPais.Items.Add("China");
                cboPais.Items.Add("Indonesia");
            }

            if (cboContinente.SelectedIndex == 1)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Nigeria");
                cboPais.Items.Add("Ghana");
                cboPais.Items.Add("Sudafrica");
            }

            if (cboContinente.SelectedIndex == 2)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Peru");
                cboPais.Items.Add("Argentina");
                cboPais.Items.Add("Chile");
            }

            if (cboContinente.SelectedIndex == 3)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Mexico");
                cboPais.Items.Add("Estados Unidos");
                cboPais.Items.Add("Canada");
            }

            if (cboContinente.SelectedIndex == 4)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Ucrania");
                cboPais.Items.Add("Alemania");
                cboPais.Items.Add("Francia");
            }

            if (cboContinente.SelectedIndex == 5)
            {
                cboPais.Items.Clear();
                cboPais.Items.Add("Nueva Zelanda");
                cboPais.Items.Add("Australia");
                cboPais.Items.Add("Nueva Guinea");
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void LimpiarDatos()
        {
            //dgvPaises.DataSource = null; 
            txtEdad.Clear();
            cboContinente.Text = null;
            cboEstudios.Text= null;
            cboGenero.Text= null;
            cboPais.Text= null;
            NupDoBolsaViaje.Value = 1500;
            rbnFamiliaSI.Checked = false;
            rbnFamiliaNO.Checked = false;
            rbnVisaNO.Checked = false;
            rbnVisaSI.Checked = false;
            ckbAleman.Checked = false;
            ckbEspañol.Checked = false;
            ckbFinlandes.Checked = false;
            ckbFrances.Checked = false;
            ckbIngles.Checked = false;
            ckbItaliano.Checked = false;
            ckbNoruego.Checked = false;
            ckbPortugues.Checked = false;
            ckbRuso.Checked = false;
        }
        private void ObtenerTodosPaises()
        {

            //Europa (nombre, familia, presupuesto, visa, idiomas)
            Pais p1 = new Pais("Alemania", false, 4030, true, new List<String> { "Alemán" });
            Pais p2 = new Pais("USA", true, 4210, true, new List<String> { "Inglés" });
            Pais p3 = new Pais("Francia", false, 4560, true, new List<String> { "Francés" });
            Pais p4 = new Pais("Canadá", true, 4000, false, new List<String> { "Francés", "Inglés" });
            Pais p5 = new Pais("Noruega", true, 5100, true, new List<String> { "Noruego", "Inglés" });
            Pais p6 = new Pais("Finlandia", false, 4920, false, new List<String> { "Finlandés" });
            Pais p7 = new Pais("Italia", true, 3200, true, new List<String> { "Italiano" });

            //Latam (nombre, familia, presupuesto, visa, idiomas)
            Pais p8 = new Pais("Perú", true, 2126, true, new List<String> { "Quechua","Español", "Aimara" });
            Pais p9 = new Pais("Venezuela", false, 3432, false, new List<String> { "Español" });
            Pais p10 = new Pais("Colombia", false, 3456, true, new List<String> { "Español" });
            Pais p11 = new Pais("Chile", true, 3432, false, new List<String> { "Español" });
            Pais p12 = new Pais("Bolivia", false, 2126, true, new List<String> { "Quechua", "Español", "Aimara" });
            Pais p13 = new Pais("Ecuador", false, 1500, false, new List<String> { "Español" });
            Pais p14 = new Pais("Brasil", true, 2100, false, new List<String> { "Portugués" });

            //Asia (nombre, familia, presupuesto, visa, idiomas)
            Pais p15 = new Pais("Rusia", false, 3100, true, new List<String> { "Ruso" });
            Pais p16 = new Pais("India", true, 4300, true, new List<String> { "Indú" });
            Pais p17 = new Pais("Japón", false, 5120, false, new List<String> { "Japonés"});

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
            ListaPaises.Add(p16);
            ListaPaises.Add(p17);
        }

        private void gbo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void gbo1_Click(object sender, EventArgs e)
        {
            rbnFamiliaSI.Checked = false;
            rbnFamiliaNO.Checked = false;
            rbnVisaNO.Checked = false;
            rbnVisaSI.Checked = false;
        }
    }
}
