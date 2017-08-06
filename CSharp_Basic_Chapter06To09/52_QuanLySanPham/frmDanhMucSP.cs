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
    public partial class frmDanhMucSP : Form
    {

        private bool isChange = false;
        public frmDanhMucSP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDM = txtMaDanhMuc.Text;
            dm.TenDM = txtTenDanhMuc.Text;
            frmQuanLy.dsDM.Add(dm);
            showListBox();
            isChange = true;
        }
        public void showListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach(DanhMuc item in frmQuanLy.dsDM)
            {
                lstDanhMuc.Items.Add(item);
            }
        }

        private void btnThoatDM_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = (DanhMuc)lstDanhMuc.SelectedItem;
                txtMaDanhMuc.Text = dm.MaDM;
                txtTenDanhMuc.Text = dm.TenDM;
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if(lstDanhMuc.SelectedIndex != -1)
            {
                lstDanhMuc.Items.RemoveAt(lstDanhMuc.SelectedIndex);
                isChange = true;
            }
        }
    }
}
