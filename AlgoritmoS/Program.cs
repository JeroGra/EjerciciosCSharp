using System;
using System.Text;

namespace AlgoritmoS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool suicidarce;
            const string matarce = "*PROCEDE A";
    string respuesta;
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Quieres matarte? s/n");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Quieres matarte? s/n");
                respuesta = Console.ReadLine();
            }

            if (respuesta == "s")
            {
                Console.WriteLine("De que forma?\na)Cortarse las venas.\nb)Ahorcarse.\nc)Pegarse un tiro.");
                respuesta = Console.ReadLine();
                while (respuesta != "a" && respuesta != "b" && respuesta != "c")
                {
                    Console.WriteLine("Quieres matarte? s/n");
                    respuesta = Console.ReadLine();
                }

                sb.Append(matarce);
                switch (respuesta)
                {
                    case "a":
                        sb.Append(" Cortarse las venas");
                        break;
                    case "b":
                        sb.Append(" Ahorcarse");
                        break;
                    case "c":
                        sb.Append(" Pegarse un tiro");
                        break;
                }

                Console.Clear();
                Console.WriteLine(sb.ToString());

            }
            else
            {
                Console.WriteLine("Chupala Puto/a");
            }

        }
    }
}
