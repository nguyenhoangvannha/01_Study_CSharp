using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _66_GiaoDienXuLyMang
{
    public partial class Form1 : Form
    {
        private int[] arrInt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int soPT = rd.Next(10, 20);
            arrInt = new int[soPT];
            for(int i = 0; i < soPT; i++)
            {
                arrInt[i] = rd.Next(1, 100);
            }
            hienMang(arrInt, txtMang);
        }
        private void hienMang(int[] M,TextBox txt)
        {
            txtMang.Text = "";
            for(int i = 0; i < M.Length; i++)
            {
                txtMang.Text += M[i].ToString() + " "; 
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i< arrInt.Length; i++)
            {
                sum += arrInt[i];
            }
            txtKetQua.Text = sum.ToString();
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] % 2 != 0) sum++;
            }
            txtKetQua.Text = sum.ToString();
        }

        private void btnTongSoLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] % 2 != 0) sum+= arrInt[i];
            }
            txtKetQua.Text = sum.ToString();
        }

        private void btnTimPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = arrInt.Min().ToString();
        }

        private void btnTangLenHai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = arrInt[i] + 2;
            }
            hienMang(arrInt, txtKetQua);
        }

        private void btnXepTang_Click(object sender, EventArgs e)
        {
            Array.Sort(arrInt);
            hienMang(arrInt, txtKetQua);
        }

        private void btnXepGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(arrInt);
            Array.Reverse(arrInt);
            hienMang(arrInt, txtKetQua);
        }
    }
}
