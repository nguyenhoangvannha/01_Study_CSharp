using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _67_HoaDonBanXe
{
    public partial class Form1 : Form
    {
        private List<Customer> customerList = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            txtName.Focus();
            rdOther.Select();
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCost.Text = "";
            txtPhuThu.Text = "0 %";
            txtThue.Text = Car.THUE.ToString() + " %";
            txtPrice.Text = "0";
            txtTongKH.Text = customerList.Count.ToString();

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            Customer ctm = new Customer();
            errorProvider1.Clear();
            if (!nhapKH(ctm)) return;
            Car car = new Car();
            if(!nhapXe(car)) return ;
            else ctm.Car_ = car;
            txtPrice.Text = ctm.Car_.Price + " VND";
            customerList.Add(ctm);
        }
        private bool nhapKH(Customer ctm)
        {
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Ten khach hang khong duoc de trong");
                return false;
            }
            else
            {
                ctm.Name = txtName.Text;
            }
            if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "Dia chi khach hang khong duoc de trong");
                return false;
            }
            else
            {
                ctm.Address = txtAddress.Text;
            }
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "So dien thoai khach hang khong duoc de trong");
                return false;
            }
            else
            {
                ctm.Phone = txtPhone.Text;
            }
            return true;
        }
        private bool nhapXe(Car car)
        {
            int cost = 0;
            if(!int.TryParse(txtCost.Text, out cost) || txtCost.Text == "")
            {
                errorProvider1.SetError(txtCost, "Nhap sai so tien!");
                return false;
            } else
            {
                car.Cost = cost;
            }
            if (rdBlack.Checked) car.CarColor = "Black";
            if (rdOther.Checked) car.CarColor = "Other";
            return true;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(rdBlack.Checked) txtPhuThu.Text = Car.PHU_THU_XE_DEN + " %";
        }

        private void rdOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOther.Checked) txtPhuThu.Text = "0 %";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            
            txtTongKH.Text = customerList.Count.ToString();
            int soKHD = 0;
            long doanhThu = 0;
            for(int i = 0; i < customerList.Count; i++)
            {
                doanhThu += customerList[i].Car_.Price;
                if (customerList[i].Car_.CarColor == "Black") soKHD++;
            }
            txtTongKHD.Text = soKHD.ToString();
            txtTongThu.Text = doanhThu.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thoat chuong trinh?","Xac nhan.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
