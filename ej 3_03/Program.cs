using System;
using MiBiblioteca;
namespace ej_3_03
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Estudiante estudianteUno = new Estudiante("65456","Jeronimo","Granadillo");
            Estudiante estudianteDos = new Estudiante("77743", "Ana", "Saria");
            Estudiante estudianteTres = new Estudiante("34435", "Pepe", "Paso");


            estudianteUno.SettNotaPrimerParcial(10);
            estudianteUno.SettNotaSegundoParcial(10);

            estudianteDos.SettNotaPrimerParcial(10);
            estudianteDos.SettNotaSegundoParcial(5);

            estudianteTres.SettNotaPrimerParcial(4);
            estudianteTres.SettNotaSegundoParcial(2);

           
            Console.WriteLine(estudianteUno.Mostrar());

            Console.WriteLine("toque una tecla para ver los datos del/la siguiente estudiante");
            Console.ReadKey();

            Console.WriteLine(estudianteDos.Mostrar());

            Console.WriteLine("toque una tecla para ver los datos del/la siguiente estudiante");
            Console.ReadKey();

            Console.WriteLine(estudianteTres.Mostrar());
        }
    }
}
