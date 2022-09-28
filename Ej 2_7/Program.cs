using System;

namespace Ej_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseT;
            double alturaT;
            double hipotenusa;
            Console.WriteLine("Coloque la base de su triangulo en cm: ");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque la altura de su triangulo en cm: ");
            alturaT = double.Parse(Console.ReadLine());

            hipotenusa = Math.Pow(baseT, 2) + Math.Pow(alturaT, 2);
            hipotenusa = Math.Sqrt(hipotenusa);

            Console.WriteLine("La longitud de la hipotenusa de su triangulo es de: {0}", hipotenusa);

        }
    }
}
