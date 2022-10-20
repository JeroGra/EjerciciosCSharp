using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class Avion:Vehiculo, IAFIP
    {
        protected double velocidadMaxima;

        protected Avion(double velocidadMax, double precio):base(precio)
        {
            this.velocidadMaxima = velocidadMax;
        }

        public virtual void MostrarVelocidadMaxima()
        {
            Console.WriteLine($"Velocidad Maxima: {this.velocidadMaxima}");
        }

        public double CalcularImpuesto()
        {
            return this.precio * 0.33;
        }
    }
}
