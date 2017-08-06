using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isOn = false;
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (isOn)
            {
                btnChange.Text = tbName.Text + " turn off the light, please";
            }
            else
            {
                btnChange.Text = tbName.Text + " turn on the light, please";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxOn.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                picBoxOn.Visible = false;
                picBoxOff.Visible = true;
                isOn = false;
                btnChange.Text = tbName.Text + " turn on the light, please";
            }
            else
            {
                picBoxOff.Visible = false;
                picBoxOn.Visible = true;
                isOn = true;
                btnChange.Text = tbName.Text + " turn off the light, please";
            }
        }
    }
}
