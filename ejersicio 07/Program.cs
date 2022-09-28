using System;

namespace ejersicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorXhora;
            string nombre;
            int antiguedad;
            int horasTranajadas;

            int horasXvalor;
            int salarioBruto;
            double salarioNeto;
            int aumentoAños;
            double porcentaje;

            string respuesta;
            do
            {

                Console.WriteLine("Coloque el nombre del/la empleado/a: ");
                nombre = Console.ReadLine(); 

                Console.WriteLine("Coloque el valor por hora: ");
                valorXhora = int.Parse(Console.ReadLine());

                Console.WriteLine("Coloque la antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Coloque las horas trabajadas: ");
                horasTranajadas = int.Parse(Console.ReadLine());

                horasXvalor = valorXhora * horasTranajadas;
                aumentoAños = antiguedad * 150;

                salarioBruto = horasXvalor + aumentoAños;

                porcentaje = salarioBruto * 0.13;

                salarioNeto = salarioBruto - porcentaje;

                Console.Clear();

                Console.WriteLine("|Nombre\t |Atiguedad\t |ValorHora\t |A Cobrar Bruto\t |A Cobrar Neto\n");
                Console.WriteLine("|{0}\t   |{1}\t         |{2}\t           |{3}\t       |{4}\n",nombre,antiguedad,valorXhora,salarioBruto,salarioNeto);

                Console.WriteLine("Desea generar otro recibo de sueldo? coloque 'si' o 'no'\n");
                respuesta = Console.ReadLine();         
            } while (respuesta != "no");
        }
    }
}
