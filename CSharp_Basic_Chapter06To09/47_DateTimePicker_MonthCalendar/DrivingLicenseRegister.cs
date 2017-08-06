using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_DateTimePicker_MonthCalendar
{
    public partial class DrivingLicenseRegister : Form
    {
        public DrivingLicenseRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Ten khong duoc de trong.");
                return;
            }
            byte tuoi = 0;
            if (!byte.TryParse(txtAges.Text, out tuoi))
            {
                errorProvider1.SetError(txtAges, "Tuoi khong hop le.");
                return;
            }
            else if (tuoi < 18)
            {
                errorProvider1.SetError(txtAges, "Tuoi phai lon hon 17");
                return;
            }
            if(dtpTestDate.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpTestDate, "Khong duoc dang ky vao ngay chu nhat");
                return;
            }
        }
    }
}
