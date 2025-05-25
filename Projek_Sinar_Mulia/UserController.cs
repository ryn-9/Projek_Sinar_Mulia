using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    class UserController
    {
        public static List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "select * from users";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserModel user = new UserModel
                            {
                                id_user = reader.GetInt32(0),
                                username = reader.GetString(1),                   
                                password = reader.GetString(3),
                            };
                            users.Add(user);

                        }
                    }
                }
                Database.CloseConnection();
            }
            return users;

        }
        public static void InsertUsers(UserModel user)
        {
            string query = $"INSERT INTO users(username, password, role) VALUES(@username, @password, @role)";
            try
            {
                using (var con = Database.GetConnection())
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@role", user.role);
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                Database.CloseConnection();

            }
        }
    }
}
