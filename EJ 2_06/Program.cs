using System;

namespace EJ_2_06
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            double longCuadrado;
            double baseT;
            double alturaT;
            double radio;

            double area;

            Console.WriteLine("DATOS PARA OBTENER AREA DE SU CUADRADO");
            Console.WriteLine("Coloque la longitud (cm) de un lado de su cuadrado: ");
            longCuadrado = double.Parse(Console.ReadLine());

            area = CalculadoraDeArea.CalcularAreaCuadrado(longCuadrado);
            CalculadoraDeArea.mesnaje.AppendLine("El area de su cuadrado es de: "+ area+"cm2");

            Console.WriteLine("DATOS PARA OBTENER AREA DE SU TRIANGULO");
            Console.WriteLine("Coloque los cm de la base de su triangulo: ");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque la altura (cm) de su triangulo: ");
            alturaT = double.Parse(Console.ReadLine());

            area = CalculadoraDeArea.CalcularAreaTriangulo(baseT, alturaT);

            CalculadoraDeArea.mesnaje.AppendLine("El area de su triangulo es de: "+ area + "cm2");

            Console.WriteLine("DATOS PARA OBTENER AREA DE SU CIRCULO");
            Console.WriteLine("Coloque el radio (cm) de su circulo: ");
            radio = double.Parse(Console.ReadLine());

            area = CalculadoraDeArea.CalcularAreaCirculo(radio);
            
            CalculadoraDeArea.mesnaje.AppendLine("El area de su circulo es de: "+ area + "cm2");

            Console.WriteLine(CalculadoraDeArea.mesnaje);

           
        }
    }
}
