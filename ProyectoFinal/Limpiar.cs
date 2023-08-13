using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal
{
    public  class Limpiar
    {
        public static void limpiarBoton( ComboBox combo1, ComboBox combo2, ComboBox combo3, ComboBox combo4,  TextBox caja1,TextBox caja2, RadioButton radio1, RadioButton radio2 )
        {
            combo1.Text = "";
            combo2.Text = "";
            combo3.Text = "";
            combo4.Text = "";
            radio1.Checked = false;
            radio2.Checked = false;
            caja1.Clear();
            caja2.Clear();
        }
    }
}
