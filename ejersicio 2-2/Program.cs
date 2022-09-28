using System;

namespace ejersicio_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;

            string respuesta;
            bool retorno;
            do
            {
                Console.Clear();

                Console.WriteLine("\nColoque un numero entero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nColoque otro numero entero: ");
                num2 = int.Parse(Console.ReadLine());

                suma = num1 + num2;

                Console.Clear();

                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, suma);

                Console.WriteLine("\nDesea seguir sumando? coloque 'S' para continuar, si no otra cosa: ");
                respuesta = Console.ReadLine();
                retorno = Validador.ValidarRespuesta(respuesta);

            } while(retorno != false);

            Console.WriteLine("\nHasta Luego\n");

        }
    }
}
