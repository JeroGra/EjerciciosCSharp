using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AtencionAlCliente_Ej
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }

        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        
        public Cliente(int numero)
        {
            this.nombre = "";
            this.numero = numero;
        }

        public Cliente(int numero, string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool equals = false;
            if (!(c1 is null || c2 is null))
            {
                if(c1.numero == c2.numero)
                {
                    equals = true;
                }
            }

            return equals;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
