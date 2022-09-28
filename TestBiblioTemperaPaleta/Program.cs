using System;

namespace TestBiblioTemperaPaleta
{
    using Ej_Tempera;
    class Program
    {
        static void Main(string[] args)
        {
            bool comp;

            Paleta paletaUno = 3;
            Paleta paletaDos = 2;


            Tempera temperaUno = new Tempera(ConsoleColor.Red,"Alba", 50);
            Tempera temperaDos = new Tempera(ConsoleColor.Blue,"Alba", 50);
            Tempera temperaTres = new Tempera(ConsoleColor.Red,"Alba", 25);
            Tempera temperaCuatro= new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera temperaCinco = new Tempera(ConsoleColor.Green, "Temperita", 50);

            comp = temperaUno == temperaDos;
            comp = temperaUno == temperaTres;
            comp = temperaUno == temperaCuatro;
            comp = temperaUno == null;
            comp = null == temperaUno;

            Console.WriteLine(temperaUno.Mostrar(temperaUno));

             temperaUno += temperaDos;
             temperaUno += temperaTres;
             temperaUno += temperaCuatro;
             temperaUno += null;

            Console.WriteLine(temperaUno.Mostrar(temperaUno));

            temperaUno += 20;
            temperaUno += 30;

            Console.WriteLine(temperaUno.Mostrar(temperaUno));

            comp = paletaUno == temperaUno;

            Console.WriteLine((string)paletaUno);

           paletaUno += temperaUno;
           paletaUno += temperaDos;
           paletaUno += temperaTres;
           paletaUno += temperaCuatro;
           paletaUno += temperaCinco;

            Console.WriteLine((string)paletaUno);

            Console.WriteLine($"{temperaUno.Mostrar(temperaUno)} en la operacion paleta + temp3 \nno solo se aumento la cantidad de la tempera de la paleta sino que \ntambien incremento la cantidad de la tempera 1 debido a la igualdad\n");

            paletaUno -= temperaUno;
             paletaUno -= temperaDos;
             paletaUno -= temperaCinco;

            Console.WriteLine((string)paletaUno);

             paletaDos += temperaCinco;
             paletaDos += temperaCuatro;
             paletaDos += temperaTres;
             paletaDos += temperaDos;

            Console.WriteLine((string)paletaDos);

            paletaUno += paletaDos;

            Console.WriteLine((string)paletaUno);

            



        }
    }
}
