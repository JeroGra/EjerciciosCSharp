using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej_Registrarce_Ingresante;

namespace Form_Registrarce_ej
{

    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre;
            string direccion;
            string[] cursos = new string[3];
            string genero = "";
            string pais;
            int edad;

            edad = int.Parse(this.numpEdad.Value.ToString());
            nombre = this.txtNombre.Text;
            direccion = this.txtDireccion.Text;
            pais = this.lstPaises.SelectedItem.ToString();
           
            if(this.rdbFem.Checked == true)
            {
                genero = "Femenino";
            }
            else
            {
                if(this.rdbMasc.Checked == true)
                {
                    genero = "Masculino";
                }
                else
                {
                    if(this.rdbNoB.Checked == true)
                    {
                        genero = "No Binario";
                    }
                }
            }


            if(this.cbC.Checked == true)
            {
                    cursos[0] = "C";
            }
            if(this.cbCsharp.Checked == true)
            {
                    cursos[1] = "C#";
            }
            if(this.cbJavaS.Checked == true)
            {
                    cursos[2] = "JavaScript";
            }


            Ingresante ingresanteUno = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show(ingresanteUno.Mostrar());

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.lstPaises.Items.Add("Argentina");
            this.lstPaises.Items.Add("Uruguay");
            this.lstPaises.Items.Add("Chile");
        }

    }
}
