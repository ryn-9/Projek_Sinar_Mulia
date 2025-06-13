namespace Projek_Sinar_Mulia
{
    partial class HomepagePetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepagePetani));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            picindikator = new PictureBox();
            btnlahan = new Button();
            btnkelolapermintaan = new Button();
            panel1 = new Panel();
            pnlutama = new Panel();
            pnlsidebar = new Panel();
            panel2 = new Panel();
            btnlogout = new Button();
            btnlihatstatus = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picindikator).BeginInit();
            pnlsidebar.SuspendLayout();
            SuspendLayout();
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
            label1.Font = new Font("Montserrat Black", 9.749999F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Sinar Mulia Group";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picindikator
            // 
            picindikator.Image = (Image)resources.GetObject("picindikator.Image");
            picindikator.Location = new Point(0, 62);
            picindikator.Name = "picindikator";
            picindikator.Size = new Size(11, 39);
            picindikator.SizeMode = PictureBoxSizeMode.Zoom;
            picindikator.TabIndex = 5;
            picindikator.TabStop = false;
            picindikator.Visible = false;
            picindikator.Click += picindikator_Click_1;
            // 
            // btnlahan
            // 
            btnlahan.FlatAppearance.BorderSize = 0;
            btnlahan.FlatStyle = FlatStyle.Flat;
            btnlahan.Font = new Font("Paytone One", 11.999999F);
            btnlahan.ForeColor = Color.FromArgb(50, 107, 74);
            btnlahan.Image = (Image)resources.GetObject("btnlahan.Image");
            btnlahan.Location = new Point(-30, 104);
            btnlahan.Margin = new Padding(0);
            btnlahan.Name = "btnlahan";
            btnlahan.Padding = new Padding(10, 0, 10, 0);
            btnlahan.Size = new Size(261, 39);
            btnlahan.TabIndex = 4;
            btnlahan.Text = "Lahan";
            btnlahan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlahan.UseVisualStyleBackColor = true;
            btnlahan.Click += btnlahan_Click;
            // 
            // btnkelolapermintaan
            // 
            btnkelolapermintaan.FlatAppearance.BorderSize = 0;
            btnkelolapermintaan.FlatStyle = FlatStyle.Flat;
            btnkelolapermintaan.Font = new Font("Paytone One", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnkelolapermintaan.ForeColor = Color.FromArgb(50, 107, 74);
            btnkelolapermintaan.Image = (Image)resources.GetObject("btnkelolapermintaan.Image");
            btnkelolapermintaan.Location = new Point(-14, 65);
            btnkelolapermintaan.Margin = new Padding(0);
            btnkelolapermintaan.Name = "btnkelolapermintaan";
            btnkelolapermintaan.Padding = new Padding(10, 0, 10, 0);
            btnkelolapermintaan.Size = new Size(241, 39);
            btnkelolapermintaan.TabIndex = 2;
            btnkelolapermintaan.Text = "Ajukan Permintaan";
            btnkelolapermintaan.TextAlign = ContentAlignment.MiddleRight;
            btnkelolapermintaan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnkelolapermintaan.UseVisualStyleBackColor = true;
            btnkelolapermintaan.Click += btnkelolapermintaan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(-41, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 20);
            panel1.TabIndex = 4;
            // 
            // pnlutama
            // 
            pnlutama.Location = new Point(200, 20);
            pnlutama.Name = "pnlutama";
            pnlutama.Size = new Size(601, 429);
            pnlutama.TabIndex = 5;
            // 
            // pnlsidebar
            // 
            pnlsidebar.BackColor = Color.LightGreen;
            pnlsidebar.Controls.Add(btnlogout);
            pnlsidebar.Controls.Add(picindikator);
            pnlsidebar.Controls.Add(pictureBox1);
            pnlsidebar.Controls.Add(label1);
            pnlsidebar.Controls.Add(panel2);
            pnlsidebar.Controls.Add(btnlahan);
            pnlsidebar.Controls.Add(btnkelolapermintaan);
            pnlsidebar.Controls.Add(btnlihatstatus);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 0);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(201, 449);
            pnlsidebar.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 107, 74);
            panel2.Location = new Point(0, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 42);
            panel2.TabIndex = 6;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(50, 107, 74);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Paytone One", 11.999999F);
            btnlogout.ForeColor = Color.White;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(-8, 410);
            btnlogout.Margin = new Padding(0);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(10, 0, 10, 0);
            btnlogout.Size = new Size(209, 39);
            btnlogout.TabIndex = 3;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleRight;
            btnlogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnlihatstatus
            // 
            btnlihatstatus.FlatAppearance.BorderSize = 0;
            btnlihatstatus.FlatStyle = FlatStyle.Flat;
            btnlihatstatus.Font = new Font("Paytone One", 11.999999F);
            btnlihatstatus.ForeColor = Color.FromArgb(50, 107, 74);
            btnlihatstatus.Image = (Image)resources.GetObject("btnlihatstatus.Image");
            btnlihatstatus.Location = new Point(-20, 143);
            btnlihatstatus.Margin = new Padding(0);
            btnlihatstatus.Name = "btnlihatstatus";
            btnlihatstatus.Padding = new Padding(10, 0, 10, 0);
            btnlihatstatus.Size = new Size(261, 39);
            btnlihatstatus.TabIndex = 7;
            btnlihatstatus.Text = "Lihat Status";
            btnlihatstatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlihatstatus.UseVisualStyleBackColor = true;
            btnlihatstatus.Click += btnlihatstatus_Click;
            // 
            // HomepagePetani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(panel1);
            Controls.Add(pnlsidebar);
            Controls.Add(pnlutama);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomepagePetani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage Petani";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picindikator).EndInit();
            pnlsidebar.ResumeLayout(false);
            pnlsidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picindikator;
        private Button btnlahan;
        private Button btnkelolapermintaan;
        private Panel panel1;
        private Panel pnlutama;
        private Panel pnlsidebar;
        private Panel panel2;
        private Button btnlihatstatus;
        private Button btnlogout;
    }
}