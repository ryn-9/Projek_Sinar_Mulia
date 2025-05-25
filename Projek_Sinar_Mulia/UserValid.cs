using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public static class UserValid
    {
        public static bool Login(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read(); // true kalau ditemukan
                    }
                }
            }
        }

        public static string CekRole(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT role FROM users WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }
    }
}
            

    
