using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_TinhTienBanSach
{
    class QuanLyKH
    {
        private List<KhachHang> dsKH = new List<KhachHang>();
        public int SoKH { get => dsKH.Count; }
        public int SoKHSV
        {
            get
            {
                int soSv = 0;
                foreach(KhachHang kh in dsKH)
                {
                    if (kh.IsSinhVien) soSv++;
                }
                return soSv;
            }
        }
        public long TongDoanhThu
        {
            get
            {
                long sum = 0;
                foreach(KhachHang kh in dsKH)
                {
                    sum += kh.ThanhTien;
                }
                return sum;
            }
        }

        public void themKH(KhachHang kh)
        {
            dsKH.Add(kh);
        }
    }

}
