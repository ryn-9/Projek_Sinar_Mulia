using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using Projek_Sinar_Mulia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class RWService
    {
        public List<RWModel> GetAllRw()
        {
            var list = new List<RWModel>();
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT id_rw, rw FROM rw", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new RWModel
                {
                    id_rw = reader.GetInt32(0),
                    rw = reader.GetInt32(1)
                });
            }
            return list;
        }
    }

}
