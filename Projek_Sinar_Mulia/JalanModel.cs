using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class JalanModel
    {
        public int id_jalan { get; set; }
        public string jalan { get; set; }
        public int id_rt { get; set; }
        public override string ToString() => jalan;
    }
}
