using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Projek_Sinar_Mulia.View.UC
{
    public partial class KelolaPermintaan : UserControl
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=babamamak55;Database=PBO;";
        private Dictionary<int, string> statusDict = new Dictionary<int, string>();
        private Dictionary<string, int> reverseStatusDict = new Dictionary<string, int>();

        public KelolaPermintaan()
        {
            InitializeComponent();
            LoadStatusOptions();
            LoadData();
        }

        private void LoadStatusOptions()
        {
            statusDict.Clear();
            reverseStatusDict.Clear();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_status, status FROM status";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string status = reader.GetString(1);
                        statusDict[id] = status;
                        reverseStatusDict[status] = id;
                    }
                }
            }
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT pi.id_permintaan, pi.tgl_permintaan, pi.id_lahan, s.status
                    FROM permintaan_irigasi pi
                    JOIN status s ON pi.id_status = s.id_status
                    ORDER BY pi.id_permintaan";
                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dt;

                    // Ubah kolom status menjadi ComboBox
                    DataGridViewComboBoxColumn comboCol = new DataGridViewComboBoxColumn
                    {
                        DataPropertyName = "status",
                        HeaderText = "Status",
                        Name = "status",
                        DataSource = new BindingSource(statusDict, null),
                        DisplayMember = "Value",
                        ValueMember = "Value",
                        FlatStyle = FlatStyle.Flat
                    };

                    int statusColIndex = dataGridView1.Columns["status"].Index;
                    dataGridView1.Columns.RemoveAt(statusColIndex);
                    dataGridView1.Columns.Insert(statusColIndex, comboCol);

                    // Tangani event perubahan
                    dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["status"].Index && e.RowIndex >= 0)
            {
                string selectedStatus = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
                int id_status = reverseStatusDict[selectedStatus];
                int id_permintaan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_permintaan"].Value);

                UpdateStatusInDatabase(id_permintaan, id_status);
            }
        }

        private void UpdateStatusInDatabase(int id_permintaan, int id_status)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE permintaan_irigasi SET id_status = @id_status WHERE id_permintaan = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_status", id_status);
                        cmd.Parameters.AddWithValue("@id", id_permintaan);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memperbarui status: " + ex.Message);
                }
            }
        }

        private void btnKelolaStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silakan ubah langsung status dari tabel.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tidak digunakan
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KelolaPermintaan_Load(object sender, EventArgs e)
        {

        }
    }
}
