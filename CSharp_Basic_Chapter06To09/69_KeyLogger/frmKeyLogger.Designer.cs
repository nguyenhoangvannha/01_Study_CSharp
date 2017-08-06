namespace _69_KeyLogger
{
    partial class frmKeyLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbSymbols = new System.Windows.Forms.GroupBox();
            this.tblNumbers = new System.Windows.Forms.TableLayoutPanel();
            this.tblSymbols = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.grbSymbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOut.Location = new System.Drawing.Point(0, 146);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(434, 79);
            this.txtOut.TabIndex = 0;
            this.txtOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOut_KeyDown);
            this.txtOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOut_KeyPress);
            this.txtOut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOut_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblNumbers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các phím số";
            // 
            // grbSymbols
            // 
            this.grbSymbols.Controls.Add(this.tblSymbols);
            this.grbSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSymbols.Location = new System.Drawing.Point(0, 62);
            this.grbSymbols.Name = "grbSymbols";
            this.grbSymbols.Size = new System.Drawing.Size(434, 84);
            this.grbSymbols.TabIndex = 2;
            this.grbSymbols.TabStop = false;
            this.grbSymbols.Text = "Các ký tự";
            // 
            // tblNumbers
            // 
            this.tblNumbers.ColumnCount = 10;
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNumbers.Location = new System.Drawing.Point(3, 16);
            this.tblNumbers.Name = "tblNumbers";
            this.tblNumbers.RowCount = 1;
            this.tblNumbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNumbers.Size = new System.Drawing.Size(428, 43);
            this.tblNumbers.TabIndex = 0;
            // 
            // tblSymbols
            // 
            this.tblSymbols.ColumnCount = 13;
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSymbols.Location = new System.Drawing.Point(3, 16);
            this.tblSymbols.Name = "tblSymbols";
            this.tblSymbols.RowCount = 2;
            this.tblSymbols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSymbols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSymbols.Size = new System.Drawing.Size(428, 65);
            this.tblSymbols.TabIndex = 0;
            // 
            // frmKeyLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 225);
            this.Controls.Add(this.grbSymbols);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOut);
            this.Name = "frmKeyLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Logger";
            this.Load += new System.EventHandler(this.frmKeyLogger_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbSymbols.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbSymbols;
        private System.Windows.Forms.TableLayoutPanel tblNumbers;
        private System.Windows.Forms.TableLayoutPanel tblSymbols;
    }
}

