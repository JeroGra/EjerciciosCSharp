using System;


namespace Ej_3_04
{
    using Boligrafo;
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lapiceraAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo lapiceraRoja = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            lapiceraAzul.Pintar(100,out dibujo);

            Console.ForegroundColor = lapiceraAzul.GetColor();
            Console.WriteLine(dibujo);

            lapiceraRoja.Pintar(100, out dibujo);

            Console.ForegroundColor = lapiceraRoja.GetColor();
            Console.WriteLine(dibujo);

            lapiceraAzul.Pintar(3, out dibujo);

            Console.ForegroundColor = lapiceraAzul.GetColor();
            Console.WriteLine(dibujo);

            lapiceraRoja.Pintar(5, out dibujo);

            Console.ForegroundColor = lapiceraRoja.GetColor();
            Console.WriteLine(dibujo);


        }
    }
}
