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
    public static class AdminPublisher
    {
        public static List<Publisher> Listar()
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";

            //crear objeto sqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //Declarar objeto reader
            SqlDataReader lector;

            //crear el objeto reader
            lector = comando.ExecuteReader();

            //Recorrer(leer) los datos hacia adelante
            List<Publisher> lista = new List<Publisher>();

            while (lector.Read())
            {


                lista.Add(new Publisher()
                {
                    pub_id = lector["pub_id"].ToString(),
                    pub_name = lector["pub_name"].ToString(),
                    city = lector["city"].ToString(),
                    state =lector["state"].ToString(),
                    country = lector["country"].ToString()
                });
            }
            AdminDB.ConectarBase().Close();
            lector.Close();
            return lista;

        }

        public static List<Publisher> Listar(string ciudad)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @City";


            //crear objeto sqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = ciudad;
            //Declarar objeto reader
            SqlDataReader lector;

            //crear el objeto reader
            lector = comando.ExecuteReader();

            //Recorrer(leer) los datos hacia adelante
            List<Publisher> lista = new List<Publisher>();

            while (lector.Read())
            {


                lista.Add(new Publisher()
                {
                    pub_id = lector["pub_id"].ToString(),
                    pub_name = lector["pub_name"].ToString(),
                    city = lector["city"].ToString(),
                    state = lector["state"].ToString(),
                    country = lector["country"].ToString()
                });
            }
            AdminDB.ConectarBase().Close();
            lector.Close();
            return lista;

        }

        public static List<Publisher> Listar(string ciudad, string estado)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @City AND state = @State";


            //crear objeto sqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = ciudad;
            comando.Parameters.Add("@State", SqlDbType.Char, 2).Value = estado;
            //Declarar objeto reader
            SqlDataReader lector;

            //crear el objeto reader
            lector = comando.ExecuteReader();

            //Recorrer(leer) los datos hacia adelante
            List<Publisher> lista = new List<Publisher>();

            while (lector.Read())
            {


                lista.Add(new Publisher()
                {
                    pub_id = lector["pub_id"].ToString(),
                    pub_name = lector["pub_name"].ToString(),
                    city = lector["city"].ToString(),
                    state = lector["state"].ToString(),
                    country = lector["country"].ToString()
                });
            }
            AdminDB.ConectarBase().Close();
            lector.Close();
            return lista;

        }

        public static List<Publisher> Listar(string ciudad, string estado, string pais)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @City AND state = @State AND country = @Country";


            //crear objeto sqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = ciudad;
            comando.Parameters.Add("@State", SqlDbType.Char, 2).Value = estado;
            comando.Parameters.Add("@Country", SqlDbType.VarChar,30).Value = estado;
            //Declarar objeto reader
            SqlDataReader lector;

            //crear el objeto reader
            lector = comando.ExecuteReader();

            //Recorrer(leer) los datos hacia adelante
            List<Publisher> lista = new List<Publisher>();

            while (lector.Read())
            {


                lista.Add(new Publisher()
                {
                    pub_id = lector["pub_id"].ToString(),
                    pub_name = lector["pub_name"].ToString(),
                    city = lector["city"].ToString(),
                    state = lector["state"].ToString(),
                    country = lector["country"].ToString()
                });
            }
            AdminDB.ConectarBase().Close();
            lector.Close();
            return lista;

        }
    }
}
