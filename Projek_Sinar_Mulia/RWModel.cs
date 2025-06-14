using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class RWModel
    {
        public int id_rw { get; set; }
        public int rw { get; set; }

        public override string ToString() => $"RW {rw}";
    }
}
