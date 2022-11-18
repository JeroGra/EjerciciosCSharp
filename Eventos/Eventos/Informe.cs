using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public static class Informe
    {
        #region Manejadores de eventos 1
        public static void NumeroNegativo(int num)
        {
            Console.WriteLine("EVENTO: el " + num + " es un numero negativo");
        }

        public static void OtroNumeroNegativo(int num)
        {
            Console.WriteLine("EVENTO: el " + num + " es OOOTRO numero negativo");
        }

        public static void MenorDeEdad(int num)
        {
            Console.WriteLine("EVENTO: " + num + " es menor de edad");
        }
        #endregion

        #region Manejadores de eventos 2

        public static void NumeroIncorrecto(Persona p, PersonaEventArgs e)
        {
            Console.WriteLine("EVENTO: " + e.NumeroIngresado + " es un numero incorrecto");
        }
        #endregion

    }
}
