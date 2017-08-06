using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_StaffsManager
{
    class PhongBan
    {
        protected string maPB;
        protected string tenPB;
        protected NhanVien truongPB;
        protected int soLuongNhanVien = NhanVien.SO_LUONG_NHAN_VIEN;
        public string MaPB { get => maPB; set => maPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        public NhanVien TruongPB { get => truongPB; set => truongPB = value; }

    }
}
