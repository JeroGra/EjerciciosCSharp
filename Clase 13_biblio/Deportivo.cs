using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class Deportivo:Auto,IAFIP
    {
        private int caballosFuerza;
        public Deportivo(int caballosFuerza, string patente, double precio) : base(patente, precio)
        {
            this.caballosFuerza = caballosFuerza;
        }

        public double CalcularImpuesto()
        {
            return this.precio * 0.28;
        }
    }
}
