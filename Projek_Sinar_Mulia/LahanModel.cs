using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    class LahanModel
    {
        public int id_lahan { get; set; }
        public int id_alamat { get; set; }
        public int id_users { get; set; }
        public double luas { get; set; }
        public string blok { get; set; }
        public string jalan { get; set; }
        public int rt { get; set; }
        public int rw { get; set; }

        public string DisplayLabel => $"Blok {blok}, Jl. {jalan}, RT {rt}/RW {rw}";

    }
}
