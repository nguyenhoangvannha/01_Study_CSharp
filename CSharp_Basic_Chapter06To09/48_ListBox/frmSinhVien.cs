using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_ListBox
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(int.Parse(txtID.Text), txtName.Text);
            lstSV.Items.Add(sv);
        }

        private void lstSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSV.SelectedIndex != -1)
            {
                SinhVien sv = (SinhVien)lstSV.SelectedItem;
                txtName.Text = sv.Name;
                txtID.Text = sv.ID + "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
