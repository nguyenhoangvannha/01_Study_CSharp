using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_ListBox
{
    class SinhVien
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public override string ToString()
        {
            return "ID: " + this.ID + "\tName: " + this.Name;
        }
        public SinhVien(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
