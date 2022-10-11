using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormImprimir
{
    public partial class FormImprimirDatos : Form
    {
        public FormImprimirDatos()
        {
            InitializeComponent();
        }
        public FormImprimirDatos(string titulo,string nombreCompleto,string materiaFavorita)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblNombre.Text = "Soy " + nombreCompleto + " y mi materia favorita es " + materiaFavorita;
        }

    }
}
