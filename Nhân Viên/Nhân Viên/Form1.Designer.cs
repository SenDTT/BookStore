namespace Nhân_Viên
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txt8 = new System.Windows.Forms.ComboBox();
            this.txt10 = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txt8);
            this.gb1.Controls.Add(this.txt10);
            this.gb1.Controls.Add(this.txtNgaySinh);
            this.gb1.Controls.Add(this.txt7);
            this.gb1.Controls.Add(this.txt6);
            this.gb1.Controls.Add(this.txt1);
            this.gb1.Controls.Add(this.cbb1);
            this.gb1.Controls.Add(this.bt5);
            this.gb1.Controls.Add(this.bt4);
            this.gb1.Controls.Add(this.bt3);
            this.gb1.Controls.Add(this.bt2);
            this.gb1.Controls.Add(this.bt1);
            this.gb1.Controls.Add(this.txt9);
            this.gb1.Controls.Add(this.txt5);
            this.gb1.Controls.Add(this.txt4);
            this.gb1.Controls.Add(this.txt3);
            this.gb1.Controls.Add(this.txt2);
            this.gb1.Controls.Add(this.lb6);
            this.gb1.Controls.Add(this.lb5);
            this.gb1.Controls.Add(this.lb4);
            this.gb1.Controls.Add(this.lb3);
            this.gb1.Controls.Add(this.lb12);
            this.gb1.Controls.Add(this.lb11);
            this.gb1.Controls.Add(this.lb10);
            this.gb1.Controls.Add(this.lb9);
            this.gb1.Controls.Add(this.lb8);
            this.gb1.Controls.Add(this.lb2);
            this.gb1.Controls.Add(this.lb7);
            this.gb1.Controls.Add(this.lb1);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(1, 0);
            this.gb1.Margin = new System.Windows.Forms.Padding(4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4);
            this.gb1.Size = new System.Drawing.Size(1436, 393);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin nhân viên";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // txt8
            // 
            this.txt8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt8.FormattingEnabled = true;
            this.txt8.Items.AddRange(new object[] {
            "TN004     ",
            "BH000     ",
            "BV001     ",
            "KK002     ",
            "QL003     "});
            this.txt8.Location = new System.Drawing.Point(561, 205);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(132, 25);
            this.txt8.TabIndex = 18;
            // 
            // txt10
            // 
            this.txt10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt10.FormattingEnabled = true;
            this.txt10.Items.AddRange(new object[] {
            "BH000     ",
            "BH001     ",
            "BV000     ",
            "BV001     ",
            "KK000     ",
            "KK001     ",
            "QL000     ",
            "QL001     ",
            "TN000     ",
            "TN001     "});
            this.txt10.Location = new System.Drawing.Point(561, 324);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(132, 25);
            this.txt10.TabIndex = 12;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(148, 271);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(181, 25);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(561, 143);
            this.txt7.Name = "txt7";
            this.txt7.ShortcutsEnabled = false;
            this.txt7.Size = new System.Drawing.Size(132, 25);
            this.txt7.TabIndex = 9;
            this.txt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(561, 87);
            this.txt6.Name = "txt6";
            this.txt6.ShortcutsEnabled = false;
            this.txt6.Size = new System.Drawing.Size(132, 25);
            this.txt6.TabIndex = 8;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(148, 32);
            this.txt1.Name = "txt1";
            this.txt1.ShortcutsEnabled = false;
            this.txt1.Size = new System.Drawing.Size(132, 25);
            this.txt1.TabIndex = 1;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // cbb1
            // 
            this.cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.cbb1.Location = new System.Drawing.Point(148, 205);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(132, 25);
            this.cbb1.TabIndex = 4;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(827, 341);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(100, 28);
            this.bt5.TabIndex = 17;
            this.bt5.Text = "Clear";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(827, 263);
            this.bt4.Margin = new System.Windows.Forms.Padding(4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(100, 30);
            this.bt4.TabIndex = 16;
            this.bt4.Text = "Sửa";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(827, 182);
            this.bt3.Margin = new System.Windows.Forms.Padding(4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(100, 30);
            this.bt3.TabIndex = 15;
            this.bt3.Text = "Xóa";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(827, 108);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(100, 30);
            this.bt2.TabIndex = 14;
            this.bt2.Text = "Thêm";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(827, 27);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(100, 30);
            this.bt1.TabIndex = 13;
            this.bt1.Text = "Tìm kiếm";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(561, 260);
            this.txt9.Margin = new System.Windows.Forms.Padding(4);
            this.txt9.Name = "txt9";
            this.txt9.PasswordChar = '*';
            this.txt9.Size = new System.Drawing.Size(132, 25);
            this.txt9.TabIndex = 11;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(561, 32);
            this.txt5.Margin = new System.Windows.Forms.Padding(4);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(132, 25);
            this.txt5.TabIndex = 7;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(148, 332);
            this.txt4.Margin = new System.Windows.Forms.Padding(4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(132, 25);
            this.txt4.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(148, 151);
            this.txt3.Margin = new System.Windows.Forms.Padding(4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(132, 25);
            this.txt3.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(148, 92);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 25);
            this.txt2.TabIndex = 2;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(37, 341);
            this.lb6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(72, 17);
            this.lb6.TabIndex = 0;
            this.lb6.Text = "Quê quán :";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(37, 277);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(74, 17);
            this.lb5.TabIndex = 0;
            this.lb5.Text = "Ngày sinh :";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(37, 214);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(64, 17);
            this.lb4.TabIndex = 0;
            this.lb4.Text = "Giới tính :";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(37, 157);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(64, 17);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "Tên NV :";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(432, 327);
            this.lb12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(72, 17);
            this.lb12.TabIndex = 0;
            this.lb12.Text = "Mã lương :";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Location = new System.Drawing.Point(432, 268);
            this.lb11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(73, 17);
            this.lb11.TabIndex = 0;
            this.lb11.Text = "Password :";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Location = new System.Drawing.Point(432, 208);
            this.lb10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(60, 17);
            this.lb10.TabIndex = 0;
            this.lb10.Text = "Mã CV :";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(432, 151);
            this.lb9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(43, 17);
            this.lb9.TabIndex = 0;
            this.lb9.Text = "SĐT :";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(432, 95);
            this.lb8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(60, 17);
            this.lb8.TabIndex = 0;
            this.lb8.Text = "CMND :";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(37, 99);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(59, 17);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Họ NV :";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(432, 40);
            this.lb7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(57, 17);
            this.lb7.TabIndex = 0;
            this.lb7.Text = "Địa chỉ :";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(37, 42);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(61, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã NV :";
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(1, 391);
            this.dtgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(1006, 310);
            this.dtgv1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 702);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.ComboBox txt10;
        private System.Windows.Forms.ComboBox txt8;
    }
}

