using System;
using Cosa;

namespace Main_sobrecarga_ej
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa.Cosa cosa = new Cosa.Cosa();
            Cosa.Cosa cosaDos = new Cosa.Cosa("pepe");
            Cosa.Cosa cosaTres = new Cosa.Cosa(2, "pepe");

            DateTime tiempo = new DateTime(2000,07,21);

            Cosa.Cosa cosaCuatro = new Cosa.Cosa(tiempo, 44, "hola");


            cosa.EstablecerValor(2);
            cosa.EstablecerValor("cosa");
            cosa.EstablecerValor(DateTime.Now);

            Console.WriteLine(Cosa.Cosa.Mostrar(cosa));

            Console.WriteLine("Presionar una tecla");
            Console.ReadKey();

            Console.WriteLine(Cosa.Cosa.Mostrar(cosaDos));

            Console.WriteLine("Presionar una tecla");
            Console.ReadKey();

            Console.WriteLine(Cosa.Cosa.Mostrar(cosaTres));

            Console.WriteLine("Presionar una tecla");
            Console.ReadKey();

            Console.WriteLine(Cosa.Cosa.Mostrar(cosaCuatro));
        }
    }
}
