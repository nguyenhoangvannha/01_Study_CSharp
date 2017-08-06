using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69_KeyLogger
{
    public partial class frmKeyLogger : Form
    {
        public frmKeyLogger()
        {
            InitializeComponent();
        }

        private void frmKeyLogger_Load(object sender, EventArgs e)
        {
            setNumbers();
            setSymbols();
        }

        private void setNumbers()
        {
            for(int i = 0; i < tblNumbers.ColumnCount; i++)
            {
                Label lb = new Label();
                lb.Text = i.ToString();
                lb.BorderStyle = BorderStyle.Fixed3D;
                lb.Dock = DockStyle.Fill;
                lb.BackColor = Color.White;
                lb.ForeColor = Color.Black;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                tblNumbers.Controls.Add(lb, i, 0);
            }
        }
        private void setSymbols()
        {
            for(int i = 0; i < tblSymbols.RowCount; i++)
            {
                for(int j = 0; j < tblSymbols.ColumnCount; j++)
                {
                    Label lb = new Label();
                    lb.Text = (char)(j + i*13 + 65) + "";
                    lb.BorderStyle = BorderStyle.Fixed3D;
                    lb.Dock = DockStyle.Fill;
                    lb.BackColor = Color.White;
                    lb.ForeColor = Color.Black;
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    tblSymbols.Controls.Add(lb, j, i + 1);
                }
            }
        }
        private void txtOut_KeyDown(object sender, KeyEventArgs e)
        {
            //textBox1.Text = "";
            //textBox1.Text += "KeyData: " + e.KeyData; //Chu cai
            //textBox1.Text += "\nKeyCode: " + e.KeyCode; //Chu cai
            //textBox1.Text += "\nKeyValue: " + e.KeyValue; //So
            for(int i = 0; i < tblSymbols.Controls.Count; i++)
            {
                if(tblSymbols.Controls[i].Text == e.KeyData.ToString())
                {
                    tblSymbols.Controls[i].ForeColor = Color.Red;
                    tblSymbols.Controls[i].BackColor = Color.YellowGreen;
                }
            }
            for(int i = 0; i < tblNumbers.Controls.Count; i++)
            {
                if (tblNumbers.Controls[i].Text == e.KeyData.ToString())
                {
                    tblNumbers.Controls[i].ForeColor = Color.Red;
                    tblNumbers.Controls[i].BackColor = Color.YellowGreen;
                }
            }
        }

        private void txtOut_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < tblSymbols.Controls.Count; i++)
            {
                if (tblSymbols.Controls[i].Text == e.KeyData.ToString())
                {
                    tblSymbols.Controls[i].ForeColor = Color.Black;
                    tblSymbols.Controls[i].BackColor = Color.White;
                }
            }
            for (int i = 0; i < tblNumbers.Controls.Count; i++)
            {
                if (tblNumbers.Controls[i].Text == e.KeyData.ToString())
                {
                    tblNumbers.Controls[i].ForeColor = Color.Black;
                    tblNumbers.Controls[i].BackColor = Color.White;
                }
            }
        }

        private void txtOut_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
