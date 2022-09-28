using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_4
{
    class Calculadora
    {
        public static bool error = false;
        public static int Calcular(int primerOperando, int segundoOperando, string operacion)
        {
            int resultado = 0;
            bool esDistintoDeCero;

            switch(operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                break;
                case "-":
                    resultado = primerOperando - segundoOperando;

                break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                break;
                case "/":
                    esDistintoDeCero = Calculadora.Validar(segundoOperando);
                    if(esDistintoDeCero == true)
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("Math Error");
                        Calculadora.error = true;
                    }
                break;
            }
            return resultado;
        }

        private static bool Validar(int segundoOperando)
        {
            bool distintoACero = false;
            if(segundoOperando != 0)
            {
                distintoACero = true;
            }
            return distintoACero;
        }
    }
}
