using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_TinhTienBanSach
{
    public partial class frmMain : Form
    {
        private QuanLyKH quanLy = new QuanLyKH();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Name = txtTenKH.Text;
            kh.SoLuongSach = int.Parse(txtSoLuongSach.Text);
            if (chkSinhVien.Checked)
            {
                kh.IsSinhVien = true;
            }
            else kh.IsSinhVien = false;
            quanLy.themKH(kh);
            lbThanhTien.Text = kh.ThanhTien + "";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongSoKH.Text = quanLy.SoKH.ToString();
            txtTongSoKHSV.Text = quanLy.SoKHSV.ToString();
            txtTongDoanhThu.Text = quanLy.TongDoanhThu.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Ban co thuc su muon thoat?", "Xac nhan.", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSoLuongSach.Text = "";
            lbThanhTien.Text = "";
            txtTenKH.Focus();
        }
    }
}
