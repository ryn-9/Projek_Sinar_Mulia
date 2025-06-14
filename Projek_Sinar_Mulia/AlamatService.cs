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
            using var conn = Database.GetConnection(); 
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
        public List<AlamatModel> GetAllAlamatGabungan()
        {
            var list = new List<AlamatModel>();

            // Contoh ambil dari join (bisa pakai SQL atau manual mapping dari 3 tabel)
            using var conn = Database.GetConnection();
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                    SELECT a.id_alamat, a.blok, a.id_jalan,j.jalan, rt.rt, rw.rw
                    FROM alamat a
                    JOIN jalan j ON a.id_jalan = j.id_jalan
                    JOIN rt ON j.id_rt = rt.id_rt
                    JOIN rw ON rt.id_rw = rw.id_rw", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new AlamatModel
                    {
                        id_alamat = reader.GetInt32(0),
                        blok = reader.GetString(1),
                        id_jalan = reader.GetInt32(2),
                        jalan = reader.GetString(3),
                        rt = reader.GetInt32(4),
                        rw = reader.GetInt32(5),
                    });
                }
            }

            return list;
        }

    }
}

