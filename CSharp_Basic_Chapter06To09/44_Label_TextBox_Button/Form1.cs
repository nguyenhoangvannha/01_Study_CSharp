using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_Label_TextBox_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + tbName.Text + "\nPassword: " + tbPassword.Text, "Secret", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbPassword.Focus();
        }
    }
}
