using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Lavadero
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara):base(patente,cantRuedas,marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()} - Tara {this.tara}");

            return sb.ToString();
        }
    }
}
