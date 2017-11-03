namespace KH
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
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.bt4_clear = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.bt3_Sua = new System.Windows.Forms.Button();
            this.bt2_Them = new System.Windows.Forms.Button();
            this.bt1_TimKiem = new System.Windows.Forms.Button();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txt5);
            this.gb1.Controls.Add(this.txt6);
            this.gb1.Controls.Add(this.txt1);
            this.gb1.Controls.Add(this.bt4_clear);
            this.gb1.Controls.Add(this.txtNgaySinh);
            this.gb1.Controls.Add(this.cbb1);
            this.gb1.Controls.Add(this.bt3_Sua);
            this.gb1.Controls.Add(this.bt2_Them);
            this.gb1.Controls.Add(this.bt1_TimKiem);
            this.gb1.Controls.Add(this.txt7);
            this.gb1.Controls.Add(this.txt2);
            this.gb1.Controls.Add(this.lb6);
            this.gb1.Controls.Add(this.lb5);
            this.gb1.Controls.Add(this.lb4);
            this.gb1.Controls.Add(this.lb3);
            this.gb1.Controls.Add(this.lab3);
            this.gb1.Controls.Add(this.lb7);
            this.gb1.Controls.Add(this.lb2);
            this.gb1.Controls.Add(this.lb1);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(1, 1);
            this.gb1.Margin = new System.Windows.Forms.Padding(4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4);
            this.gb1.Size = new System.Drawing.Size(883, 347);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin khách hàng";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(464, 116);
            this.txt5.Name = "txt5";
            this.txt5.ShortcutsEnabled = false;
            this.txt5.Size = new System.Drawing.Size(132, 25);
            this.txt5.TabIndex = 6;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(463, 202);
            this.txt6.Name = "txt6";
            this.txt6.ShortcutsEnabled = false;
            this.txt6.Size = new System.Drawing.Size(132, 25);
            this.txt6.TabIndex = 7;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(158, 28);
            this.txt1.Name = "txt1";
            this.txt1.ShortcutsEnabled = false;
            this.txt1.Size = new System.Drawing.Size(132, 25);
            this.txt1.TabIndex = 1;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // bt4_clear
            // 
            this.bt4_clear.Location = new System.Drawing.Point(714, 294);
            this.bt4_clear.Name = "bt4_clear";
            this.bt4_clear.Size = new System.Drawing.Size(100, 28);
            this.bt4_clear.TabIndex = 11;
            this.bt4_clear.Text = "Clear";
            this.bt4_clear.UseVisualStyleBackColor = true;
            this.bt4_clear.Click += new System.EventHandler(this.bt4_clear_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(464, 25);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(181, 25);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // cbb1
            // 
            this.cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.cbb1.Location = new System.Drawing.Point(158, 291);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(132, 25);
            this.cbb1.TabIndex = 4;
            // 
            // bt3_Sua
            // 
            this.bt3_Sua.Location = new System.Drawing.Point(714, 208);
            this.bt3_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt3_Sua.Name = "bt3_Sua";
            this.bt3_Sua.Size = new System.Drawing.Size(100, 30);
            this.bt3_Sua.TabIndex = 10;
            this.bt3_Sua.Text = "Sửa";
            this.bt3_Sua.UseVisualStyleBackColor = true;
            this.bt3_Sua.Click += new System.EventHandler(this.bt3_Sua_Click);
            // 
            // bt2_Them
            // 
            this.bt2_Them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_Them.Location = new System.Drawing.Point(714, 119);
            this.bt2_Them.Margin = new System.Windows.Forms.Padding(4);
            this.bt2_Them.Name = "bt2_Them";
            this.bt2_Them.Size = new System.Drawing.Size(100, 30);
            this.bt2_Them.TabIndex = 9;
            this.bt2_Them.Text = "Thêm";
            this.bt2_Them.UseVisualStyleBackColor = true;
            this.bt2_Them.Click += new System.EventHandler(this.bt2_Them_Click);
            // 
            // bt1_TimKiem
            // 
            this.bt1_TimKiem.Location = new System.Drawing.Point(714, 31);
            this.bt1_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt1_TimKiem.Name = "bt1_TimKiem";
            this.bt1_TimKiem.Size = new System.Drawing.Size(100, 30);
            this.bt1_TimKiem.TabIndex = 8;
            this.bt1_TimKiem.Text = "Tìm kiếm";
            this.bt1_TimKiem.UseVisualStyleBackColor = true;
            this.bt1_TimKiem.Click += new System.EventHandler(this.bt1_TimKiem_Click);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(158, 207);
            this.txt7.Margin = new System.Windows.Forms.Padding(4);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(132, 25);
            this.txt7.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(158, 116);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 25);
            this.txt2.TabIndex = 2;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(363, 210);
            this.lb6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(93, 17);
            this.lb6.TabIndex = 0;
            this.lb6.Text = "Điểm tích lũy :";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(363, 119);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(43, 17);
            this.lb5.TabIndex = 0;
            this.lb5.Text = "SĐT :";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(363, 31);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(74, 17);
            this.lb4.TabIndex = 0;
            this.lb4.Text = "Ngày sinh :";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(95, 148);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 17);
            this.lb3.TabIndex = 0;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(61, 300);
            this.lab3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(64, 17);
            this.lab3.TabIndex = 0;
            this.lab3.Text = "Giới tính :";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(61, 215);
            this.lb7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(64, 17);
            this.lb7.TabIndex = 0;
            this.lb7.Text = "Tên KH :";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(61, 119);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(59, 17);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Họ KH :";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(61, 31);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(61, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã KH :";
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(65, 356);
            this.dtgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(760, 206);
            this.dtgv1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 568);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button bt3_Sua;
        private System.Windows.Forms.Button bt2_Them;
        private System.Windows.Forms.Button bt1_TimKiem;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.Button bt4_clear;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt1;
    }
}

