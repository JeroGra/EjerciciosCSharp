using System;

namespace Ej_Tempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

        //construct

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        //Mostrar y sobrecarga string
        private string Mostrar()
        {
            return (string)this;
        }

        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static explicit operator string(Tempera tempera)
        {
            return $"Color {tempera.color} Marca {tempera.marca} Cantidad {(int)tempera}";
        }

        //sobrecarga operadores (+; ==; !=; -)

        public static bool operator ==(Tempera temperaX, Tempera temperaY)
        {
            bool equals = false;
            if(!(temperaX is null || temperaY is null))
            { 
               equals = ((temperaX.color == temperaY.color) && (temperaX.marca == temperaY.marca)); 
            }
            return equals;
        }

        public static bool operator !=(Tempera temperaX, Tempera temperaY)
        {
            bool nonEquals = false;
                          
            nonEquals =!(temperaX == temperaY);            
            
            return nonEquals;
        }

        public static implicit operator int(Tempera tempera)
        {
            return tempera.cantidad;
        }

        public static Tempera operator +(Tempera temperaX, Tempera temperaY)
        {
            if(temperaX == temperaY)
            {
                temperaX += temperaY.cantidad;
            }
            return temperaX;
        }

        public static Tempera operator+(Tempera tempera, int x)
        {
            tempera.cantidad += x;
            return tempera;
        }

        /*public static Tempera operator -(Tempera tempera, int x)
        {
            tempera.cantidad -= x;
            return tempera;
        }*/

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

    }
}
