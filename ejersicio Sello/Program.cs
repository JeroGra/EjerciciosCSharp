using System;

namespace ejersicio_Sello
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola WORLD";

            Console.WriteLine(Sello.Imprimir());

            //Console.WriteLine("precione una tecla para continuar: ");
            Console.ReadKey();

            Sello.Borrar();

            Console.ReadKey();

            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "hola mundo c#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
        }
    }
}
