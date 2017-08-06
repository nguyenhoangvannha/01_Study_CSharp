using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45_CheckBox_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Select();
            lbDevBy.ForeColor = Color.Red;
            tbName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rel =  MessageBox.Show("Thoat ?", "Thong bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rel == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            lbDevBy.Text = tbName.Text;
        }

        private void tbName_DoubleClick(object sender, EventArgs e)
        {
            tbName.ResetText();
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radGreen.Checked == true)
            {
                lbDevBy.ForeColor = radGreen.ForeColor;
                groupBox1.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lbDevBy.ForeColor = radBlue.ForeColor;
                groupBox1.ForeColor = radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
            {
                lbDevBy.ForeColor = radBlack.ForeColor;
                groupBox1.ForeColor = radBlack.ForeColor;
            }
        }

        private void cbxBold_CheckedChanged(object sender, EventArgs e)
        {
            lbDevBy.Font = new Font(lbDevBy.Font.Name, lbDevBy.Font.Size, lbDevBy.Font.Style ^ FontStyle.Bold);
        }

        private void cbxOblique_CheckedChanged(object sender, EventArgs e)
        {
            lbDevBy.Font = new Font(lbDevBy.Font.Name, lbDevBy.Font.Size, lbDevBy.Font.Style ^ FontStyle.Italic);
        }

        private void cbxUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            lbDevBy.Font = new Font(lbDevBy.Font.Name, lbDevBy.Font.Size, lbDevBy.Font.Style ^ FontStyle.Underline);
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lbDevBy.ForeColor = radRed.ForeColor;
                groupBox1.ForeColor = radRed.ForeColor;
            }
        }
    }
}
