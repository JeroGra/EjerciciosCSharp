using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Lavadero
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, Byte cantRuedas, EMarcas marca,float cilindrada):base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()} - Cilindrada {this.cilindrada}");

            return sb.ToString();
        }
    }
}
