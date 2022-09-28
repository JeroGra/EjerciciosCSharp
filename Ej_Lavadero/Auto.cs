using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Lavadero
{
    public class Auto : Vehiculo
    {
        protected int cantAsientos;

        public Auto(string patente, Byte cantRuedas, EMarcas marca, int cantidadAsientos):base(patente,cantRuedas,marca)
        {
            this.cantAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()} - Asientos {this.cantAsientos}");

            return sb.ToString();
        }

    }
}
