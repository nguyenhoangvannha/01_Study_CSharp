namespace _48_ListBox
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
            this.lstNumberList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDeleteFirstAndLast = new System.Windows.Forms.Button();
            this.btnDeleteSelectedItems = new System.Windows.Forms.Button();
            this.btnIncrese = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSelectEven = new System.Windows.Forms.Button();
            this.btnSelectOdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumberList
            // 
            this.lstNumberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNumberList.FormattingEnabled = true;
            this.lstNumberList.Location = new System.Drawing.Point(3, 16);
            this.lstNumberList.Name = "lstNumberList";
            this.lstNumberList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstNumberList.Size = new System.Drawing.Size(171, 216);
            this.lstNumberList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input number";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(87, 15);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(328, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNumberList);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectOdd);
            this.groupBox2.Controls.Add(this.btnSelectEven);
            this.groupBox2.Controls.Add(this.btnPow);
            this.groupBox2.Controls.Add(this.btnIncrese);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedItems);
            this.groupBox2.Controls.Add(this.btnDeleteFirstAndLast);
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Location = new System.Drawing.Point(209, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 235);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(7, 20);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(187, 23);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum of list";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnDeleteFirstAndLast
            // 
            this.btnDeleteFirstAndLast.Location = new System.Drawing.Point(7, 50);
            this.btnDeleteFirstAndLast.Name = "btnDeleteFirstAndLast";
            this.btnDeleteFirstAndLast.Size = new System.Drawing.Size(187, 23);
            this.btnDeleteFirstAndLast.TabIndex = 1;
            this.btnDeleteFirstAndLast.Text = "Delete first and last items";
            this.btnDeleteFirstAndLast.UseVisualStyleBackColor = true;
            this.btnDeleteFirstAndLast.Click += new System.EventHandler(this.btnDeleteFirstAndLast_Click);
            // 
            // btnDeleteSelectedItems
            // 
            this.btnDeleteSelectedItems.Location = new System.Drawing.Point(7, 80);
            this.btnDeleteSelectedItems.Name = "btnDeleteSelectedItems";
            this.btnDeleteSelectedItems.Size = new System.Drawing.Size(187, 23);
            this.btnDeleteSelectedItems.TabIndex = 2;
            this.btnDeleteSelectedItems.Text = "Delete selected items";
            this.btnDeleteSelectedItems.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItems.Click += new System.EventHandler(this.btnDeleteSelectedItems_Click);
            // 
            // btnIncrese
            // 
            this.btnIncrese.Location = new System.Drawing.Point(7, 110);
            this.btnIncrese.Name = "btnIncrese";
            this.btnIncrese.Size = new System.Drawing.Size(187, 23);
            this.btnIncrese.TabIndex = 3;
            this.btnIncrese.Text = "Increase each item for 2";
            this.btnIncrese.UseVisualStyleBackColor = true;
            this.btnIncrese.Click += new System.EventHandler(this.btnIncrese_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(7, 140);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(187, 23);
            this.btnPow.TabIndex = 4;
            this.btnPow.Text = "Pow items";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSelectEven
            // 
            this.btnSelectEven.Location = new System.Drawing.Point(7, 170);
            this.btnSelectEven.Name = "btnSelectEven";
            this.btnSelectEven.Size = new System.Drawing.Size(187, 23);
            this.btnSelectEven.TabIndex = 5;
            this.btnSelectEven.Text = "Select even numbers";
            this.btnSelectEven.UseVisualStyleBackColor = true;
            this.btnSelectEven.Click += new System.EventHandler(this.btnSelectEven_Click);
            // 
            // btnSelectOdd
            // 
            this.btnSelectOdd.Location = new System.Drawing.Point(7, 200);
            this.btnSelectOdd.Name = "btnSelectOdd";
            this.btnSelectOdd.Size = new System.Drawing.Size(187, 23);
            this.btnSelectOdd.TabIndex = 6;
            this.btnSelectOdd.Text = "Select odd numbers";
            this.btnSelectOdd.UseVisualStyleBackColor = true;
            this.btnSelectOdd.Click += new System.EventHandler(this.btnSelectOdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(18, 324);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(112, 23);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "Auto generate list";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 357);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumberList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectOdd;
        private System.Windows.Forms.Button btnSelectEven;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnIncrese;
        private System.Windows.Forms.Button btnDeleteSelectedItems;
        private System.Windows.Forms.Button btnDeleteFirstAndLast;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuto;
    }
}

