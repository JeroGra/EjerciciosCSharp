using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class Familiar:Auto
    {
        private int cantidadAsientos;

        public Familiar(int asientos,string patente,double precio):base(patente,precio)
        {
            this.cantidadAsientos = asientos;
        }
    }
}
