using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    class LahanService
    {
        public List<LahanModel> GetAllLahan(int idUsers)
        {
            var list = new List<LahanModel>();
            using var conn = Database.GetConnection();
            conn.Open();

            var sql = @"
            SELECT 
            l.id_lahan, l.luas, l.id_users, l.blok,
            j.jalan,rt.rt, rw.rw
            FROM lahan l
            JOIN jalan j ON l.id_jalan = j.id_jalan
            JOIN rt ON j.id_rt = rt.id_rt
            JOIN rw ON rt.id_rw = rw.id_rw
            WHERE l.id_users = @id_users";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_users", idUsers);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new LahanModel
                {
                    id_lahan = reader.GetInt32(0),
                    luas = reader.GetString(1),
                    id_users = reader.GetInt32(2),
                    blok = reader.GetString(3),
                    jalan = reader.GetString(4),
                    rt = reader.GetInt32(5),
                    rw = reader.GetInt32(6)
                });
            }

            return list;
        }
        public void SimpanLahan(string luas, string blok, int id_jalan)
        {
            using var conn = Database.GetConnection(); 
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO lahan (luas, blok, id_jalan) VALUES (@luas, @blok, @id_jalan)", conn);
            cmd.Parameters.AddWithValue("@luas", luas);
            cmd.Parameters.AddWithValue("@blok", blok);
            cmd.Parameters.AddWithValue("@id_jalan", id_jalan);
            cmd.ExecuteNonQuery();
        }

    }
}

