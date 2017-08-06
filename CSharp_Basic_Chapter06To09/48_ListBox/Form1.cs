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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            for(int i = 0; i < 12; i++)
            {
                lstNumberList.Items.Add(rd.Next(1,101));
            }
        }

        private void btnDeleteFirstAndLast_Click(object sender, EventArgs e)
        {
            if(lstNumberList.Items.Count >= 2)
            {
                lstNumberList.Items.RemoveAt(0);
                lstNumberList.Items.RemoveAt(lstNumberList.Items.Count - 1);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < lstNumberList.Items.Count; i++)
            {
                sum += (int)lstNumberList.Items[i];
            }
            MessageBox.Show(sum + "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rel = MessageBox.Show("Do you want to exist?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(rel == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDeleteSelectedItems_Click(object sender, EventArgs e)
        {
            while(lstNumberList.SelectedIndices.Count > 0)
            {
                lstNumberList.Items.RemoveAt(lstNumberList.SelectedIndex);
            }

            //for (int i = 0; i < lstNumberList.Items.Count; i++)
            //{
            //    if (lstNumberList.GetSelected(i))
            //    {
            //        lstNumberList.Items.RemoveAt(i);
            //    }
            //}


            //if(lstNumberList.SelectedIndex != -1)
            //{
            //    lstNumberList.Items.RemoveAt(lstNumberList.SelectedIndex);
            //}
        }

        private void btnIncrese_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstNumberList.Items.Count; i++)
            {
                lstNumberList.Items[i] = (int)lstNumberList.Items[i] + 2;
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumberList.Items.Count; i++)
            {
                lstNumberList.Items[i] = Math.Pow((int)lstNumberList.Items[i],2);
            }
        }

        private void btnSelectEven_Click(object sender, EventArgs e)
        {
            lstNumberList.SelectedIndex = -1;
            for (int i = 0; i < lstNumberList.Items.Count; i++)
            {
                if((int)lstNumberList.Items[i] % 2 == 0)
                {
                    lstNumberList.SelectedIndex = i;
                }
            }
        }

        private void btnSelectOdd_Click(object sender, EventArgs e)
        {
            lstNumberList.SelectedIndex = -1;
            for (int i = 0; i < lstNumberList.Items.Count; i++)
            {
                if ((int)lstNumberList.Items[i] % 2 != 0)
                {
                    lstNumberList.SelectedIndex = i;
                }
            }
        }
    }
}
