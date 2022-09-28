using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO_INTEGRADOR_LABORATORIO_II_2020
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        public EtipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string n) : this()
        {
            this.nombre = n;
        }
        public Grupo(string n, EtipoManada tipo) : this(n)
        {
            Grupo.tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            return g.manada.Contains(m);
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine($"Ya esta {m.ToString()} en el grupo.");
            }

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g==m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine($"No esta {m.ToString()} en el grupo.");
            }

            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo:{g.nombre} - tipo:{Grupo.tipo}");
            sb.AppendLine($"Integrantes:{g.manada.Count}");
            foreach (Mascota item in g.manada)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString();
        }

    }
}
