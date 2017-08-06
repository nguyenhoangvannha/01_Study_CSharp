using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Interface
{
    class SinhVien : LamViec
    {
        public void lamViec(string tenViec)
        {
            Console.WriteLine("Sinh vien lam " + tenViec);
            throw new NotImplementedException();
        }
    }
}
