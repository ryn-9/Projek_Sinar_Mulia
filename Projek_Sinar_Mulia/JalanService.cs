using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class JalanService
    {
        public List<JalanModel> GetJalanByRt(int id_rt)
        {
            var list = new List<JalanModel>();
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT id_jalan, jalan FROM jalan WHERE id_rt = @idRt", conn);
            cmd.Parameters.AddWithValue("@idRt", id_rt);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new JalanModel
                {
                    id_jalan = reader.GetInt32(0),
                    jalan = reader.GetString(1),
                    id_rt = id_rt
                });
            }
            return list;
        }

    }
    
}
