using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace frmQuanLiBanSach
{
    public partial class ChiTietHoaDon : Form
    {
        SqlConnection cn = null;
        double tongTien;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["BOOKSTOREconnectionStrings"].ConnectionString;
            cn = new SqlConnection(cnStr); 
            loadItemFromDB();
            btLuuHD.Enabled = false;
            btXoaHD.Enabled = false;
            btThemHD.Enabled = true;
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DisConnect()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        private void loadItemFromDB()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string sql = "SELECT MaSach, TenSach FROM Sach";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            cbMaSach.DataSource = dt;
            cbMaSach.DisplayMember = "MaSach";
            cbMaSach.ValueMember = "TenSach";
            txtTenSach.Text = cbMaSach.SelectedValue.ToString();
            if (cbMaSach.Items.Count > 0)
            {
                cbMaSach.SelectedIndex = 0;
            }
            cbMaSach.SelectedIndexChanged += new EventHandler(cbMaSach_SelectedIndexChanged);
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSach.Text = cbMaSach.SelectedValue.ToString();
            cbMaSach.Text = cbMaSach.DisplayMember;
        }

        private double TongTien()
        {
            tongTien = 0;
            for (int i = 0; i < dgvMatHang.Rows.Count - 1; i++)
            {
                tongTien += double.Parse(dgvMatHang.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            return tongTien;
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            if (txtDonBan.Text != "" && txtSoLuong.Text != "" && txtThue.Text != "")
            {
                double a = double.Parse(txtDonBan.Text);
                double b = double.Parse(txtSoLuong.Text);
                double c = a * b;
                txtThanhTien.Text = c.ToString();
                dgvMatHang.Rows.Add(cbMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonBan.Text), int.Parse(txtThue.Text), double.Parse(txtThanhTien.Text));
                txtTongTien.Text = TongTien().ToString(); 
            }
            else
            {
                if(txtDonBan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đơn giá");
                }
                else if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                }
                else if (txtThue.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thuế");
                }
            }
            btLuuHD.Enabled = true;
            btXoaHD.Enabled = true;
            btThemHD.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaNV.Enabled = true;
            dtpNgayBan.Enabled = true;
        }

        private void btXoaHD_Click_1(object sender, EventArgs e)
        {
            Connect();
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                
                try
                {
                    foreach (DataGridViewRow row in dgvMatHang.SelectedRows)
                    {
                        dgvMatHang.Rows.Remove(row);
                    }
                    MessageBox.Show("Xoa thanh cong");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            btLuuHD.Enabled = true;
            btXoaHD.Enabled = true;
            btThemHD.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaNV.Enabled = true;
            dtpNgayBan.Enabled = true;
        }

        private void btLuuHD_Click_1(object sender, EventArgs e)
        {
            Connect();
            if (txtMaNV.Text != "" && txtMaKH.Text != "" && txtMaHD.Text != "")
            {
                try
                {
                    string ins = "INSERT INTO Hoa_Don_Ban VALUES('" + txtMaHD.Text + "','" + dtpNgayBan.Text + "','" + txtMaKH.Text + "','" + txtMaNV.Text + "','" + txtThue.Text + "')";
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Hoa_Don_Ban(MaHDB,NgayBan,MaKH,MaNV,ThueVAT) VALUES(@MaHDB, @NgayBan,@MaKH,@MaNV,@Thue)", cn);
                    cmd1.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd1.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Text);
                    cmd1.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd1.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd1.Parameters.AddWithValue("@Thue", txtThue.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Parameters.Clear();

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO Chi_Tiet_HDB(MaHDB,MaSach,DonGiaBan,SoLuong) VALUES(@MaHDB,@MaSach,@DonGiaBan,@SoLuong)", cn);
                    cmd5.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd5.Parameters.AddWithValue("@MaSach", cbMaSach.Text);
                    cmd5.Parameters.AddWithValue("@DonGiaBan", txtDonBan.Text);
                    cmd5.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd5.ExecuteNonQuery();
                    cmd5.Parameters.Clear();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                }
                else if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng!");
                }
                else if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!");
                }
                //btLuuHD.Enabled = true;
                //btXoaHD.Enabled = true;
                //btThemHD.Enabled = true;
                //txtMaHD.Enabled = false;
                //txtMaKH.Enabled = false;
                //txtMaNV.Enabled = false;
                //dtpNgayBan.Enabled = false;
            }
        }
    }
}
