using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dictionary
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo { get => tuSo; set => tuSo = value; }
        public static PhanSo operator +(PhanSo b)
        {
            return new PhanSo();
        }
    }
}
