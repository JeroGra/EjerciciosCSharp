using System;
using Clase_13_biblio;
namespace Test_clase_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportivo porche = new Deportivo(900,"CSX000",1500);
            IAFIP miCarro = porche;

            Console.WriteLine("MI CARRO");
            porche.MostrarPrecio();
            porche.MostrarPatente();
            Console.WriteLine($"Impuesto: ${Gestion.MostrarImpuestonacional(miCarro)}");
        }
    }
}
