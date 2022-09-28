using System;
using System.Text;

namespace Ej_Registrarce_Ingresante
{
    public class Ingresante
    {
        private string[] cursos = new string[100];
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine("Curosos:");
            for(int i = 0;i<3;i++)
            {
                if(this.cursos[i] != null)
                {
                    sb.AppendLine($"{this.cursos[i]}");
                }
            }
            return sb.ToString();
        }
    }
}
