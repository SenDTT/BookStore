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
        private DataTable dt;
        private DataSet ds;
        private SqlDataAdapter da;
        double tongTien = 0;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["BOOKSTOREconnectionStrings"].ConnectionString;
            cn = new SqlConnection(cnStr); 
            loadItemFromDB();
            //LoadDataGirdView();
            //txtTongTien.Text = TongTien().ToString();
            //txtTenSach.DataBindings.Add("Text", dt, "TenSach");
            //txtDonBan.DataBindings.Add("Text", dt, "DonGiaBan");
            //txtThue.DataBindings.Add("Text", dt, "ThueVAT");
            //txtThanhTien.DataBindings.Add("Text", dt, "ThanhTien");

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

        private void LoadDataGirdView()
        {
            string sql = "SELECT s.MaSach, s.TenSach, cthdb.SoLuong, cthdb.DonGiaBan, hdb.ThueVAT, ThanhTien=cthdb.SoLuong*cthdb.DonGiaBan FROM Sach s, Chi_Tiet_HDB cthdb, Hoa_Don_Ban hdb WHERE cthdb.MaSach = s.MaSach AND hdb.MaHDB = cthdb.MaHDB";
            ds = GetDataSet(sql);
            dt = ds.Tables[0];
            cbMaSach.DataSource = dt;
            dgvMatHang.DataSource = dt;
        }

        private DataSet GetDataSet(string sql)
        {
            da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            int numberOfRows = da.Fill(ds);

            if (numberOfRows <= 0)
                ds = null;
            return ds;
        }

        private void loadItemFromDB()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string sql = "SELECT MaSach, TenSach FROM Sach";
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            da.Fill(dt);
            cbMaSach.DataSource = dt;
            cbMaSach.DisplayMember = "MaSach";
            cbMaSach.ValueMember = "TenSach";
            txtTenSach.Text = cbMaSach.SelectedValue.ToString();
            if (cbMaSach.Items.Count > 0)
            {
                cbMaSach.SelectedIndex = 0;
            }
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSach.Text = cbMaSach.SelectedValue.ToString();
        }

        private void btLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                //SqlDataAdapter da = new SqlDataAdapter();
                //string ins = "INSERT INTO Hoa_Don_Ban(MaHDB,NgayBan,MaKH,MaNV,ThueVAT) VALUES ('" + txtMaHD.Text + "','" + dtpNgayBan.Text + "','" + txtMaKH.Text + "','" + txtMaNV.Text + "','" + txtThue.Text + "')";
                //string ins1 = "INSERT INTO Chi_Tiet_HDB(MaHDB,MaSach,DonGiaBan,SoLuong) VALUES ('" + txtMaHD.Text + "','" + cbMaSach.SelectedValue.ToString() + "','" + txtDonBan + "','" + txtSoLuong.Text + "')";
                //SqlCommand cmd = new SqlCommand(ins1, cn);
                //cmd.Parameters.Add(new SqlParameter("@maHDB", SqlDbType.BigInt, 10, "MaHDB"));
                //cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.Int, 10, "MaKH"));
                //cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NChar, 5, "MaNV"));
                //cmd.Parameters.Add(new SqlParameter("@ngayban", SqlDbType.Date, 10, "NgayBan"));
                //cmd.Parameters.Add(new SqlParameter("@thueVAT", SqlDbType.Int, 10, "ThueVAT"));
                //da.InsertCommand = cmd;
                //da.Update(dt);

                //SqlCommand cmd1 = new SqlCommand(ins1, cn);
                //cmd.Parameters.Add(new SqlParameter("@maHDB", SqlDbType.BigInt, 10, "MaHDB"));
                //cmd.Parameters.Add(new SqlParameter("@maSach", SqlDbType.NVarChar, 10, "MaSach"));
                //cmd.Parameters.Add(new SqlParameter("@donGia", SqlDbType.Real, 10, "DonGiaBan"));
                //cmd.Parameters.Add(new SqlParameter("@soLuong", SqlDbType.Int, 10, "SoLuong"));

                //da.InsertCommand = cmd1;
                //da.Update(dt);
                //MessageBox.Show("Them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)dgvMatHang.Rows[0].Clone();
                row.Cells[0].Value = cbMaSach.SelectedValue;
                row.Cells[1].Value = txtTenSach.Text;
                row.Cells[2].Value = int.Parse(txtSoLuong.Text);
                row.Cells[3].Value = float.Parse(txtDonBan.Text);
                row.Cells[4].Value = int.Parse(txtThue.Text);
                row.Cells[5].Value = double.Parse(txtThanhTien.Text);
                dgvMatHang.Rows.Add(row);
                //dr["MaSach"] = cbMaSach.SelectedText;
                //dr["TenSach"] = txtTenSach.Text;
                //dr["SoLuong"] = int.Parse(txtSoLuong.Text);
                //dr["DonGiaBan"] = float.Parse(txtDonBan.Text);
                //dr["ThueVAT"] = int.Parse(txtThue.Text);
                //dr["ThanhTien"] = double.Parse(txtThanhTien.Text);
                //dt.Rows.Add(dr);
                //dgvMatHang.DataSource = dt;
                MessageBox.Show("Them thanh cong");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            Connect();
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

        private double TongTien()
        {
            for (int i = 0; i < dgvMatHang.Rows.Count - 1; i++)
            {
                tongTien += double.Parse(dgvMatHang.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            return tongTien;
        }
    }
}
