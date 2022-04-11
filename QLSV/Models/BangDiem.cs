using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    internal class BangDiem
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        //public int MaMH { get; set; }
        public string TenMH { get; set; }
        public Double DiemQT { get; set; }
        public Double DiemTP { get; set; }
        public double DTK { get; set; }
        public float DTB { get; set; }
        public string HocLuc { get; set; }
    }
}
