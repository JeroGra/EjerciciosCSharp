using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class APrivado:Avion
    {
        private int valoracionServiciosDeAbordo;
        public APrivado(int valoracion,double velocidadMax,double precio):base(velocidadMax,precio)
        {
            this.valoracionServiciosDeAbordo = valoracion;
        }
    }
}
