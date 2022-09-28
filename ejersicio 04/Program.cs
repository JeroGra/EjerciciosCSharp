using System;

namespace ejersicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            Console.WriteLine("Primeros 4 Numeros Perfectos");
            for (int i = 1; i<10000;i++)
            {
                cont = 0;
                for (int j = 1; j < i;j++)
                {
                    if((i % j) == 0)
                    {
                        cont = cont + j;
                    }
                }

                if(cont == i)
                {
                    Console.WriteLine("\n{0}",i);
                }
            }
        }
    }
}
