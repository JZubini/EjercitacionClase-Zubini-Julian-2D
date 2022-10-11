using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01____Hola__Windows_Forms_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cmbMateriaFavorita.Items.Add("Programación I");
            cmbMateriaFavorita.Items.Add("Laboratorio I");
            cmbMateriaFavorita.Items.Add("Programación II");
            cmbMateriaFavorita.Items.Add("Laboratorio II");
            cmbMateriaFavorita.Items.Add("Matemática");
            cmbMateriaFavorita.Items.Add("Estadística");
            cmbMateriaFavorita.Items.Add("Inglés I");
            cmbMateriaFavorita.Items.Add("Inglés II");
            cmbMateriaFavorita.Items.Add("Sistemas de procesamiento de datos");
            cmbMateriaFavorita.Items.Add("Arquitectura de sistemas operativos");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string tituloFormulario;
            string nombre;
            string apellido;
            string nombreCompleto;
            tituloFormulario = this.Text;
            nombre = txtNombreIngreso.Text;
            apellido = txtApellidoIngreso.Text;
            nombreCompleto = nombre + " " + apellido;
            FormSecundario frm = new FormSecundario(tituloFormulario, nombreCompleto);
            frm.Show();
        }

    }
}
