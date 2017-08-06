using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63_DatVeXemPhim
{
    public partial class Form1 : Form
    {
        List<KhachHang> dsKH = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmThongTinDatve frmTTKH = new frmThongTinDatve();
            if(frmTTKH.ShowDialog() == DialogResult.OK)
            {
                //Yellow : choosed
                //White: unchoosed
                //GreenYellow: Choosing
                KhachHang kh = new KhachHang();
                List<int> dsGhe = new List<int>();
                for(int i = 0; i < tbChoNgoi.Controls.Count; i++)
                {
                    Label lb = tbChoNgoi.Controls[i] as Label;
                    if(lb.BackColor == Color.GreenYellow)
                    {
                        lb.BackColor = Color.Yellow;
                        dsGhe.Add(i + 1);
                    }
                }
                kh.DSGhe = dsGhe;
                kh.Name = frmTTKH.txtHoTen.Text;
                kh.Phone = frmTTKH.txtSoDienThoai.Text;
                lbThanhTien.Text = kh.ThanhTien.ToString();
                dsKH.Add(kh);
                hienTongTien();
                lstKhacHang.Items.Add(kh);
            }
        }

        private void hienTongTien()
        {
            int sum = 0;
            foreach(KhachHang kh in dsKH)
            {
                sum += kh.ThanhTien;
            }
            lbTongThanhTien.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veGhe();
        }

        private void veGhe()
        {
            int soGhe = 1;
            for(int i = 0; i < tbChoNgoi.RowCount; i++)
            {
                for(int j = 0; j < tbChoNgoi.ColumnCount; j++)
                {
                    Label ghe = new Label();
                    ghe.Text = soGhe + "";
                    ghe.AutoSize = false;
                    ghe.Dock = DockStyle.Fill;
                    ghe.TextAlign = ContentAlignment.MiddleCenter;
                    ghe.BackColor = Color.White;
                    ghe.Click += Ghe_Click;
                    tbChoNgoi.Controls.Add(ghe, j, i);
                    soGhe++;
                }
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Label ghe = (Label)sender;
            if(ghe.BackColor== Color.Yellow)
            {
                MessageBox.Show("Ghe da duoc dat boi nguoi khac");
                return;
            }
            if(ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.GreenYellow;
                return;
            }

            if (ghe.BackColor == Color.GreenYellow)
            {
                ghe.BackColor = Color.White;
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstKhacHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKhacHang.SelectedIndex != -1)
            {
                KhachHang kh = lstKhacHang.SelectedItem as KhachHang;
                lbThanhTien.Text = kh.ThanhTien.ToString();
            }
        }
    }
}
