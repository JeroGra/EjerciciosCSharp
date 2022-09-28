using System;

namespace ejersicio_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteracion = 10;
            int valorIngresado;
            bool retorno;

            int nMinIngresado = 0;
            bool minFlag = true;

            int nMaxIngresado = 0;
            bool maxFlag = true;

            double cont = 0;
            double promedio;

            Console.WriteLine("INGRESE 10 NUMEROS\n");

            for(int i = 0; i< iteracion; i++)
            { 
                Console.WriteLine("_  \n");
                valorIngresado =  int.Parse(Console.ReadLine());
                retorno = Validacion.Validar(valorIngresado, -100, 100);

                while(retorno == false)
                {
                    Console.WriteLine("ERROR! ingrese un numero entre -100 y 100 _  \n");
                    valorIngresado = int.Parse(Console.ReadLine());
                    retorno = Validacion.Validar(valorIngresado, -100, 100);
                }

                if(valorIngresado > nMaxIngresado || maxFlag == true)
                {
                    nMaxIngresado = valorIngresado;
                    maxFlag = false;
                }
                else
                {
                    if(valorIngresado < nMinIngresado || minFlag == true)
                    {
                        nMinIngresado = valorIngresado;
                        minFlag = false;
                    }
                }

                cont = cont + valorIngresado;
            }

            promedio = cont / iteracion;

            Console.Clear();
            Console.WriteLine("Maximo Valor\t   Minimo Valor\t   Promedio\n");
            Console.WriteLine("{0}\t            {1}\t            {2}\n",nMaxIngresado,nMinIngresado,promedio);
        }
    }
}
