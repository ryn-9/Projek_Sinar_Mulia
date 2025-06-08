using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class RTModel
    {
        public int id_rt { get; set; }
        public int rt { get; set; }
        public int id_rw { get; set; }
        public override string ToString() => $"RT {rt}";
    }
}
