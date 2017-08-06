using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da nhap " + tbInput.Text, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rel = MessageBox.Show("Ban co muon thoat khong?", "Thong bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rel == DialogResult.Yes) { e.Cancel = false; }
            else{
                e.Cancel = true;
                this.BackColor = Color.DarkRed;
            }
        }
    }
}
