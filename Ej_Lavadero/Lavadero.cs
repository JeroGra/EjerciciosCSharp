using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Lavadero
{
    class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero ()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

       public string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Precio Auto {this.precioAuto} \t Precio Camion {this.precioCamion} \t Precio Moto {this.precioMoto}");
                sb.AppendLine("Vehiculos:");
                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Auto auto)
                    {
                        sb.AppendLine(auto.MostrarAuto());
                    }
                    if (item is Camion camion)
                    {
                        sb.AppendLine(camion.MostrarCamion());
                    }
                    if (item is Moto moto)
                    {
                        sb.AppendLine(moto.MostrarMoto());
                    }
                }
                return sb.ToString();
            }
        }

       public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool vehiculoEnL = false;
            if(!(l is null || v is null))
            {
                foreach (Vehiculo item in l.vehiculos)
                {
                    if(v == item)
                    {
                        vehiculoEnL = true;
                        break;
                    }
                }
            }
            return vehiculoEnL;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if(l != v)
            {
                l.vehiculos.Add(v);
            }

            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l.vehiculos.Remove(v);
            }

            return l;
        }

        public static int OrdenarPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Patente, v2.Patente);
        }
    }
}
