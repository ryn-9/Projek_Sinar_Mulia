namespace Projek_Sinar_Mulia.View.UC
{
    partial class TambahLahan
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
            cbRW = new ComboBox();
            cbRT = new ComboBox();
            cbJalan = new ComboBox();
            tbBlok = new TextBox();
            btnSimpanLahan = new Button();
            lbRW = new Label();
            lbRT = new Label();
            lbJalan = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbRW
            // 
            cbRW.FormattingEnabled = true;
            cbRW.Location = new Point(275, 245);
            cbRW.Margin = new Padding(4, 5, 4, 5);
            cbRW.Name = "cbRW";
            cbRW.Size = new Size(308, 33);
            cbRW.TabIndex = 0;
            cbRW.SelectedIndexChanged += cbRW_SelectedIndexChanged;
            // 
            // cbRT
            // 
            cbRT.FormattingEnabled = true;
            cbRT.Location = new Point(275, 322);
            cbRT.Margin = new Padding(4, 5, 4, 5);
            cbRT.Name = "cbRT";
            cbRT.Size = new Size(308, 33);
            cbRT.TabIndex = 1;
            // 
            // cbJalan
            // 
            cbJalan.FormattingEnabled = true;
            cbJalan.Location = new Point(275, 400);
            cbJalan.Margin = new Padding(4, 5, 4, 5);
            cbJalan.Name = "cbJalan";
            cbJalan.Size = new Size(308, 33);
            cbJalan.TabIndex = 2;
            // 
            // tbBlok
            // 
            tbBlok.Location = new Point(275, 475);
            tbBlok.Margin = new Padding(4, 5, 4, 5);
            tbBlok.Name = "tbBlok";
            tbBlok.Size = new Size(308, 31);
            tbBlok.TabIndex = 3;
            // 
            // btnSimpanLahan
            // 
            btnSimpanLahan.Location = new Point(381, 593);
            btnSimpanLahan.Margin = new Padding(4, 5, 4, 5);
            btnSimpanLahan.Name = "btnSimpanLahan";
            btnSimpanLahan.Size = new Size(107, 38);
            btnSimpanLahan.TabIndex = 4;
            btnSimpanLahan.Text = "Simpan ";
            btnSimpanLahan.UseVisualStyleBackColor = true;
            btnSimpanLahan.Click += btnSimpanLahan_Click;
            // 
            // lbRW
            // 
            lbRW.AutoSize = true;
            lbRW.Location = new Point(275, 206);
            lbRW.Margin = new Padding(4, 0, 4, 0);
            lbRW.Name = "lbRW";
            lbRW.Size = new Size(77, 25);
            lbRW.TabIndex = 5;
            lbRW.Text = "Pilih RW";
            // 
            // lbRT
            // 
            lbRT.AutoSize = true;
            lbRT.Location = new Point(275, 292);
            lbRT.Margin = new Padding(4, 0, 4, 0);
            lbRT.Name = "lbRT";
            lbRT.Size = new Size(68, 25);
            lbRT.TabIndex = 6;
            lbRT.Text = "Pilih RT";
            // 
            // lbJalan
            // 
            lbJalan.AutoSize = true;
            lbJalan.Location = new Point(278, 367);
            lbJalan.Margin = new Padding(4, 0, 4, 0);
            lbJalan.Name = "lbJalan";
            lbJalan.Size = new Size(87, 25);
            lbJalan.TabIndex = 7;
            lbJalan.Text = "Pilih Jalan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 443);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 8;
            label1.Text = "Masukkan Blok Lahan Sawah";
            // 
            // TambahLahan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lbJalan);
            Controls.Add(lbRT);
            Controls.Add(lbRW);
            Controls.Add(btnSimpanLahan);
            Controls.Add(tbBlok);
            Controls.Add(cbJalan);
            Controls.Add(cbRT);
            Controls.Add(cbRW);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TambahLahan";
            Size = new Size(859, 715);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRW;
        private ComboBox cbRT;
        private ComboBox cbJalan;
        private TextBox tbBlok;
        private Button btnSimpanLahan;
        private Label lbRW;
        private Label lbRT;
        private Label lbJalan;
        private Label label1;
    }
}
