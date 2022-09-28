using System;
using System.Text;

namespace Boligrafo
{
    public class Boligrafo
    {
        public const short cantidadMaximaTinta = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;

        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder sb = new StringBuilder();
            int tinta = (int)this.tinta;
            int tintaAGastar = (int)gasto;
            tinta = tinta - tintaAGastar;
            bool hayTinta = false;


            if(this.tinta > 0)
            {
                hayTinta = true;
                for (int i = 0; i <= tintaAGastar; i++)
                {
                    sb.Append("*");
                }
            }
            else
            {
                SetTinta(this.tinta);
            }
            dibujo = sb.ToString();

            return hayTinta;
        }

        public void Recargar()
        {
            this.tinta = Boligrafo.cantidadMaximaTinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta <= Boligrafo.cantidadMaximaTinta)
            {
                Recargar();
            }
        }
    }
}
