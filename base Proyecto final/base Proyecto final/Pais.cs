using System;
using System.Collections.Generic;
using System.Text;

namespace base_Proyecto_final
{
    internal class Pais
    {

        List<Pais> ListaPaises = new List<Pais>();
        public Pais()
        {
            visa = false;
            bolsa_viaje = 0;
            nombre = string.Empty;
        }
        public Pais(string name, bool tenerfamilia, decimal bolsaviaje, bool visa2 , List<string> idioms)
        {
            nombre = name;
            Tenerfamilia = tenerfamilia;
            bolsa_viaje = bolsaviaje;
            visa = visa2;
            idiomas = idioms;
            lenguas = string.Join(",",idiomas);
        }
        public string nombre { get; set; }
        public bool visa { get; set; }
        public decimal bolsa_viaje { get; set; }
        public bool Tenerfamilia  { get; set; }
        public List<String> idiomas { get; set; }

        //string auxiliar para que muestre los idiomas en el dgv
        public string lenguas { get; set; }

    }
}
