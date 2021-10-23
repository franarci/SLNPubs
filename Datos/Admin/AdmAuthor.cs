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


        public static List<Author> Listar(string ciudad)
        {
            //MODIFICAMOS ---> la consulta de SQL CON EL WHERE
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors  WHERE city=@City";

            //Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());


            //AGREGAMOS ---> Declarar el parámetro de SQL Server 
            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = ciudad;


            //declarar un objeto SqlDataReader
            SqlDataReader reader;

            //crear el reader
            reader = comando.ExecuteReader();

            //Recorrer leer los datos hacia adelante
            List<Author> lista = new List<Author>();

            while (reader.Read())
            {
                lista.Add(
                    new Author()
                    {
                        au_id = (string)reader["au_id"],
                        au_lname = (string)reader["au_lname"],
                        au_fname = (string)reader["au_fname"],
                        phone = (string)reader["phone"],
                        address = (string)reader["address"],
                        city = (string)reader["city"],
                        state = (string)reader["state"],
                        zip = (string)reader["zip"],
                        contract = (bool)reader["contract"]
                    }
                    );
            }
            AdminDB.ConectarBase().Close();//cerramos la conexión
            reader.Close();
            return lista;

        }


        public static List<Author> Listar(string ciudad, string estado)
        {
            //MODIFICAMOS ---> la consulta de SQL CON EL WHERE
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors  WHERE city=@City AND state=@State";

            //Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());


            //AGREGAMOS ---> Declarar el parámetro de SQL Server 
            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = ciudad;

            comando.Parameters.Add("@State", SqlDbType.Char, 2).Value = estado;


            //declarar un objeto SqlDataReader
            SqlDataReader reader;

            //crear el reader
            reader = comando.ExecuteReader();

            //Recorrer leer los datos hacia adelante
            List<Author> lista = new List<Author>();

            while (reader.Read())
            {
                lista.Add(
                    new Author()
                    {
                        au_id = (string)reader["au_id"],
                        au_lname = (string)reader["au_lname"],
                        au_fname = (string)reader["au_fname"],
                        phone = (string)reader["phone"],
                        address = (string)reader["address"],
                        city = (string)reader["city"],
                        state = (string)reader["state"],
                        zip = (string)reader["zip"],
                        contract = (bool)reader["contract"]
                    }
                    );
            }
            AdminDB.ConectarBase().Close();//cerramos la conexión
            reader.Close();
            return lista;

        }

        public static DataTable listarSoloCiudades()
        {
            
            string consultaSQL = "SELECT DISTINCT city FROM dbo.authors";
            
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());
          
            DataSet dataSet = new DataSet();
          
            adapter.Fill(dataSet, "ciudad");

          
            return dataSet.Tables["ciudad"];

        }

        public static DataTable listarDataTable(string ciudad)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors where city = @city";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "ciudad");

            return ds.Tables["ciudad"];

        }
    }
}
