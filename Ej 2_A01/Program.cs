using System;

namespace Ej_2_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial;
            int num = 6;

            factorial = CalcularFactorial.Factorial(num);
            Console.WriteLine("EL factorial de {0} es {1}",num,factorial);
        }
    }
}
