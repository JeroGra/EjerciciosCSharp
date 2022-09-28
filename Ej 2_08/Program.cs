using System;

namespace Ej_2_08
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaIngresada = new DateTime();
            Console.WriteLine("Coloque la fecha de inicio de esta manera(ej: 2000 07 30) : ");
            fechaIngresada = DateTime.Parse(Console.ReadLine());
            CalcularAños.CalcularDias(fechaIngresada);
        }
    }
}
