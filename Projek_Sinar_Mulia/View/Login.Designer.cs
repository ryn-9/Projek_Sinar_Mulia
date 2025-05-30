namespace Projek_Sinar_Mulia
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            lblregister = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            cbintip = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Libre Bodoni", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(407, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.Gainsboro;
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(313, 114);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(259, 14);
            tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.Gainsboro;
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Arial Rounded MT Bold", 9F);
            tbpassword.Location = new Point(313, 184);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(259, 14);
            tbpassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Dubai", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(326, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(213, 31);
            btnLogin.TabIndex = 5;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(328, 365);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Belum punya akun?";
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.BackColor = Color.Transparent;
            lblregister.Cursor = Cursors.Hand;
            lblregister.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblregister.ForeColor = Color.LimeGreen;
            lblregister.Location = new Point(448, 365);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(89, 15);
            lblregister.TabIndex = 7;
            lblregister.Text = "Daftar di sini!";
            lblregister.Click += lblregister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 107);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(304, 178);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(273, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(278, 110);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(278, 181);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // cbintip
            // 
            cbintip.AutoSize = true;
            cbintip.BackColor = Color.Transparent;
            cbintip.Location = new Point(582, 186);
            cbintip.Margin = new Padding(2);
            cbintip.Name = "cbintip";
            cbintip.Size = new Size(15, 14);
            cbintip.TabIndex = 13;
            cbintip.UseVisualStyleBackColor = false;
            cbintip.CheckedChanged += cbintip_CheckedChanged_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 449);
            Controls.Add(cbintip);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(lblregister);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button btnLogin;
        private Label label4;
        private Label lblregister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private CheckBox cbintip;
    }
}
