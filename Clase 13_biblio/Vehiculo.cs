using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
     public abstract class Vehiculo
    {
        protected double precio;

        protected Vehiculo(double precio)
        {
            this.precio = precio;
        }

        public virtual void MostrarPrecio()
        {
            Console.WriteLine($"Precio Bruto: ${this.precio}");
        }
    }
}
