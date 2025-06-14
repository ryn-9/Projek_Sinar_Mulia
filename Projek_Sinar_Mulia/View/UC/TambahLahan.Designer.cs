﻿namespace Projek_Sinar_Mulia.View.UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahLahan));
            Label lbLuas;
            cbRW = new ComboBox();
            cbRT = new ComboBox();
            cbJalan = new ComboBox();
            tbBlok = new TextBox();
            btnSimpanLahan = new Button();
            lbRW = new Label();
            lbRT = new Label();
            lbJalan = new Label();
            label1 = new Label();
            label2 = new Label();
            tbLuas = new TextBox();
            lbLuas = new Label();
            SuspendLayout();
            // 
            // cbRW
            // 
            cbRW.FormattingEnabled = true;
            cbRW.Location = new Point(192, 112);
            cbRW.Name = "cbRW";
            cbRW.Size = new Size(217, 23);
            cbRW.TabIndex = 0;
            cbRW.SelectedIndexChanged += cbRW_SelectedIndexChanged;
            // 
            // cbRT
            // 
            cbRT.FormattingEnabled = true;
            cbRT.Location = new Point(192, 158);
            cbRT.Name = "cbRT";
            cbRT.Size = new Size(217, 23);
            cbRT.TabIndex = 1;
            // 
            // cbJalan
            // 
            cbJalan.FormattingEnabled = true;
            cbJalan.Location = new Point(192, 205);
            cbJalan.Name = "cbJalan";
            cbJalan.Size = new Size(217, 23);
            cbJalan.TabIndex = 2;
            // 
            // tbBlok
            // 
            tbBlok.Location = new Point(192, 250);
            tbBlok.Name = "tbBlok";
            tbBlok.Size = new Size(217, 23);
            tbBlok.TabIndex = 3;
            // 
            // btnSimpanLahan
            // 
            btnSimpanLahan.BackColor = Color.Transparent;
            btnSimpanLahan.BackgroundImage = (Image)resources.GetObject("btnSimpanLahan.BackgroundImage");
            btnSimpanLahan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpanLahan.FlatAppearance.BorderSize = 0;
            btnSimpanLahan.FlatStyle = FlatStyle.Flat;
            btnSimpanLahan.Location = new Point(240, 340);
            btnSimpanLahan.Name = "btnSimpanLahan";
            btnSimpanLahan.Size = new Size(121, 39);
            btnSimpanLahan.TabIndex = 4;
            btnSimpanLahan.UseVisualStyleBackColor = false;
            btnSimpanLahan.Click += btnSimpanLahan_Click;
            // 
            // lbRW
            // 
            lbRW.AutoSize = true;
            lbRW.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRW.ForeColor = Color.FromArgb(50, 107, 74);
            lbRW.Location = new Point(191, 94);
            lbRW.Name = "lbRW";
            lbRW.Size = new Size(54, 15);
            lbRW.TabIndex = 5;
            lbRW.Text = "Pilih RW";
            // 
            // lbRT
            // 
            lbRT.AutoSize = true;
            lbRT.Font = new Font("Microsoft Sans Serif", 8.999999F);
            lbRT.ForeColor = Color.FromArgb(50, 107, 74);
            lbRT.Location = new Point(192, 140);
            lbRT.Name = "lbRT";
            lbRT.Size = new Size(50, 15);
            lbRT.TabIndex = 6;
            lbRT.Text = "Pilih RT";
            // 
            // lbJalan
            // 
            lbJalan.AutoSize = true;
            lbJalan.Font = new Font("Microsoft Sans Serif", 8.999999F);
            lbJalan.ForeColor = Color.FromArgb(50, 107, 74);
            lbJalan.Location = new Point(193, 187);
            lbJalan.Name = "lbJalan";
            lbJalan.Size = new Size(64, 15);
            lbJalan.TabIndex = 7;
            lbJalan.Text = "Pilih Jalan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F);
            label1.ForeColor = Color.FromArgb(50, 107, 74);
            label1.Location = new Point(195, 233);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 8;
            label1.Text = "Masukkan Blok Lahan Sawah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 9;
            label2.Text = "Lahan";
            // 
            // tbLuas
            // 
            tbLuas.Location = new Point(194, 300);
            tbLuas.Name = "tbLuas";
            tbLuas.Size = new Size(215, 23);
            tbLuas.TabIndex = 10;
            tbLuas.TextChanged += textBox1_TextChanged;
            // 
            // lbLuas
            // 
            lbLuas.AutoSize = true;
            lbLuas.ForeColor = Color.SeaGreen;
            lbLuas.Location = new Point(196, 280);
            lbLuas.Name = "lbLuas";
            lbLuas.Size = new Size(147, 15);
            lbLuas.TabIndex = 11;
            lbLuas.Text = "Masukkan Luas Lahan (ha)";
            // 
            // TambahLahan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(lbLuas);
            Controls.Add(tbLuas);
            Controls.Add(label2);
            Controls.Add(btnSimpanLahan);
            Controls.Add(tbBlok);
            Controls.Add(cbJalan);
            Controls.Add(cbRT);
            Controls.Add(cbRW);
            Controls.Add(lbRT);
            Controls.Add(lbRW);
            Controls.Add(lbJalan);
            Controls.Add(label1);
            Name = "TambahLahan";
            Size = new Size(601, 429);
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
        private Label label2;
        private TextBox tbLuas;
    }
}
