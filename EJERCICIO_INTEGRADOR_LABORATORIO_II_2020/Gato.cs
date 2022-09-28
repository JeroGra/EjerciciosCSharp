using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO_INTEGRADOR_LABORATORIO_II_2020
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza):base(nombre,raza)
        {

        }

        protected override string Ficha()
        {
            return $"gato {base.DatosCompletos()}";
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool equals = false;
            if(!(g1 is null || g2 is null))
            {
                equals = (g1 == (Mascota)g2);
            }
            return equals;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if(obj is Gato)
            {
                equals = this == ((Gato)obj);
            }
            return equals;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
