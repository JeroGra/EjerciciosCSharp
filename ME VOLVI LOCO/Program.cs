using System;

namespace ME_VOLVI_LOCO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chatOn = true;
            string pregunta;
            string mensaje;
            Console.WriteLine("BIENVENIDO AL CHAT");

            do
            {
                mensaje = Console.ReadLine();

                ChatBot.ConvertirString(mensaje);
                Console.WriteLine(ChatBot.Respuesta());



               
                Console.WriteLine("PARA SALIR PULSE 'N'");
                pregunta = Console.ReadLine();
                pregunta.ToLower();
                if (pregunta == "n")
                {
                    chatOn = false;
                }

            } while (chatOn == true);

        }
    }
}
