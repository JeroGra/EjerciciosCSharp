using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "Coloque un numero";
            this.btnLimpiar.Text = "Limpiar";
        }
        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = "";
            this.lstTabla.Items.Clear();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int text, multiplicacion;
            if (e.KeyChar == (char) Keys.Enter)
            {
                for(int i = 1;i<=10;i++)
                {
                    text = Convert.ToInt32(this.txtNumero.Text);
                    multiplicacion = i * text;
                    this.lstTabla.Items.Add($"{i} * {text} = {multiplicacion}");
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir de la app?","Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}
