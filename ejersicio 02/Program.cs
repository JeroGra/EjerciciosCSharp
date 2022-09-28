using System;

namespace ejersicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double numCubo;
            double numCuadrado;

            Console.WriteLine("Coloque un numero: ");
            num = int.Parse(Console.ReadLine());
            while(num <= 0)
            {
                Console.WriteLine("ERROR! Coloque un numero mayor a 0: ");
                num = int.Parse(Console.ReadLine());
            }

            numCubo = Math.Pow(num,3);
            numCuadrado = Math.Pow(num, 2);

            Console.Clear();
            Console.WriteLine("Numero al cuadrado = {0} \t Numero al cubo = {1}",numCuadrado,numCubo);

        }
    }
}
