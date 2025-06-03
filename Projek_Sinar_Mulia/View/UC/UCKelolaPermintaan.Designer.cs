namespace Projek_Sinar_Mulia.View.UC
{
    partial class UCKelolaPermintaan
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
            btnKembali = new Button();
            dataGridView1 = new DataGridView();
            btnKelolaStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(554, 622);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(236, 45);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(715, 510);
            dataGridView1.TabIndex = 2;
            // 
            // btnKelolaStatus
            // 
            btnKelolaStatus.Location = new Point(210, 622);
            btnKelolaStatus.Name = "btnKelolaStatus";
            btnKelolaStatus.Size = new Size(236, 45);
            btnKelolaStatus.TabIndex = 4;
            btnKelolaStatus.Text = "Kelola Status";
            btnKelolaStatus.UseVisualStyleBackColor = true;
            // 
            // UCKelolaPermintaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKelolaStatus);
            Controls.Add(btnKembali);
            Controls.Add(dataGridView1);
            Name = "UCKelolaPermintaan";
            Size = new Size(983, 728);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        private DataGridView dataGridView1;
        private Button btnKelolaStatus;
    }
}
