using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente_Ej
{
    class Negocio
    {
        private PuestoAtencion.Puesto caja;
        private Queue<Cliente> clientes;
        private string nombre;
        
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = PuestoAtencion.Puesto.Caja1;
            this.nombre = "";    
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente 
        {
            get
            {
                return clientes.Peek();
            }
            set
            {
                foreach (Cliente iteam in this.clientes)
                {
                    if(this.Cliente != iteam)
                    {
                        this.clientes.Enqueue(this.Cliente);
                    }
                }                             
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool equal = false;
            foreach (Cliente i in n.clientes)
            {
                if(c == n.Cliente)
                {
                    equal = true;
                    break;
                }
            }
            return equal; 
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(c == n.Cliente);
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            bool agregar = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                agregar = true;
            }
            return agregar;
        }
        public static bool operator~(Negocio n)
        {
            return PuestoAtencion.Atender(n.Cliente);
        }

    }
}
