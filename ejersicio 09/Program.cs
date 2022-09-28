using System;

namespace ejersicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //string respuesta;
            int alturaIngresada;
            int asteriscos = 0;
            int n = 0;

           /* Console.WriteLine("Ingrese la altura del triángulo: ");

            respuesta = Console.ReadLine();

            while (int.TryParse(respuesta, out alturaIngresada) == false || int.Parse(respuesta) <= 0)
            {
                Console.WriteLine("ERROR, Ingrese una altura válida: ");

                respuesta = Console.ReadLine();
            }

            n = alturaIngresada;

            for (int i = 1; i <= alturaIngresada; i++)
            {
                asteriscos = (i * 2) - 1;
                n--;

                for (int e = 0; e < n; e++)
                {
                    Console.Write(" ");
                }

                for (int a = 0; a < asteriscos; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
           }*/

                Console.Clear();

                Console.WriteLine("coloque una altura deseada: ");
                alturaIngresada = int.Parse(Console.ReadLine());
                while (alturaIngresada <= 0)
                {
                    Console.WriteLine("coloque una altura mayor a 0: ");
                    alturaIngresada = int.Parse(Console.ReadLine());
                }

                n = alturaIngresada;

                for(int i = 1; i<= alturaIngresada;i++)
                {
                    asteriscos = (i * 2) - 1;
                    n--;
                    for(int j = 0; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int z = 0; z < asteriscos; z++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
               
                }            
        }
    }
}
