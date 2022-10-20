using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ej_clase12
{
    public class Deposito<T>
    {
        private int capacidadMaxima;
        private List<T> lista;

        private Deposito()
        {
            this.lista = new List<T>();
        }

        public Deposito(int capacidadMaxima) : this()
        {
            this.capacidadMaxima = capacidadMaxima;
        }

        ///Metodos
        
        private int GetIndice(T obj)
        {
            int index = -1;
            int cont = 0;
            foreach (T item in this.lista)
            {     
                if(item.Equals(obj))
                {
                    index = cont;
                    break;
                }
                cont++;
            }

            return index;
        }


        public static bool operator +(Deposito<T> d, T obj)
        {
            bool seAgrego = false;

            if ((d.GetIndice(obj)) == -1)
            {
                if(d.lista.Count < d.capacidadMaxima)
                {
                    d.lista.Add(obj);
                    seAgrego = true;
                }
            }

            return seAgrego;
        }

        public static bool operator -(Deposito<T> d, T obj)
        {
            bool seElimino = false;

            if ((d.GetIndice(obj)) > -1)
            {
                foreach (T item in d.lista)
                {
                    if(item.Equals(obj))
                    {
                        d.lista.Remove(item);
                        seElimino = true;
                        break;
                    }
                }
            }

            return seElimino;
        }

        public bool Agregar(T obj)
        {
            return this + obj;
        }

        public bool Remover(T obj)
        {
            return this - obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Deposito - capacidad maxima {this.capacidadMaxima}");
            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

    }
}
