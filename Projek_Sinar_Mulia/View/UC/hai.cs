using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projek_Sinar_Mulia.View.UC
{
    public partial class hai : UserControl
    {
        public hai(string username)
        {
            InitializeComponent();
            lblhai.Text = $"Selamat Datang {username},";
            lblhai.Location = new Point(26, 39);
        }

        private void lblhai_Click(object sender, EventArgs e)
        {

        }

        private void hai_Load(object sender, EventArgs e)
        {

        }
    }
}
