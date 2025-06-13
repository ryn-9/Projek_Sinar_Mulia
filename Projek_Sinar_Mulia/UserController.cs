using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class UserController
    {
        public static List<UserModel> GetAllUser()
        {
            List<UserModel> users = new List<UserModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_users, username, password, no_telp, id_roles FROM users";
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
                                password = reader.GetString(2),
                                no_telp = reader.GetString(3),
                                id_roles = reader.GetInt32(4)
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
         public static int? GetRoleId(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_roles FROM users WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null; // login gagal
                    }
                }
            }
        }
        public static bool CekUsername(string username)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "select 1 from users WHERE username = @username LIMIT 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public static int? GetUserId(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_users FROM users WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null; // user tidak ditemukan
                    }
                }
            }
        }

        public static void InsertUsers(UserModel user)
        {
            string query = $"INSERT INTO users(username, password, no_telp, id_roles) VALUES(@username, @password, @no_telp, 1)";
            try
            {
                using (var con = Database.GetConnection())
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@no_telp", user.no_telp);
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
                //Database.CloseConnection();

            }
        }
        public static bool HanyaAngka(string no_telp)
        {
            return no_telp.All(char.IsDigit);
        }
    }
}
