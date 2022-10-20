using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ej_clase12
{
    public class Auto
    {
        private string color;
        private string marca;

        public Auto(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
        }

        ///getters/setters

        public string Color
        {
            get
            {
                return this.color;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        ///Metodos

        public static bool operator ==(Auto a1, Auto a2)
        {
            bool equals = false;
            try
            {
                equals = (a1.marca == a2.marca) && (a1.color == a2.color);
            }
            catch(NullReferenceException)
            {
                return equals;
            }
            return equals;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return a1 == a2;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if(obj is Auto)
            {
                equals = this == ((Auto)obj);
            }

            return equals;
        }

        public override string ToString()
        {
            return $"Marca {this.Marca} - color {this.Color}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
