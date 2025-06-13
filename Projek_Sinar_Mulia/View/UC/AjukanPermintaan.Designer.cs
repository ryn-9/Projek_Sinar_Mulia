namespace Projek_Sinar_Mulia
{
    partial class AjukanPermintaan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjukanPermintaan));
            btnSimpan = new Button();
            pbLokasi = new PictureBox();
            pbDurasi = new PictureBox();
            pbTanggal = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            tbDurasi = new TextBox();
            lbLokasi = new Label();
            lbTanggal = new Label();
            lbDurasi = new Label();
            cbLokasi = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLokasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDurasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTanggal).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(243, 335);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(115, 45);
            btnSimpan.TabIndex = 1;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // pbLokasi
            // 
            pbLokasi.BackColor = Color.Transparent;
            pbLokasi.BackgroundImage = (Image)resources.GetObject("pbLokasi.BackgroundImage");
            pbLokasi.BackgroundImageLayout = ImageLayout.Zoom;
            pbLokasi.Location = new Point(137, 144);
            pbLokasi.Name = "pbLokasi";
            pbLokasi.Size = new Size(327, 33);
            pbLokasi.TabIndex = 2;
            pbLokasi.TabStop = false;
            // 
            // pbDurasi
            // 
            pbDurasi.BackColor = Color.Transparent;
            pbDurasi.BackgroundImage = (Image)resources.GetObject("pbDurasi.BackgroundImage");
            pbDurasi.BackgroundImageLayout = ImageLayout.Zoom;
            pbDurasi.Location = new Point(139, 262);
            pbDurasi.Name = "pbDurasi";
            pbDurasi.Size = new Size(327, 33);
            pbDurasi.TabIndex = 3;
            pbDurasi.TabStop = false;
            // 
            // pbTanggal
            // 
            pbTanggal.BackColor = Color.Transparent;
            pbTanggal.BackgroundImage = (Image)resources.GetObject("pbTanggal.BackgroundImage");
            pbTanggal.BackgroundImageLayout = ImageLayout.Zoom;
            pbTanggal.Location = new Point(139, 203);
            pbTanggal.Name = "pbTanggal";
            pbTanggal.Size = new Size(327, 33);
            pbTanggal.TabIndex = 5;
            pbTanggal.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 208);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // tbDurasi
            // 
            tbDurasi.BackColor = Color.Gainsboro;
            tbDurasi.BorderStyle = BorderStyle.None;
            tbDurasi.Location = new Point(145, 265);
            tbDurasi.Name = "tbDurasi";
            tbDurasi.Size = new Size(309, 16);
            tbDurasi.TabIndex = 8;
            // 
            // lbLokasi
            // 
            lbLokasi.AutoSize = true;
            lbLokasi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lbLokasi.ForeColor = Color.FromArgb(0, 64, 0);
            lbLokasi.Location = new Point(137, 126);
            lbLokasi.Name = "lbLokasi";
            lbLokasi.Size = new Size(80, 15);
            lbLokasi.TabIndex = 10;
            lbLokasi.Text = "Pilih Lahan";
            lbLokasi.Click += lbLokasi_Click;
            // 
            // lbTanggal
            // 
            lbTanggal.AutoSize = true;
            lbTanggal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lbTanggal.ForeColor = Color.FromArgb(0, 64, 0);
            lbTanggal.Location = new Point(139, 185);
            lbTanggal.Name = "lbTanggal";
            lbTanggal.Size = new Size(172, 15);
            lbTanggal.TabIndex = 11;
            lbTanggal.Text = "Masukkan Tanggal Irigasi";
            // 
            // lbDurasi
            // 
            lbDurasi.AutoSize = true;
            lbDurasi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lbDurasi.ForeColor = Color.FromArgb(0, 64, 0);
            lbDurasi.Location = new Point(141, 244);
            lbDurasi.Name = "lbDurasi";
            lbDurasi.Size = new Size(212, 15);
            lbDurasi.TabIndex = 12;
            lbDurasi.Text = "Masukkan Durasi Irigasi (Menit)";
            // 
            // cbLokasi
            // 
            cbLokasi.BackColor = Color.Gainsboro;
            cbLokasi.FormattingEnabled = true;
            cbLokasi.Location = new Point(147, 149);
            cbLokasi.Name = "cbLokasi";
            cbLokasi.Size = new Size(307, 23);
            cbLokasi.TabIndex = 14;
            cbLokasi.SelectedIndexChanged += cbLokasi_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Paytone One", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 15;
            label2.Text = "Permintaan";
            // 
            // AjukanPermintaan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label2);
            Controls.Add(cbLokasi);
            Controls.Add(lbDurasi);
            Controls.Add(lbTanggal);
            Controls.Add(lbLokasi);
            Controls.Add(tbDurasi);
            Controls.Add(dateTimePicker1);
            Controls.Add(pbTanggal);
            Controls.Add(pbDurasi);
            Controls.Add(pbLokasi);
            Controls.Add(btnSimpan);
            Name = "AjukanPermintaan";
            Size = new Size(601, 429);
            ((System.ComponentModel.ISupportInitialize)pbLokasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDurasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTanggal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSimpan;
        private PictureBox pbLokasi;
        private PictureBox pbDurasi;
        private PictureBox pbTanggal;
        private DateTimePicker dateTimePicker1;
        private TextBox tbDurasi;
        private Label lbLokasi;
        private Label lbTanggal;
        private Label lbDurasi;
        private ComboBox cbLokasi;
        private Label label2;
    }
}
