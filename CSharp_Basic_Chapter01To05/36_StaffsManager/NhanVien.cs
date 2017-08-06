using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_StaffsManager
{
    class NhanVien
    {
        public static int SO_LUONG_NHAN_VIEN = 0;
        public NhanVien()
        {
            SO_LUONG_NHAN_VIEN++;
        }
        protected string maNV;
        protected string tenNV;
        protected string ngaySinh;
        private ChucVu chucVuNV;
        protected const int LUONG_CO_BAN = 10000000;
        protected PhongBan Phong { get; set; }
        protected enum ChucVu
        {
            GIAMDOC = 25,
            TRUONGPHONG = 15,
            PHOPHONG = 5,
            NHANVIEN = 0,
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        protected ChucVu ChucVuNV { get => chucVuNV; set => chucVuNV = value; }
        public long TinhLuong
        {
            get
            {
                long luong = 0;
                switch (chucVuNV)
                {
                    case ChucVu.GIAMDOC:
                        luong = LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.25);
                        break;
                    case ChucVu.TRUONGPHONG:
                        luong = LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.15);
                        break;
                    case ChucVu.PHOPHONG:
                        luong = LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.05);
                        break;
                    default: luong = LUONG_CO_BAN;
                        break;
                }
                return luong;
            }
        }
    }
}
