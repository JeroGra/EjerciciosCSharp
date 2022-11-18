using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hilos2022;
using System.Threading;
using System.Threading.Tasks;

namespace HilosForm
{
    public partial class Form_Hilos : Form
    {
        private List<Persona> lista;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;

        public Form_Hilos()
        {
            InitializeComponent();
            this.lista = new List<Persona>();

            this.tokenSource = new CancellationTokenSource();
            this.token = this.tokenSource.Token;
        }


        private void btnSincronico_Click(object sender, EventArgs e)
        {

            this.lista = this.CargarDatos(this.lista);
       
            foreach (Persona item in this.lista)
            {
                this.listBox.Items.Add(item);
            }
        }

        private List<Persona> CargarDatos(List<Persona> lista)
        {
            Persona p = new Persona("Federico", 41);
            Persona p2 = new Persona("Pablo", 23);
            Persona p3 = new Persona("Juan", 57);
            Persona p4 = new Persona("Pedro", 34);

            this.lista.Add(p);
            this.lista.Add(p2);
            this.lista.Add(p3);
            this.lista.Add(p4);

            Thread.Sleep(5000);

            return lista;
        }



        private async void btnListarAsincronico_Click(object sender, EventArgs e)
        {
            this.lista = await this.CargarDatos();

            foreach (Persona item in this.lista)
            {
                this.listBox.Items.Add(item);
            }
        }

        private async Task<List<Persona>> CargarDatos()
        {
            List<Persona> lista = new List<Persona>();

            lista = await Task.Run(() => {
                Persona p = new Persona("Federico", 41);
                Persona p2 = new Persona("Pablo", 23);
                Persona p3 = new Persona("Juan", 57);
                Persona p4 = new Persona("Pedro", 34);

                Thread.Sleep(5000);

                lista.Add(p);
                lista.Add(p2);
                lista.Add(p3);
                lista.Add(p4);

                return lista;
            });


            return lista;

        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(()=>MostrarEnMessage(this.token));
        }

        private void MostrarEnMessage(CancellationToken t)
        {
            
            foreach(Persona item in this.lista)
            {
                if (t.IsCancellationRequested)
                {
                    MessageBox.Show("Cancelado");
                    return;
                }
              

                MessageBox.Show(item.ToString());
                Thread.Sleep(3000);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tokenSource.Cancel();
        }

        
    }
}
