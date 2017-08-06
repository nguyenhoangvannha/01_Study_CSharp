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
    public partial class Form2 : Form
    {
        private Button[,] arrButton= null;
        private Button lastest = null;
        public Form2()
        {
            InitializeComponent();
            pnOut.AutoScroll = true;
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            int dong = int.Parse(txtDong.Text);
            int cot = int.Parse(txtCot.Text);
            arrButton = new Button[dong, cot];
            pnOut.Controls.Clear();
            Random rd = new Random();
            for(int i = 0; i < dong; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    Button bt = new Button();
                    bt.Width = 50;
                    bt.Height = 30;
                    bt.Text = rd.Next(0, 51) + "";
                    bt.Location = new Point(j * bt.Width, i * bt.Height);
                    bt.BackColor = Color.Aqua;
                    bt.Click += Bt_Click;
                    arrButton[i, j] = bt;
                    pnOut.Controls.Add(arrButton[i, j]);
                }
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            if(lastest != null)
            {
                DoiMau(lastest, Color.Aqua);
            }
            Button bt = sender as Button;
            bt.BackColor = Color.GreenYellow;
            lastest = bt;
        }

        private void DoiMau(Button lastest, Color aqua)
        {
            lastest.BackColor = aqua;
        }
    }
}
