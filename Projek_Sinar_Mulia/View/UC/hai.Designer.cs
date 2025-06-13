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
            lblhai.Font = new Font("Paytone One", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhai.ForeColor = Color.FromArgb(50, 107, 74);
            lblhai.Location = new Point(26, 39);
            lblhai.Name = "lblhai";
            lblhai.Size = new Size(820, 85);
            lblhai.TabIndex = 0;
            lblhai.Text = "Selamat Datang {Username}!";
            lblhai.Click += lblhai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 107, 74);
            label1.Location = new Point(178, 115);
            label1.Name = "label1";
            label1.Size = new Size(401, 52);
            label1.TabIndex = 1;
            label1.Text = "Di Aplikasi Sinar Mulia!";
            // 
            // hai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(label1);
            Controls.Add(lblhai);
            DoubleBuffered = true;
            Name = "hai";
            Size = new Size(859, 715);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhai;
        private Label label1;
    }
}
