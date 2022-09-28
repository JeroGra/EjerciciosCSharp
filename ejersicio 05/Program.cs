using System;

namespace ejersicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contI;
            int contJ;
            Console.WriteLine("Coloque un numero: ");
            num = int.Parse(Console.ReadLine());

           for(int i = 1;i<num;i++)
            {
                contI = 0;
                contJ = 0;
                for(int j = 1;j<i;j++)
                {
                    contI = contI + j;
                }

                for (int z = i + 1; z <= num; z++)
                {
                    contJ = contJ + z;
                }

                if(contI == contJ)
                {
                    Console.WriteLine("Centro Numerico: {0}",i);
                }
            }
        }
    }
}
