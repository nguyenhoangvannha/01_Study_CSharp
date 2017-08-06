namespace _66_GiaoDienXuLyMang
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnTimPhanTuNhoNhat = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.btnTangLenHai = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnXepTang = new System.Windows.Forms.Button();
            this.btnTongSoLe = new System.Windows.Forms.Button();
            this.btnXepGiam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng";
            // 
            // txtMang
            // 
            this.txtMang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMang.Location = new System.Drawing.Point(3, 16);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(664, 20);
            this.txtMang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Location = new System.Drawing.Point(3, 16);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(664, 20);
            this.txtKetQua.TabIndex = 0;
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(13, 125);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(252, 23);
            this.btnXuatMang.TabIndex = 2;
            this.btnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnTimPhanTuNhoNhat
            // 
            this.btnTimPhanTuNhoNhat.Location = new System.Drawing.Point(406, 125);
            this.btnTimPhanTuNhoNhat.Name = "btnTimPhanTuNhoNhat";
            this.btnTimPhanTuNhoNhat.Size = new System.Drawing.Size(252, 23);
            this.btnTimPhanTuNhoNhat.TabIndex = 2;
            this.btnTimPhanTuNhoNhat.Text = "Tìm phần tử nhỏ nhất";
            this.btnTimPhanTuNhoNhat.UseVisualStyleBackColor = true;
            this.btnTimPhanTuNhoNhat.Click += new System.EventHandler(this.btnTimPhanTuNhoNhat_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.Location = new System.Drawing.Point(13, 172);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(252, 23);
            this.btnTongMang.TabIndex = 2;
            this.btnTongMang.Text = "Tổng các giá trị của mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnTangLenHai
            // 
            this.btnTangLenHai.Location = new System.Drawing.Point(406, 172);
            this.btnTangLenHai.Name = "btnTangLenHai";
            this.btnTangLenHai.Size = new System.Drawing.Size(252, 23);
            this.btnTangLenHai.TabIndex = 2;
            this.btnTangLenHai.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLenHai.UseVisualStyleBackColor = true;
            this.btnTangLenHai.Click += new System.EventHandler(this.btnTangLenHai_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Location = new System.Drawing.Point(13, 224);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(252, 23);
            this.btnDemSoLe.TabIndex = 2;
            this.btnDemSoLe.Text = "Đếm số phần tử lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnXepTang
            // 
            this.btnXepTang.Location = new System.Drawing.Point(406, 224);
            this.btnXepTang.Name = "btnXepTang";
            this.btnXepTang.Size = new System.Drawing.Size(252, 23);
            this.btnXepTang.TabIndex = 2;
            this.btnXepTang.Text = "Sắp xếp tăng dần";
            this.btnXepTang.UseVisualStyleBackColor = true;
            this.btnXepTang.Click += new System.EventHandler(this.btnXepTang_Click);
            // 
            // btnTongSoLe
            // 
            this.btnTongSoLe.Location = new System.Drawing.Point(13, 271);
            this.btnTongSoLe.Name = "btnTongSoLe";
            this.btnTongSoLe.Size = new System.Drawing.Size(252, 23);
            this.btnTongSoLe.TabIndex = 2;
            this.btnTongSoLe.Text = "Tổng các phần tử lẻ";
            this.btnTongSoLe.UseVisualStyleBackColor = true;
            this.btnTongSoLe.Click += new System.EventHandler(this.btnTongSoLe_Click);
            // 
            // btnXepGiam
            // 
            this.btnXepGiam.Location = new System.Drawing.Point(406, 271);
            this.btnXepGiam.Name = "btnXepGiam";
            this.btnXepGiam.Size = new System.Drawing.Size(252, 23);
            this.btnXepGiam.TabIndex = 2;
            this.btnXepGiam.Text = "Sắp xếp giảm dần";
            this.btnXepGiam.UseVisualStyleBackColor = true;
            this.btnXepGiam.Click += new System.EventHandler(this.btnXepGiam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 319);
            this.Controls.Add(this.btnXepGiam);
            this.Controls.Add(this.btnTongSoLe);
            this.Controls.Add(this.btnTangLenHai);
            this.Controls.Add(this.btnXepTang);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnTimPhanTuNhoNhat);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý mảng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnTimPhanTuNhoNhat;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.Button btnTangLenHai;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button btnXepTang;
        private System.Windows.Forms.Button btnTongSoLe;
        private System.Windows.Forms.Button btnXepGiam;
    }
}

