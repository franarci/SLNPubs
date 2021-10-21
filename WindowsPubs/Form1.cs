using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Admin;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarAutores();
            gridPublishers.DataSource = AdminPublisher.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarAutoresParametrizado();
        }

        void mostrarAutoresParametrizado()
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

        private void mostrarPublishersParametrizado()
        {
            if (txtEstadoP.Text == "" && txtPaisP.Text == "")
            {
                gridPublishers.DataSource = AdminPublisher.Listar(txtCiudadP.Text);
            }
            else if(txtPaisP.Text == "")
            {
                gridPublishers.DataSource = AdminPublisher.Listar(txtCiudadP.Text, txtEstadoP.Text);
            } else
            {
                gridPublishers.DataSource = AdminPublisher.Listar(txtCiudad.Text, txtEstadoP.Text, txtPaisP.Text);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarAutores();
        }

        private void btnMostrarP_Click(object sender, EventArgs e)
        {
            mostrarPublishers();
        }

        private void mostrarPublishers()
        {
            gridPublishers.DataSource = AdminPublisher.Listar();
        }

        private void mostrarAutores()
        {
            gridAuthors.DataSource = AdmAuthor.Listar();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            mostrarPublishersParametrizado();
        }

        

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            mostrarAutoresParametrizado();
        }

        
    }
}
