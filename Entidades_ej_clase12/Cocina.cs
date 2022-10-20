using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ej_clase12
{
    public class Cocina
    {
        private int codigo;
        private bool esIndustrial;
        private double precio;

        public Cocina(int codigo,double precio, bool esIndustrial)
        {
            this.codigo = codigo;
            this.esIndustrial = esIndustrial;
            this.precio = precio;
        }

        ///Getters y Setters
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this.esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }


        public static bool operator ==(Cocina c1, Cocina c2)
        {
            bool equals = false;
            try
            {
                equals = c1.codigo == c2.codigo;
            }
            catch(NullReferenceException)
            {
                return equals;
            }

            return equals;
        }

        public static bool operator !=(Cocina c1, Cocina c2)
        {
            return c1 == c2;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if(obj is Cocina)
            {
                equals = this == ((Cocina)obj);
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string s;
            if(this.EsIndustrial)
            {
                s = $"codigo {this.codigo} - precio ${this.precio} - Es industrial";
            }
            else
            {
                s = $"codigo {this.codigo} - precio ${this.precio} - No es Industrial";
            }

            return s;
        }

    }
}
