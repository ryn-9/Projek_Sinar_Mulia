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
        public List<LahanModel> GetAllLahan()
        {
            var list = new List<LahanModel>();
            using var conn = Database.GetConnection();
            conn.Open();

            var sql = @"
            SELECT 
            la.id_lahan, la.luas, la.id_users, la.id_alamat,al.blok
            FROM lahan la
            JOIN alamat al ON la.id_alamat = al.id_alamat";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LahanModel
                {
                    id_lahan = reader.GetInt32(0),
                    luas = reader.GetDouble(1),
                    id_users = reader.GetInt32(2),
                    id_alamat = reader.GetInt32(3),
                    blok = reader.GetString(4)
                });
            }
            return list;
        }
    }
}

