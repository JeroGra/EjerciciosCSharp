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
    public partial class FormPrincipal : Form
    {
        private FrmMostrar formularioMostrar;
        private FrmTestDelegado formularioTestDelegado;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.formularioMostrar = new FrmMostrar();
            this.formularioTestDelegado = new FrmTestDelegado();

            this.formularioMostrar.MdiParent = this;
            this.formularioTestDelegado.MdiParent = this;
            this.formularioTestDelegado.cambiarNombre += this.formularioMostrar.ActualizarNombre;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formularioMostrar.Show();
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formularioTestDelegado.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }
    }
}
