using System;

namespace ejersicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esPrimo;
            string respuesta;
            do {

                Console.WriteLine("Coloque un numero: ");
                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out num) == false && respuesta != "salir")
                {
                    Console.WriteLine("Coloque un numero o coloque 'salir': ");
                    respuesta = Console.ReadLine();
                }

                if(respuesta != "salir")
                { 
                    for (int i = 1; i < num; i++)
                    {
                        esPrimo = true;
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0 && j != 1)
                            {
                                esPrimo = false;
                            }
                        }
                        if (esPrimo != false)
                        {
                            Console.WriteLine("Numero primo: {0}", i);
                        }
                    }
                    Console.WriteLine("Quiere salir?, coloque si o no: ");
                    respuesta = Console.ReadLine();
                    if (respuesta  == "si")
                    {
                        respuesta = "salir";
                    }
                }
            } while(respuesta != "salir");
        }
    }
}
