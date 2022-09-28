using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio03
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lblImporte.Text = "Importe a cobrar";
            this.lblDescuento.Text = "Descuento";
            this.lblTotal.Text = "Total a pagar";

            this.btnLimpiar.Text = "Limpiar";
            this.btnAceptar.Text = "Aceptar";
            this.groupInfo.Text = "Informacion";

            this.txtDescuento.Enabled = false;
            this.txtTotal.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int importe;
            double descuento = 0, operacion, total;

            importe = Convert.ToInt32(this.txtImporte.Text);
            if(importe > 2999 && importe < 5001)
            {
                descuento = 0.1;
            }
            else
            {
                if(importe > 5000)
                {
                    descuento = 0.2;
                }
            }

            operacion = descuento * importe;
            total = importe - operacion;

            this.txtDescuento.Text = Convert.ToString(operacion);
            this.txtTotal.Text = Convert.ToString(total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            this.txtImporte.Text = "";
            this.txtDescuento.Text = "";
        }
    }
}
