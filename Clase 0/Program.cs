using System;

namespace Clase_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int edad;


            //Console.WriteLine("EDAD ES {0}",edad);  //printf

            /*for( int i = 0; i <= 10000000;i++)
             {
                 Console.WriteLine("{0}", i);  //printf
             }*/
            Console.WriteLine("ingrese su nombre: ");
            n = Console.ReadLine();
            Console.WriteLine("ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("El nombre es {0} y su edad {1}",n,edad);
        }
    }
}
