using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59_XuLyChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string strInput = "";
        private string strInput2 = "";

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            strInput = txtInput.Text;
        }
        private void setOutput(string str)
        {
            txtOutput.Text = str;
        }
        private void btnSoKyTu_Click(object sender, EventArgs e)
        {
            setOutput(strInput.Length.ToString());
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            strInput = strInput.ToUpper();
            setOutput(strInput);
        }

        private void btnInThuong_Click(object sender, EventArgs e)
        {
            strInput = strInput.ToLower();
            setOutput(strInput);
        }

        private void btnDemKyTuHoa_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(char c in strInput)
            {
                if ((int)c >= 65 && (int)c <= 90) sum++;
            }
            setOutput(sum.ToString());
        }

        private void btnDemKyTutThuong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (char c in strInput)
            {
                if ((int)c >= 97 && (int)c <= 122) sum++;
            }
            setOutput(sum.ToString());
        }

        private void btnDemKyTuSo_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (char c in strInput)
            {
                if ((int)c >= 48 && (int)c <= 57) sum++;
            }
            setOutput(sum.ToString());
        }

        private void btnDaoChuoi_Click(object sender, EventArgs e)
        {
            string temp = "";
            for(int i = strInput.Length - 1; i >=0; i--)
            {
                temp += strInput[i];
            }
            strInput = temp;
            setOutput(strInput);
        }

        private void btnToiUuChuoi_Click(object sender, EventArgs e)
        {
            string[] arrStr = strInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            strInput = "";

            foreach (string item in arrStr)
            {
                strInput += item + " ";
            }
            strInput = strInput.Trim();
            setOutput(strInput);
        }

        private void btnTimXuatHienDau_Click(object sender, EventArgs e)
        {
            setOutput(strInput.IndexOf(strInput2).ToString());
        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {
            strInput2 = txtInput2.Text;
        }

        private void btnTimXuatHienCuoi_Click(object sender, EventArgs e)
        {
            setOutput(strInput.LastIndexOf(strInput2).ToString());
        }

        private void btnDemSoLanXuatHien_Click(object sender, EventArgs e)
        {
            string temp = strInput;
            int count = 0;
            while (temp.IndexOf(strInput2) != -1)
            {
                count++;
                temp = temp.Remove(temp.IndexOf(strInput2), strInput2.Length);
            }
            setOutput(count.ToString());
        }

        private void btnTachTu_Click(object sender, EventArgs e)
        {
            if(strInput2 == " " || strInput2 == "")
            {
                string[] arrStr = strInput.Split(' ');
                string temp = "";
                foreach(string item in arrStr)
                {
                    temp += item + "\r\n";
                }
                setOutput(temp);
            }
        }
    }
}
