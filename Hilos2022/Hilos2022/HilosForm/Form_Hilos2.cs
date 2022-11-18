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
using Hilos2022;

namespace HilosForm
{
    public partial class Form_Hilos2 : Form
    {
        delegate void MiDelegado(string path);

        private string path;

        public Form_Hilos2()
        {
            InitializeComponent();

            this.path = "moonlight.jpg";
          
        }

        private void btnCambiarTexto_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(() => { CambiarTexto(); });

        }

        private void CambiarTexto()
        {
            //ERROR
            //this.lblTexto.Text = "CAMBIANDO TEXTO!!";
            if (this.lblTexto.InvokeRequired)
            {
                Action d = new Action(this.CambiarTexto);

                this.lblTexto.Invoke(d);

                /*
                this.lblTexto.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblTexto.Text = "cambio en begin invoke";
                }
                );*/
            }
            else
            {
                this.lblTexto.Text = "CAMBIANDO TEXTO!!";
            }
                
        }

        private void BtnCambiarFoto(object sender, EventArgs e)
        {
            Task t = Task.Run(() => { CambiarFoto(this.path); });
        }

        private void CambiarFoto(string path)
        {

            if (this.pictureBox.InvokeRequired)
            {
                MiDelegado d = new MiDelegado(CambiarFoto);

                object[] obj = new object[] { path};

                this.pictureBox.Invoke(d, obj);
            }else
            {
                this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
               this.pictureBox.ImageLocation = path;
                
             
            }
        }

    }
}
