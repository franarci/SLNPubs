using Datos.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            mostrarAutores();
        }

        private void mostrarAutoresParametrizado()
        {
            if (txtEstado.Text == "")
            {
                gridAuthors.DataSource = AdmAuthor.Listar(txtCiudad.Text);
            }
            else
            {
                gridAuthors.DataSource = AdmAuthor.Listar(txtCiudad.Text, txtEstado.Text);
            }
        }

        private void mostrarAutores()
        {
            gridAuthors.DataSource = AdmAuthor.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarAutoresParametrizado();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarAutores();
        }
    }
}
