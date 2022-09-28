using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_2_06
{
    
    class CalculadoraDeArea
    {
        public static StringBuilder mesnaje = new StringBuilder();
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area;

            area = longitudLado * longitudLado;

            return area;
        }

        public static double CalcularAreaTriangulo(double baseT, double altura)
        {
            double area;

            area = (baseT * altura) / 2;

            return area;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            double area;

            area = (radio * radio) * 3.14;

            return area;
        }
    }
}
