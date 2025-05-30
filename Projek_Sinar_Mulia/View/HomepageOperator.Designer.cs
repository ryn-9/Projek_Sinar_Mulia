namespace Projek_Sinar_Mulia.View
{
    partial class HomepageOperator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageOperator));
            pnlsidebar = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            picindikator = new PictureBox();
            btnabout = new Button();
            btnriwayat = new Button();
            btnkelolapermintaan = new Button();
            panel1 = new Panel();
            pnlutama = new Panel();
            pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picindikator).BeginInit();
            SuspendLayout();
            // 
            // pnlsidebar
            // 
            pnlsidebar.BackColor = Color.LightGreen;
            pnlsidebar.Controls.Add(pictureBox1);
            pnlsidebar.Controls.Add(label1);
            pnlsidebar.Controls.Add(panel2);
            pnlsidebar.Controls.Add(picindikator);
            pnlsidebar.Controls.Add(btnabout);
            pnlsidebar.Controls.Add(btnriwayat);
            pnlsidebar.Controls.Add(btnkelolapermintaan);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 0);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(198, 449);
            pnlsidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 107, 74);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 107, 74);
            label1.Font = new Font("Montserrat Black", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Sinar Mulia Group";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 107, 74);
            panel2.Location = new Point(0, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 42);
            panel2.TabIndex = 6;
            // 
            // picindikator
            // 
            picindikator.Image = (Image)resources.GetObject("picindikator.Image");
            picindikator.Location = new Point(0, 65);
            picindikator.Name = "picindikator";
            picindikator.Size = new Size(15, 39);
            picindikator.SizeMode = PictureBoxSizeMode.Zoom;
            picindikator.TabIndex = 5;
            picindikator.TabStop = false;
            picindikator.Click += picindikator_Click;
            // 
            // btnabout
            // 
            btnabout.FlatAppearance.BorderSize = 0;
            btnabout.FlatStyle = FlatStyle.Flat;
            btnabout.Font = new Font("Paytone One", 11.999999F);
            btnabout.ForeColor = Color.FromArgb(50, 107, 74);
            btnabout.Image = (Image)resources.GetObject("btnabout.Image");
            btnabout.Location = new Point(-31, 159);
            btnabout.Margin = new Padding(0);
            btnabout.Name = "btnabout";
            btnabout.Padding = new Padding(10, 0, 10, 0);
            btnabout.Size = new Size(261, 39);
            btnabout.TabIndex = 4;
            btnabout.Text = "About";
            btnabout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnabout.UseVisualStyleBackColor = true;
            btnabout.Click += btnabout_Click;
            // 
            // btnriwayat
            // 
            btnriwayat.FlatAppearance.BorderSize = 0;
            btnriwayat.FlatStyle = FlatStyle.Flat;
            btnriwayat.Font = new Font("Paytone One", 11.999999F);
            btnriwayat.ForeColor = Color.FromArgb(50, 107, 74);
            btnriwayat.Image = (Image)resources.GetObject("btnriwayat.Image");
            btnriwayat.Location = new Point(-11, 112);
            btnriwayat.Margin = new Padding(0);
            btnriwayat.Name = "btnriwayat";
            btnriwayat.Padding = new Padding(10, 0, 10, 0);
            btnriwayat.Size = new Size(209, 39);
            btnriwayat.TabIndex = 3;
            btnriwayat.Text = "Lihat Riwayat";
            btnriwayat.TextAlign = ContentAlignment.MiddleRight;
            btnriwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnriwayat.UseVisualStyleBackColor = true;
            btnriwayat.Click += btnriwayat_Click;
            // 
            // btnkelolapermintaan
            // 
            btnkelolapermintaan.FlatAppearance.BorderSize = 0;
            btnkelolapermintaan.FlatStyle = FlatStyle.Flat;
            btnkelolapermintaan.Font = new Font("Paytone One", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnkelolapermintaan.ForeColor = Color.FromArgb(50, 107, 74);
            btnkelolapermintaan.Image = (Image)resources.GetObject("btnkelolapermintaan.Image");
            btnkelolapermintaan.Location = new Point(0, 65);
            btnkelolapermintaan.Margin = new Padding(0);
            btnkelolapermintaan.Name = "btnkelolapermintaan";
            btnkelolapermintaan.Padding = new Padding(10, 0, 10, 0);
            btnkelolapermintaan.Size = new Size(212, 39);
            btnkelolapermintaan.TabIndex = 2;
            btnkelolapermintaan.Text = "Kelola Permintaan";
            btnkelolapermintaan.TextAlign = ContentAlignment.MiddleRight;
            btnkelolapermintaan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnkelolapermintaan.UseVisualStyleBackColor = true;
            btnkelolapermintaan.Click += btnkelolapermintaan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 20);
            panel1.TabIndex = 1;
            // 
            // pnlutama
            // 
            pnlutama.Location = new Point(194, 12);
            pnlutama.Name = "pnlutama";
            pnlutama.Size = new Size(688, 437);
            pnlutama.TabIndex = 2;
            // 
            // HomepageOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 449);
            Controls.Add(panel1);
            Controls.Add(pnlutama);
            Controls.Add(pnlsidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "HomepageOperator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage Operator";
            pnlsidebar.ResumeLayout(false);
            pnlsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picindikator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlsidebar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnkelolapermintaan;
        private Button btnabout;
        private Button btnriwayat;
        private PictureBox picindikator;
        private Panel panel1;
        private Panel pnlutama;
        private Panel panel2;
    }
}