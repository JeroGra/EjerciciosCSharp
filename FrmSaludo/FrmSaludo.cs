using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSaludo
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Visible = false;
            this.Text = "Saludo desde un form";
            this.lblSaludo.Text = "HOLA MUNDO!!!!";
            this.btnSaludo.Text = "Haga click aqui";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            this.lblSaludo.Visible = true;
        }
    }
}
