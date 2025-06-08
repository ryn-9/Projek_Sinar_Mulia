using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class AlamatService
    {
        public void SimpanAlamat(string blok, int id_jalan)
        {
            using var conn = Database.GetConnection(); // ← ini pakai koneksi dari class Database
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO alamat (blok, id_jalan) VALUES (@blok, @id_jalan)", conn);
            cmd.Parameters.AddWithValue("@blok", blok);
            cmd.Parameters.AddWithValue("@id_jalan", id_jalan);
            cmd.ExecuteNonQuery();
        }
        public List<AlamatModel> GetAllAlamat()
        {
            var list = new List<AlamatModel>();
            using var conn = Database.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_alamat, blok, id_jalan FROM alamat", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var model = new AlamatModel
                {
                    id_alamat = reader.GetInt32(0),
                    blok = reader.GetString(1),
                    id_jalan = reader.GetInt32(2)
                };
                list.Add(model);
            }
            return list;
        }
    }
}

