using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.VisualBasic.ApplicationServices;

namespace Projek_Sinar_Mulia.View.UC
{
    public partial class Riwayat : UserControl
    {
        private int UserId;
        public Riwayat(int idUser)
        {
            InitializeComponent();
            UserId = idUser;
            LoadRiwayatData(UserId);
        }
        private void LoadRiwayatData(int idUser)
        {
            using (NpgsqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    pi.tgl_permintaan AS ""Tanggal_Permintaan"", 
                    u.username AS ""Petani"", 
                    l.luas AS ""Luas"", 
                    a.blok AS ""Blok"", 
                    j.jalan AS ""Jalan"", 
                    rt.rt AS ""RT"", 
                    rw.rw AS ""RW"", 
                    s.status AS ""Status""
                FROM permintaan_irigasi pi
                JOIN lahan l USING(id_lahan)
                JOIN users u USING(id_users)
                JOIN alamat a USING(id_alamat)
                JOIN jalan j USING(id_jalan)
                JOIN rt rt USING(id_rt)
                JOIN rw rw USING(id_rw)
                JOIN status s USING(id_status)
                WHERE u.id_users = @id_users";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_users", idUser);

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
