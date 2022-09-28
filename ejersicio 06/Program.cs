using System;

namespace ejersicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFinal;

            Console.WriteLine("Coloque un año de inicio: ");
            anioInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Coloque un año final: ");
            anioFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Años bisiestos entre {0} y {1}\n",anioInicio,anioFinal);
            for (int i = anioInicio;i< anioFinal;i++)
            {
                if(1%4 == 0 || i%400 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}
