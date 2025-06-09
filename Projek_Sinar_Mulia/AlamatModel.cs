using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Sinar_Mulia
{
    public class AlamatModel
    {
        public int id_alamat { get; set; }
        public string blok { get; set; }
        public int id_jalan { get; set; }
        public string jalan { get; set; }
        public  int rt { get; set; }
        public int rw { get; set; }

        public string DisplayLabel
        {
            get
            {
                return $"RW {rw} - RT {rt} - {jalan} Blok {blok}";
            }
        }
        public override string ToString() => $"RW {rw} - RT {rt} - {jalan} Blok {blok}";
    }
}