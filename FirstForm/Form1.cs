using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHUPALA");
            this.button1.BackColor = Color.Coral;
            this.listBox1.Items.Add(this.textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Cambio en el load";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Coral;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = this.textBox1.Text;
            this.Text = texto;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
