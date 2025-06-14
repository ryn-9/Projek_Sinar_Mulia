﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.ApplicationServices;

namespace Projek_Sinar_Mulia.View.UC
{
    public partial class TambahLahan : UserControl
    {
        private int currentUserId;
        public TambahLahan(int idUser)
        {
            InitializeComponent();
            MessageBox.Show($"Login berhasil. userId = {idUser}");
            currentUserId = idUser;
            this.Load += new System.EventHandler(this.UserControl_Load);
            cbRW.SelectedIndexChanged += new EventHandler(cbRW_SelectedIndexChanged);
            cbRT.SelectedIndexChanged += new EventHandler(cbRT_SelectedIndexChanged);

        }
        private void UserControl_Load(object sender, EventArgs e)
        {
            var rwService = new RWService();
            cbRW.DataSource = rwService.GetAllRw();
            cbRW.DisplayMember = "rw";
            cbRW.ValueMember = "id_rw";

            cbRW.SelectedIndex = -1;

            cbRT.DataSource = null;
            cbJalan.DataSource = null;
        }

        private void cbRW_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRW = cbRW.SelectedItem as RWModel;
            if (selectedRW != null)
            {
                var rtService = new RTService();
                cbRT.DataSource = rtService.GetRtByRw(selectedRW.id_rw);
                cbRT.DisplayMember = "rt";
                cbRT.ValueMember = "id_rt";
                cbRT.SelectedIndex = -1;
                cbJalan.DataSource = null;
            }
        }
        private void cbRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRT = cbRT.SelectedItem as RTModel;
            if (selectedRT != null)
            {
                var jalanService = new JalanService();
                cbJalan.DataSource = jalanService.GetJalanByRt(selectedRT.id_rt);
                cbJalan.DisplayMember = "jalan";
                cbJalan.ValueMember = "id_jalan";
                cbJalan.SelectedIndex = -1;
            }
        }
        private void btnSimpanLahan_Click(object sender, EventArgs e)
        {
            if (cbJalan.SelectedItem is JalanModel selectedJalan)
            {
                string blok = tbBlok.Text.Trim();
                string luas = tbLuas.Text.Trim();

                if (string.IsNullOrEmpty(blok) || string.IsNullOrEmpty(luas))
                {
                    MessageBox.Show("Blok atau luas belum diisi.");
                    return;
                }

                int id_jalan = selectedJalan.id_jalan;
                //int id_users = idUser;

                using var conn = Database.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO lahan (luas, blok, id_jalan, id_users) VALUES (@luas, @blok, @id_jalan, @id_users)", conn);
                cmd.Parameters.AddWithValue("@luas", luas);
                cmd.Parameters.AddWithValue("@blok", blok);
                cmd.Parameters.AddWithValue("@id_jalan", id_jalan);
                cmd.Parameters.AddWithValue("@id_users", currentUserId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Lahan berhasil disimpan!");
                tbBlok.Clear();
                tbLuas.Clear();
                cbRW.SelectedIndex = -1;
                cbRT.DataSource = null;
                cbJalan.DataSource = null;
            }
            else
            {
                MessageBox.Show("Silakan pilih Jalan terlebih dahulu.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
