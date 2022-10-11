using FormImprimir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPresentacion
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string titulo;
            string nombre;
            string apellido;
            string nombreCompleto;
            string materiaFavorita;
            string mensajeError;
            string tituloMensajeError;
            tituloMensajeError = "ERROR";
            if (String.IsNullOrWhiteSpace(txtNombre.Text) && String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                mensajeError = "Se deben completar los siguientes campos: \n Nombre \n Apellido";
                MessageBox.Show(mensajeError, tituloMensajeError);
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    mensajeError = "Se deben completar los siguientes campos: \n Nombre";
                    MessageBox.Show(mensajeError, tituloMensajeError);
                }
                if (String.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    mensajeError = "Se deben completar los siguientes campos: \n Apellido";
                    MessageBox.Show(mensajeError, tituloMensajeError);
                }
                
            }
            
            if (!(String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtApellido.Text)))
            {
                titulo = this.Text;
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                nombreCompleto = nombre + " " + apellido;
                materiaFavorita = cmbMateriaFavorita.Text;
                FormImprimirDatos frmImprimir = new FormImprimirDatos(titulo, nombreCompleto, materiaFavorita);
                frmImprimir.Show();
            }


            
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            
            cmbMateriaFavorita.Items.Add("Programación I");
            cmbMateriaFavorita.Items.Add("Programación II");
            cmbMateriaFavorita.Items.Add("Laboratorio I");
            cmbMateriaFavorita.Items.Add("Laboratorio II");
            cmbMateriaFavorita.Items.Add("Matemática");
            cmbMateriaFavorita.Items.Add("Estadística");
            cmbMateriaFavorita.Items.Add("Inglés I");
            cmbMateriaFavorita.Items.Add("Inglés II");
            cmbMateriaFavorita.Items.Add("Sistemas de procesamiento de datos");
            cmbMateriaFavorita.Items.Add("Arquitectura de sistemas operativos");
            cmbMateriaFavorita.Items.Add("Metodología de la investigación");
            cmbMateriaFavorita.SelectedIndex = 0;
        }

        private void cmbMateriaFavorita_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
