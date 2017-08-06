using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Class
{
    class Student
    {
#region cac  bien khoi tao
        private int iD;
        private string name;
        public Student()
        {
            this.ID = 000;
            this.Name = "Null";
        }
        public Student(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        #endregion
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
