using System;

namespace Ej_2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteroIngresado;
            Console.WriteLine("Coloque un entero para obtener su tabla de multiplicacion: ");
            enteroIngresado = int.Parse(Console.ReadLine());

            Tabla.TablaNum(enteroIngresado);

            Console.WriteLine(Tabla.respuesta);
        }
    }
}
