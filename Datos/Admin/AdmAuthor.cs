using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Servidor;
using System.Data;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> Listar()
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";

            //crear objeto sqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //Declarar objeto reader
            SqlDataReader lector;

            //crear el objeto reader
            lector = comando.ExecuteReader();

            //Recorrer(leer) los datos hacia adelante
            List<Author> lista = new List<Author>();

            while (lector.Read())
            {
                lista.Add(new Author()
                {
                    au_id = (string)lector["au_id"],
                    au_lname = (string)lector["au_lname"],
                    au_fname = (string)lector["au_fname"],
                    phone = (string)lector["phone"],
                    address = (string)lector["address"],
                    city = (string)lector["city"],
                    state = (string)lector["state"],
                    zip = (string)lector["zip"],
                    contract = (bool)lector["contract"]
                });
            }
            AdminDB.ConectarBase().Close();
            lector.Close();
            return lista;
        }

    }
}
