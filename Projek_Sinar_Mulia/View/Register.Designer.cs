namespace Projek_Sinar_Mulia
{
    partial class Register
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
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            label1 = new Label();
            label5 = new Label();
            tbvalidasi = new TextBox();
            cbintip1 = new CheckBox();
            cbintip2 = new CheckBox();
            btnkembali = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(697, 339);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(533, 220);
            tbpassword.Margin = new Padding(4, 5, 4, 5);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(271, 24);
            tbpassword.TabIndex = 10;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(533, 165);
            tbusername.Margin = new Padding(4, 5, 4, 5);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(271, 24);
            tbusername.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 8;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 251);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 15;
            label5.Text = "Ulangi Password";
            label5.Click += label5_Click;
            // 
            // tbvalidasi
            // 
            tbvalidasi.BorderStyle = BorderStyle.None;
            tbvalidasi.Location = new Point(533, 281);
            tbvalidasi.Margin = new Padding(4, 5, 4, 5);
            tbvalidasi.Name = "tbvalidasi";
            tbvalidasi.Size = new Size(271, 24);
            tbvalidasi.TabIndex = 14;
            tbvalidasi.TextChanged += tbvalidasi_TextChanged;
            // 
            // cbintip1
            // 
            cbintip1.AutoSize = true;
            cbintip1.Location = new Point(808, 222);
            cbintip1.Name = "cbintip1";
            cbintip1.Size = new Size(22, 21);
            cbintip1.TabIndex = 16;
            cbintip1.UseVisualStyleBackColor = true;
            cbintip1.CheckedChanged += cbintip1_CheckedChanged;
            // 
            // cbintip2
            // 
            cbintip2.AutoSize = true;
            cbintip2.Location = new Point(808, 281);
            cbintip2.Name = "cbintip2";
            cbintip2.Size = new Size(22, 21);
            cbintip2.TabIndex = 17;
            cbintip2.UseVisualStyleBackColor = true;
            cbintip2.CheckedChanged += cbintip2_CheckedChanged;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(530, 339);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(107, 38);
            btnkembali.TabIndex = 18;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 603);
            Controls.Add(btnkembali);
            Controls.Add(cbintip2);
            Controls.Add(cbintip1);
            Controls.Add(label5);
            Controls.Add(tbvalidasi);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblregister;
        private Label label4;
        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Label label1;
        private Label label5;
        private TextBox tbvalidasi;
        private CheckBox cbintip1;
        private CheckBox cbintip2;
        private Button btnkembali;
    }
}