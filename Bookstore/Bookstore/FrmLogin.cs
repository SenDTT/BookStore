using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookstore
{
    public partial class FrmLogin : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrLogin_Load(object sender, EventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Application.Exit();
        }

        private bool KiemTraSo(string user)
        {
            try
            {
                int so = Convert.ToInt32(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "") {
                MessageBox.Show("Tài khoản trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!KiemTraSo(txtuser.Text.Trim())) {
                MessageBox.Show("Tài khoản phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();
            dt = con.GetData("SELECT * FROM Nhan_Vien WHERE MaNV ='" + txtuser.Text + "' AND password ='" + txtpass.Text + "'");
            if(dt.Rows.Count != 0)
            {
                MessageBox.Show("Đăng nhập thành công","Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow dr = dt.Rows[0];
                string maCV = dr["MaCV"].ToString().Trim();
                switch (maCV)
                {
                    case "TN004":
                            Quanlybansach qlbs = new Quanlybansach();
                            this.Hide();
                            qlbs.ShowDialog();
                            this.Show();
                            break;
                    case "KK002":
                        Quanlykhosach qlks = new Quanlykhosach();
                        this.Hide();
                        qlks.ShowDialog();
                        this.Show();
                        break;
                    case "QL003":
                        Quanlycuahangsach qlch = new Quanlycuahangsach();
                        this.Hide();
                        qlch.ShowDialog();
                        this.Show();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, Vui lòng thử lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("User không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KiemTraSo(txtuser.Text.Trim()))
            {
                MessageBox.Show("User phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
