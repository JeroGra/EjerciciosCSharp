using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        private int cambiando = 0;
        private string[] imagenes= { "1.jpg", "2.jpg", "3.jpg", "4.jpg","5.jpg", "6.jpg","7.jpg","8.jpg"};
        public Form1()
        {
            InitializeComponent();
            this.picture.ImageLocation = "No hay nada";



            this.btn.Click += new EventHandler(this.CambiarImagen);
        
        }

        private void CambiarImagen(object sender, EventArgs e)
        {

            if (this.cambiando == this.imagenes.Length)
            this.cambiando = 0;

            this.picture.ImageLocation = this.imagenes[this.cambiando];
            this.cambiando++;
        }

       
    }
}
