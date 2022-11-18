using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Ej_El_relojero
{
    public partial class Form1 : Form
    {
        private void AsignarHora()
        {
            if(this.lblHora.InvokeRequired)
            {
                Action d = new Action(this.AsignarHora);
                this.lblHora.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("G");
            }     
        }

        private void AsignarHora(int iteraciones)
        {
            while(true)
            {
                Thread.Sleep(1000);
                AsignarHora();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Task t = Task.Run(() => AsignarHora(10));
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AsignarHora();
        }
    }
}
