using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(12, "hELLO");
            foreach(KeyValuePair<int,string> item in dic)
            {
                int key = item.Key;
                string value = item.Value;
            }
            dic.ContainsKey(12); // kiem tra xem co ton tai key chua
            string name = dic[12];
            dic.Count();
            dic.Remove(12);
            dic.Clear();
            List<string> dsGiaTri = dic.Values.ToList<string>();
            List<int> dskey = dic.Keys.ToList();

        }
    }
}
