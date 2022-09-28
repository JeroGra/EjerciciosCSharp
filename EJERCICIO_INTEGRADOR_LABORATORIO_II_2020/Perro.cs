using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO_INTEGRADOR_LABORATORIO_II_2020
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza):this(nombre,raza,0,false)
        {

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa):base(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"perro-{base.DatosCompletos()},");
            if(this.esAlfa)
            {
                sb.Append(" alfa de la manada,");
            }

            sb.Append($" edad {this.edad}\n");
       
            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool equals = false;
            if(!(p1 is null || p2 is null))
            {
                equals = ((Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad);
            }

            return equals;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if(obj is Perro)
            {
                equals = this == (Perro)obj;
            }
            return equals;
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

    }
}
