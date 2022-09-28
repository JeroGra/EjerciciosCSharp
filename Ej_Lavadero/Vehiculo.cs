using System;
using System.Text;

namespace Ej_Lavadero
{
    public class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca {this.marca}\tRuedas {this.cantRuedas}\tPatente {this.patente}");

            return sb.ToString();

        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool equals = false;
            if(!(v1 is null || v2 is null))
            {
                if((v1.patente == v2.patente)&&(v1.marca == v2.marca))
                {
                    equals = true;
                }
            }
            return equals;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if(obj is Vehiculo)
            {
                equals = this == ((Vehiculo)obj);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
        }
    }
}
