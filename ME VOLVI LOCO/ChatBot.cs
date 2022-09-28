using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME_VOLVI_LOCO
{
    class ChatBot
    {
        public static string mensaje;
        public static void ConvertirString(string mensaje)
        {
            mensaje.ToLower();
            ChatBot.mensaje = mensaje;
        }

        public static string Respuesta()
        {

            string respuesta = "...";
            if(ChatBot.mensaje == "hola")
            {
                respuesta = "Hola Humano soy MoxBot";
            }

            return respuesta;
        }
    }
}
