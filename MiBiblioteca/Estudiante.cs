using System;
using System.Text;

namespace MiBiblioteca
{
    public class Estudiante
    {
        private static Random random;
        private string legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;


        
        public Estudiante(string nLegajo, string eNombre, string eApellido)
        {
            this.legajo = nLegajo;
            this.nombre = eNombre;
            this.apellido = eApellido;
            this.notaPrimerParcial = 0;
            this.notaSegundoParcial = 0;
        }

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public void SettNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SettNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio;
            const float parciales = 2;

            promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / parciales;

            return promedio;
        }

        public  double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {

                notaFinal = Estudiante.random.Next(6, 11);
            }

            return notaFinal; 
        }

        public string Mostrar()
        {
            float promedio;
            double final;
            string mostrar;
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("-----------------------------------------------------------------------");
            mensaje.AppendLine($"ESRUDIANTE {this.nombre}  {this.apellido} ");
            mensaje.AppendLine($"Nro Legajo: N° {this.legajo}");
            mensaje.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}");
            mensaje.AppendLine($"Nota Segundo Parcial: {this.notaSegundoParcial}");

            promedio = CalcularPromedio();
            mensaje.AppendLine($"Promedio: {promedio}");

            if((final = CalcularNotaFinal()) != -1)
            {
                mensaje.AppendLine($"Nota Final: {final}");
            }
            else
            {
                mensaje.AppendLine("Alumno Desaprobado");
            }
            mensaje.AppendLine("-----------------------------------------------------------------------");

            mostrar = mensaje.ToString();

            return mostrar;
        }
    }
}
