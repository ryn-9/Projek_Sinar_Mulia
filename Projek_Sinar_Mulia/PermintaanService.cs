using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class PermintaanService
    {
        public int GetJumlahPermintaanByTanggal(DateTime tanggal)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM permintaan_irigasi WHERE tgl_permintaan = @tgl", conn);
            cmd.Parameters.AddWithValue("@tgl", tanggal.Date);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void SimpanPermintaan(int idLahan, DateTime tanggal)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("INSERT INTO permintaan_irigasi (tgl_permintaan, id_status, id_lahan) VALUES (@tgl, 1, @idLahan)", conn);
            cmd.Parameters.AddWithValue("@tgl", tanggal.Date);
            cmd.Parameters.AddWithValue("@idLahan", idLahan);
            cmd.ExecuteNonQuery();
        }
    }
}
