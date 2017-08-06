namespace _55_RuntimeEvent
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnOut = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVe);
            this.panel1.Controls.Add(this.txtCot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 67);
            this.panel1.TabIndex = 0;
            // 
            // pnOut
            // 
            this.pnOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOut.Location = new System.Drawing.Point(0, 67);
            this.pnOut.Name = "pnOut";
            this.pnOut.Size = new System.Drawing.Size(530, 344);
            this.pnOut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số dòng";
            // 
            // txtDong
            // 
            this.txtDong.Location = new System.Drawing.Point(105, 24);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(90, 20);
            this.txtDong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số cột";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(288, 24);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(97, 20);
            this.txtCot.TabIndex = 3;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(431, 24);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 23);
            this.btnVe.TabIndex = 4;
            this.btnVe.Text = "Vẽ Buttons";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 411);
            this.Controls.Add(this.pnOut);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnOut;
    }
}