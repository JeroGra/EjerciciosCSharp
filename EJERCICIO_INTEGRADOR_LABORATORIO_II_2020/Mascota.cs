using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO_INTEGRADOR_LABORATORIO_II_2020
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public Mascota(string n, string r)
        {
            this.nombre = n;
            this.raza = r;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        protected virtual string DatosCompletos()
        {
            return $"{this.Nombre}-{this.Raza}";
        }

        protected abstract string Ficha();
    
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool equals = false;
            if(!(m1 is null || m2 is null))
            {
                equals = ((m1.nombre == m2.nombre) && (m1.raza == m2.raza)); 
            }

            return equals;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
    }
}
