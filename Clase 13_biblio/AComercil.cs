using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class AComercil:Avion
    {
        private int cantidadPasajeros;
        public AComercil(int cantidadPasajeros,double velocidadMax,double precio):base(velocidadMax,precio)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
