using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Sinar_Mulia
{
    public partial class LihatStatusPermintaan: UserControl
    {
        public LihatStatusPermintaan()
        {
            InitializeComponent();
            LoadPermintaanIrigasi();
        }
        private void LoadPermintaanIrigasi()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=dinadin;Database=sinarmulia";

        }
    }
}
