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
    public partial class frmPublishers : Form
    {
        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            mostrarPublishers();
        }

        private void mostrarPublishers()
        {
            gridPublishers.DataSource = AdmPublisher.Listar();
        }

        private void mostrarPublishersParametrizado()
        {
            if (txtEstado.Text == "" && txtPais.Text == "")
            {
                gridPublishers.DataSource = AdmPublisher.Listar(txtCiudad.Text);
            }
            else if (txtPais.Text == "")
            {
                gridPublishers.DataSource = AdmPublisher.Listar(txtCiudad.Text, txtEstado.Text);
            }
            else
            {
                gridPublishers.DataSource = AdmPublisher.Listar(txtCiudad.Text, txtEstado.Text, txtPais.Text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarPublishersParametrizado();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarPublishers();
        }
    }
}
