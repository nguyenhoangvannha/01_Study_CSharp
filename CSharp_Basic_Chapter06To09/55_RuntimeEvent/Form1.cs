using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_RuntimeEvent
{
    public partial class frmMain : Form
    {
        private Button lastest = null;
        public frmMain()
        {
            InitializeComponent();
            pnButton.FlowDirection = FlowDirection.TopDown;
            pnButton.WrapContents = false;
            pnButton.AutoScroll = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Random rd = new Random();
            btn.Text = rd.Next(0, 51).ToString();
            btn.Width = 100;
            btn.Height = 30;
            btn.Click += Btn_Click;
            pnButton.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(lastest != null)
            {
                lastest.BackColor = Color.White;
            }
            Button bt = sender as Button;
            bt.BackColor = Color.Red;
            lastest = bt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lastest != null)
            {
                pnButton.Controls.Remove(lastest);
            }
        }
    }
}
