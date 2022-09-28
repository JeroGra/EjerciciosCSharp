using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Tempera
{
    public class Paleta
    {
        private List<Tempera> temperas;
        private int CantidadMaximaColores;
        

        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        private Paleta(int n):this()
        {
            this.CantidadMaximaColores = n;
        }

        public static implicit operator Paleta(int n)
        {
            return new Paleta(n);
        }

        private string Mostrar()
        {
           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de colores {this.CantidadMaximaColores}");
            foreach (Tempera item in this.temperas)
            {
                sb.AppendLine(Tempera.Mostrar(item));       
            }

            return sb.ToString();
        }

        private int ObtenerIndice(Tempera tempera)
        {
            int index = -1;
            for(int i = 0;i<this.temperas.Count;i++)
            {
               if(tempera == this.temperas[i])
                {
                    index = i;
                    break;
                }               
            }
            return index;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            return paleta.ObtenerIndice(tempera) > -1;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int i = paleta.ObtenerIndice(tempera);
            if(i > -1)
            {
                 paleta.temperas[i] += tempera;                     
            }
            else
            {
               if(paleta.temperas.Count < paleta.CantidadMaximaColores)
                {
                    paleta.temperas.Add(tempera);
                }
            }
            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {

            int i = paleta.ObtenerIndice(tempera);
            if (i > -1)
            {

                paleta.temperas[i] += (-tempera);

                if (paleta.temperas[i] < 1)
                {
                    paleta.temperas.RemoveAt(i);  //lograr eliminar
                }
                                      
            }
            return paleta;
        }

        public static Paleta operator +(Paleta paletaX, Paleta paletaY)
        {
            Paleta nuevaPaleta = new Paleta(paletaX.CantidadMaximaColores+paletaY.CantidadMaximaColores);
            for (int i = 0; i < paletaX.temperas.Count;i++)
            {
                nuevaPaleta.temperas.Add(paletaX.temperas[i]);

            }

            for(int i = 0; i < paletaY.temperas.Count; i++)
            {
                if(nuevaPaleta.temperas.Contains(paletaY.temperas[i]))
                {
                    nuevaPaleta += paletaY.temperas[i];
                }
                else
                {
                    nuevaPaleta.temperas.Add(paletaY.temperas[i]);                  
                }
            }

            return nuevaPaleta;
        }

        public Tempera this[int index]
        {
            get
            {
                if(index < 0 || index > this.temperas.Count )
                {
                    return null;
                }
                return this.temperas[index]; ;
            }
            set
            {
                this.temperas[index] = value;
            }
        }

        public int  CantidadTemperas
        {
            get
            {
                return this.temperas.Count;
            }
        }
    }
}
