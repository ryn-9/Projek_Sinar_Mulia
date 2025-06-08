using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class RTService
    {
        public List<RTModel> GetRtByRw(int id_Rw)
        {
            var list = new List<RTModel>();
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT id_rt, rt FROM rt WHERE id_rw = @idRw", conn);
            cmd.Parameters.AddWithValue("@idRw", id_Rw);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new RTModel
                {
                    id_rt = reader.GetInt32(0),
                    rt = reader.GetInt32(1),
                    id_rw = id_Rw
                });
            }
            return list;
        }

    }
}

