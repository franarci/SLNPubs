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
            llenarComboCiudad();
            mostrarAutores();
        }

        private void llenarComboCiudad()
        {
            DataTable ciudades = AdmAuthor.listarSoloCiudades();

            cbCiudad.DataSource = ciudades;
            cbCiudad.DisplayMember = ciudades.Columns["city"].ToString();
            cbCiudad.ValueMember = ciudades.Columns["city"].ToString();

            // Agregar una fila al DataTable "Categoria" en memoria
            DataRow fila = ciudades.NewRow();
            fila["city"] = "[TODAS]";
            ciudades.Rows.InsertAt(fila, 0);

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

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            string ciudad =cbCiudad.SelectedValue.ToString();

            if (ciudad == "[TODAS]")
            {
                mostrarAutores();
            }
            else
            {
                gridAuthors.DataSource = AdmAuthor.listarDataTable(ciudad);
            }

        }
    }
}
