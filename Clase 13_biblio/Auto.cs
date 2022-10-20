using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public class Auto:Vehiculo
    {
        protected string patente;

        protected Auto(string patente, double precio):base(precio)
        {
            this.patente = patente;
        }
        public virtual void MostrarPatente()
        {
            Console.WriteLine($"Patente: {this.patente}");
        }
    }
}
