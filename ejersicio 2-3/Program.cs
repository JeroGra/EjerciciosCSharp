using System;

namespace ejersicio_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int bin;
            Console.WriteLine("Ingrese un numero decimal: ");
            num = int.Parse(Console.ReadLine());

            bin = Conversor.ConvertirDecimalABinario(num);
            Console.WriteLine("{0} en binario es:  {1}\n",num,bin);

            num = Conversor.ConverirBinarioADecimal(bin);
            Console.WriteLine("{0} en Decimal es:  {1}\n", bin, num);
        }
    }
}
