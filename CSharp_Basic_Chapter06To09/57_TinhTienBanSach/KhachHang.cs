using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_TinhTienBanSach
{
    class KhachHang
    {
        private const int GIA = 20000;
        private string name;
        private int soLuongSach = 0;
        private bool isSinhVien;
        private long thanhTien;
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int SoLuongSach { get => soLuongSach; set => soLuongSach = value; }
        public bool IsSinhVien { get => isSinhVien; set => isSinhVien = value; }
        public long ThanhTien {
            get
            {
                if (isSinhVien)
                {
                    return GIA*soLuongSach - (int)(GIA*soLuongSach * 0.05);
                }
                else return GIA * soLuongSach;
            }
        }
    }
}
