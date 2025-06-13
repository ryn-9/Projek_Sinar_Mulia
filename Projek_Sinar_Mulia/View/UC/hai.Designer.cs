namespace Projek_Sinar_Mulia.View.UC
{
    partial class hai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hai));
            lblhai = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblhai
            // 
            lblhai.AutoSize = true;
            lblhai.BackColor = Color.Transparent;
            lblhai.Dock = DockStyle.Left;
            lblhai.Font = new Font("Paytone One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhai.ForeColor = Color.FromArgb(50, 107, 74);
            lblhai.Location = new Point(0, 0);
            lblhai.Margin = new Padding(2, 0, 2, 0);
            lblhai.Name = "lblhai";
            lblhai.Size = new Size(426, 44);
            lblhai.TabIndex = 0;
            lblhai.Text = "Selamat Datang {Username}!";
            lblhai.Click += lblhai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Paytone One", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 107, 74);
            label1.Location = new Point(0, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 1;
            label1.Text = "di Aplikasi Sinar Mulia!";
            // 
            // hai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(label1);
            Controls.Add(lblhai);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "hai";
            Size = new Size(601, 430);
            Load += hai_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhai;
        private Label label1;
    }
}
