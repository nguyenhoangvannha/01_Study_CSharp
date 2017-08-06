using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_QuanLySanPham
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { set; get; }
        public long DonGia { get; set; }
        public string XuatSu { get; set; }
        public DateTime HanDung { get; set; }
        public DanhMuc NhomDM { get; set; }

        public override string ToString()
        {
            return this.TenSP;
        }
    }
}
