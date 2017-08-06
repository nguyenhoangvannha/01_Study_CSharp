using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_HoaDonBanXe
{
    class Customer
    {
        private string name;
        public string Phone { get; set; }
        public string Address { get; set; }
        public Car Car_ { get; set; }
        public string Name { get => name; set => name = value; }
    }
}
