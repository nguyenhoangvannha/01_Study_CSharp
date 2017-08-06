using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52_QuanLySanPham
{
    public partial class frmQuanLy : Form
    {
        public static List<DanhMuc> dsDM = new List<DanhMuc>();
        public frmQuanLy()
        {
            InitializeComponent();
        }
        frmDanhMucSP frmDanhMuc = new frmDanhMucSP();

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc.showListBox();
            if (frmDanhMuc.ShowDialog() == DialogResult.OK)
            {
                reloadComboBoxDanhMuc();
            }
            
        }
        private void reloadComboBoxDanhMuc()
        {
            cbDanhMuc.Items.Clear();
            foreach(DanhMuc item in dsDM)
            {
                cbDanhMuc.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
