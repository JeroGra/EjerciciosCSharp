using System;

namespace ejercicio_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            int primeroOperando;
            int segundoOperando;
            string operacion;
            do
            {
                Console.Clear();
 
                Console.WriteLine("Coloque el primero operando: ");
                primeroOperando = int.Parse(Console.ReadLine());
                Console.WriteLine("Coloque el segundo operando: ");
                segundoOperando = int.Parse(Console.ReadLine());
                Console.WriteLine("Coloque la operacion deseada a realizar con '+', '-', '*', '/': ");
                operacion = Console.ReadLine();

                resultado = Calculadora.Calcular(primeroOperando, segundoOperando, operacion);
                if(Calculadora.error != true)
                {
                    Console.WriteLine("\nEl resultado es: {0}\n",resultado);
                }
                Calculadora.error = false;
                Console.WriteLine("Desea seguir operando coloque S para afirmar: ");
                operacion = Console.ReadLine();
                
            } while(operacion == "S" );
        }
    }
}
