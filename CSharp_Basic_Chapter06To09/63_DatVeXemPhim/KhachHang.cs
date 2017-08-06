using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_DatVeXemPhim
{
    class KhachHang
    {
        private readonly int GIA_VE = 100000;

        public string Name { get; set; }
        public string Phone { get; set; }
        public List<int> DSGhe { get; set; }
        public int ThanhTien
        {
            get
            {
                return DSGhe.Count * GIA_VE;
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
