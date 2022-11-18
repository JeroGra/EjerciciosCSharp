using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase17_Ej_ElDelegado
{
    public partial class FrmTestDelegado : Form
    {
        public delegate void DelegadoDeNombres(string s);
        private FrmMostrar frmM = new FrmMostrar();
        public DelegadoDeNombres cambiarNombre;
        public FrmTestDelegado()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cambiarNombre(this.txtNombre.Text);
        }

        //private void txtNombre_TextChanged(object sender, EventArgs e)
        //{
        //    this.cambiarNombre(this.txtNombre.Text);
        //}
    }
}
