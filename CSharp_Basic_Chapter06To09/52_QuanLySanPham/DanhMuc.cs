using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_QuanLySanPham
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> dsSp = new Dictionary<string, SanPham>();
        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public void ThemSP(SanPham sp)
        {
            if (!dsSp.ContainsKey(sp.MaSP))
            {
                dsSp.Add(sp.MaSP, sp);
            }
        }
        public Dictionary<string,SanPham> DanhSachSP
        {
            get { return dsSp; }
            set { this.dsSp = value; }
        }
        public override string ToString()
        {
            return this.TenDM;
        }
    }
}
