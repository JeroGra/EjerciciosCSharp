using System;

namespace ejersicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numMayor = 0;
            int numMenor = 0;
            bool banderaMin = true;
            bool banderaMax = true;

            float promedio;
            float cont = 0;

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("coloque un numero: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > numMayor || banderaMax == true)
                {
                    numMayor = numero;
                    banderaMax = false;
                }
                else
                {
                    if(numero < numMenor || banderaMin == true)
                    {
                        numMenor = numero;
                        banderaMin = false;
                    }
                }

                cont = cont + numero;
            }
            promedio = cont / 5;

            Console.Clear();
            Console.WriteLine("\nNumero mayor= {0}\t Numero menor= {1}\t Promedio= {2}",numMayor,numMenor,promedio);
        }
    }
}
