using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FormularioPrincipal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            lbPais.Items.Add("Argentina");
            lbPais.Items.Add("Paraguay");
            lbPais.Items.Add("Chile");
            lbPais.Items.Add("Uruguay");
            lbPais.Items.Add("Bolivia");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante nuevoIngresante;
            string nombre;
            decimal edad;
            string direccion;
            string genero;
            string pais;
            List<string> cursos = new List<string>();
            nombre = txtNombre.Text;
            edad = nudEdad.Value;
            direccion = txtDireccion.Text;
            pais = lbPais.Text;
            genero = "No ha ingresado genero";
            if (rbMasculino.Checked)
            {
                genero = rbMasculino.Text;
            }
            if (rbFemenino.Checked)
            {
                genero = rbFemenino.Text;
            }
            if (rbNoBinario.Checked)
            {
                genero = rbNoBinario.Text;
            }
            
            if (cbCSharp.Checked)
            {
                cursos.Add(cbCSharp.Text);
            }
            if (cbCPlusPlus.Checked)
            {
                cursos.Add(cbCPlusPlus.Text);
            }
            if (cbJavaScript.Checked)
            {
                cursos.Add(cbJavaScript.Text);
            }
            nuevoIngresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show(nuevoIngresante.Mostrar());
        }
    }
}
