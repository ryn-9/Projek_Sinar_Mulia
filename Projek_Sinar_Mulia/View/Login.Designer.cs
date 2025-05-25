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
            label1 = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            label4 = new Label();
            lblregister = new Label();
            cbintip = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(533, 165);
            tbusername.Margin = new Padding(4, 5, 4, 5);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(271, 24);
            tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(533, 281);
            tbpassword.Margin = new Padding(4, 5, 4, 5);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(271, 24);
            tbpassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(533, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(619, 343);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 301);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 6;
            label4.Text = "Belum punya akun?";
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.Cursor = Cursors.Hand;
            lblregister.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblregister.ForeColor = Color.Indigo;
            lblregister.Location = new Point(691, 301);
            lblregister.Margin = new Padding(4, 0, 4, 0);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(117, 25);
            lblregister.TabIndex = 7;
            lblregister.Text = "Daftar di sini!";
            lblregister.Click += lblregister_Click;
            // 
            // cbintip
            // 
            cbintip.AutoSize = true;
            cbintip.Location = new Point(808, 281);
            cbintip.Name = "cbintip";
            cbintip.Size = new Size(22, 21);
            cbintip.TabIndex = 8;
            cbintip.UseVisualStyleBackColor = true;
            cbintip.CheckedChanged += cbintip_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 603);
            Controls.Add(cbintip);
            Controls.Add(lblregister);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label label4;
        private Label lblregister;
        private CheckBox cbintip;
    }
}
