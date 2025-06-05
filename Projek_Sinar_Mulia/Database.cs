using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projek_Sinar_Mulia
{
    class Database
    {
        private static string localhost = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "babamamak55";
        private static string database = "Tabel projek PBO";

        private static NpgsqlConnection conn;

        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
            return new NpgsqlConnection(connString);
            //if (conn == null)
            //{
            //    string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
            //    conn = new NpgsqlConnection(connString);
            //}
            //return conn;
        }

        //public static void CloseConnection()
        //{
        //    if (conn != null)
        //    {
        //        conn.Close();
        //        conn = null;

        //    }
        //}
    }
}
