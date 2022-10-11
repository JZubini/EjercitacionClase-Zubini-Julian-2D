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
    public partial class FormSecundario : Form
    {
        public FormSecundario(string titulo, string nombre)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblPresentacion.Text = $"Soy {nombre}";

        }

        private void FormSecundario_Load(object sender, EventArgs e)
        {

        }
    }
}
