using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    class PetaniController
    {
        public static List<PetaniModel> GetAllPetani()
        {
            List<PetaniModel> petanis = new List<PetaniModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "select * from petani";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PetaniModel petani = new PetaniModel
                            {
                                id_petani = reader.GetInt32(0),
                                username = reader.GetString(1),
                                password = reader.GetString(2),
                                no_telephone = reader.GetString(3),
                            };
                            petanis.Add(petani);

                        }
                    }
                }
                //Database.CloseConnection();
            }
            return petanis;

        }
        public static void InsertPetani(PetaniModel petani)
        {
            string query = $"INSERT INTO petani(username, password, no_telephone) VALUES(@username, @password, @no_telephone)";
            try
            {
                using (var con = Database.GetConnection())
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", petani.username);
                        cmd.Parameters.AddWithValue("@password", petani.password);
                        cmd.Parameters.AddWithValue("@no_telephone", petani.no_telephone);
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
        public static bool HanyaAngka(string no_telephone)
        {
            return no_telephone.All(char.IsDigit);
        }
        public static bool CekUsername(string username)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT 1 FROM petani WHERE username = @username LIMIT 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public static bool CekNoTelp(string no_telephone)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT 1 FROM petani WHERE no_telephone = @no_telephone LIMIT 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@no_telephone", no_telephone);
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public static bool Login(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM petani WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
