using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _68_GameCaro
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            veGame();
        }

        private void frmGame_ResizeEnd(object sender, EventArgs e)
        {
            veGame();
        }
        private void veGame()
        {
            tblGame.Controls.Clear();
            //Tao Label 10x10
            int width = tblGame.Width;
            int height = tblGame.Height;
            int nRow = height / 10;
            int nColum = width / 10;
            Console.WriteLine(
                "\nwight " + width + 
                "\nheight" + height +
                "\nnrow" + nRow +
                "\nncolum" + nColum
                );
            tblGame.ColumnCount = nColum;
            tblGame.RowCount = nRow;
            for(int i = 0; i < nColum; i++)
            {
                tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            }
            for (int i = 0; i < nRow; i++)
            {
                tblGame.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            }

            for (int i = 0; i < nRow; i++)
            {
                for(int j = 0; j < nColum; j++)
                {
                    Label lb = new Label();
                    lb.Width = lb.Height = 10;
                    lb.BorderStyle = BorderStyle.Fixed3D;
                    lb.BackColor = Color.AliceBlue;
                    tblGame.Controls.Add(lb, j, i);
                }
            }
        }
    }
}
