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
using System.Text.RegularExpressions;

namespace Sách
{
    public partial class KhoSach : Form
    {
        //string cnstr = " Server = .; Database = BOOKSTORE; Integrated Security = true";
        SqlConnection sqlCon = new SqlConnection(" Server = .; Database = BOOKSTORE; Integrated Security = true");
        ErrorProvider Error = new ErrorProvider();
        int numberOfRows = 0;
        public KhoSach()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetnoiCSDL();
        }
        //Hàm khởi tạo
        private void KetnoiCSDL()
        {
            sqlCon.Open();
            string sql = "Select * From Sach";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            dataGrV1.DataSource = dt;

        }
        private void Connect()
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(" /n", ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" /n", ex.Message);
            }
        }
        private void Disconnect()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand TimSach = new SqlCommand("select * FROM Sach WHERE MaSach = '" + txtMaSach.Text + "'", sqlCon);
            SqlDataReader data = TimSach.ExecuteReader();
            Error.Clear();
            if (data.Read() != true)
            {
                MessageBox.Show("Không tìm thấy sách này hoặc bạn nhập sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Không tìm thấy sách này");
                txtMaSach.Focus();
                data.Close();
                data.Dispose();
                Disconnect();

            }
            else
            {
                data.Close();
                data.Dispose();
                Disconnect();
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("Nhập mã sách cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    Disconnect();
                }


                else
                {
                    string sql = "select * FROM Sach WHERE MaSach = '" + txtMaSach.Text + "'";
                    Connect();

                    SqlCommand command = new SqlCommand("select TenSach from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtTenSach.Text = (string)command.ExecuteScalar();
                    SqlCommand command1 = new SqlCommand("select NXB from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtNXB.Text = (string)command1.ExecuteScalar();
                    SqlCommand command2 = new SqlCommand("select MaTheLoai from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtMaLoai.Text = (string)command2.ExecuteScalar();
                    SqlCommand command3 = new SqlCommand("select MaNCC from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    int Mancc = (int)command3.ExecuteScalar();
                    SqlCommand command4 = new SqlCommand("select MaGiamGia from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtMaGiam.Text = (string)command4.ExecuteScalar().ToString();
                    SqlCommand command5 = new SqlCommand("select DonGiaBan from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtGiaBan.Text = (string)command5.ExecuteScalar().ToString();
                    SqlCommand command6 = new SqlCommand("select SLtrongKho from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    int SLtK = Convert.ToInt16(command6.ExecuteScalar());
                    SqlCommand command7 = new SqlCommand("select SLDatHang from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    int SLdH = Convert.ToInt16(command7.ExecuteScalar());
                    SqlCommand command8 = new SqlCommand("select TinhTrang from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    txtTinhTrang.Text = (string)command8.ExecuteScalar();
                    txtMaNcc.Text = Mancc.ToString();
                    txtSLKho.Text = SLtK.ToString();
                    txtSLDat.Text = SLdH.ToString();
                    //truy xuất ô tìm kiếm dc trên Sql

                    string S = "select * FROM Sach WHERE MaSach=@MaSach";
                    SqlCommand command0 = new SqlCommand(S, sqlCon);
                    command0.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                    command0.Parameters.AddWithValue("TenSach", txtTenSach.Text);
                    command0.Parameters.AddWithValue("NXB", txtNXB.Text);
                    command0.Parameters.AddWithValue("MaTheLoai", txtMaLoai.Text);
                    command0.Parameters.AddWithValue("MaNCC", txtMaNcc.Text);
                    command0.Parameters.AddWithValue("MaGiamGia", txtMaGiam.Text);
                    command0.Parameters.AddWithValue("DonGiaBan", txtGiaBan.Text);
                    command0.Parameters.AddWithValue("SLtrongKho", txtSLKho.Text);
                    command0.Parameters.AddWithValue("SLDatHang", txtSLDat.Text);
                    command0.Parameters.AddWithValue("TinhTrang", txtTinhTrang.Text);
                    command0.ExecuteNonQuery();

                    SqlDataReader dr = command0.ExecuteReader();
                    DataTable dt = new DataTable();
                    //SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    dt.Load(dr);
                    dataGrV1.DataSource = dt;
                    //MessageBox.Show(" Tìm thấy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disconnect();
                }

            }
        }

        public object dt { get; set; }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            Connect();
            Error.Clear();
            if (txtMaSach.Text == "" || txtMaGiam.Text == "" || txtMaLoai.Text == "" || txtMaNcc.Text == "" || txtNXB.Text == "" || txtSLDat.Text == "" || txtSLKho.Text == ""
                || txtTenSach.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập Đầy Đủ Thông Tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (kiemtramasach() == true)
            {
                MessageBox.Show("Mã Sách Này Đã Có, Bạn Vui Lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Mã Sách Này Đã Có, Bạn Vui Lòng Nhập Lại");
                txtMaSach.Focus();
            }
            else if (kiemtrakitu(txtMaSach.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Mã Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else if (kiemtrakitu(txtTenSach.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Tên Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
            }
            else if (kiemtrakitu(txtNXB.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở NXB", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNXB.Focus();
            }
            else if (kiemtrakitu(txtTinhTrang.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Tình Trạng Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinhTrang.Focus();
            }
            else
            {
                Connect();
                string nhap = "Insert Into Sach(MaSach,TenSach,NXB,MaTheLoai,MaNCC,MaGiamGia,DonGiaBan,SLtrongKho, SLDatHang,TinhTrang )" + "Values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtNXB.Text + "',N'" + txtMaLoai.Text + "',N'" + txtMaNcc.Text + "',N'" + txtMaGiam.Text + "',N'" + txtGiaBan.Text  + "',N'" + txtSLKho.Text + "',N'" + txtSLDat.Text + "',N'" + txtTinhTrang.Text + "')";
                SqlCommand command = new SqlCommand(nhap, sqlCon);
                command.ExecuteNonQuery();
                MessageBox.Show(" Bạn Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disconnect();
                KetnoiCSDL();

            }
            Disconnect();
        }
        private bool kiemtramasach()
        {

            bool kt = false;
            string tdn = txtMaSach.Text;
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Sach where MaSach='" + tdn + "'", sqlCon);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;

            }
            da_kt.Dispose();
            sqlCon.Close();
            return kt;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaSach.Text == "" && txtTenSach.Text == "" && txtNXB.Text == "" && txtMaLoai.Text == "" && txtMaNcc.Text == "" &&
                txtMaGiam.Text == "" && txtSLKho.Text == "" && txtSLDat.Text == "" && txtTinhTrang.Text == "")
            {
                MessageBox.Show(" Dữ liệu đang trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Sách Cần Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Bạn Chưa Nhập Mã Sách Cần Xóa");
                txtMaSach.Focus();
            }
            else
            {

                sqlCon.Open();
                SqlCommand TimSach = new SqlCommand("select * FROM Sach WHERE MaSach = '" + txtMaSach.Text + "'", sqlCon);
                SqlDataReader data = TimSach.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy sách này ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtMaSach, "Bạn Chưa Nhập Mã Sách Cần Xóa");
                    txtMaSach.Focus();
                    data.Close();
                    data.Dispose();
                    Disconnect();

                }
                else
                {
                    if ((MessageBox.Show("Bạn chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                    {

                        data.Close();
                        data.Dispose();
                        SqlCommand cmd = new SqlCommand("Delete from Sach where MaSach=@MaSach", sqlCon);
                        cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                        txtMaSach.Text = null;
                        txtTenSach.Text = null;
                        txtNXB.Text = null;
                        txtMaLoai.Text = null;
                        txtMaNcc.Text = null;
                        txtMaGiam.Text = null;
                        txtGiaBan.Text = null;
                        txtSLKho.Text = null;
                        txtSLDat.Text = null;
                        txtTinhTrang.Text = null;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Xóa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disconnect();
                        KetnoiCSDL();
                    }
                   
                }
                Disconnect();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaSach.Text == "" || txtMaGiam.Text == "" || txtMaLoai.Text == "" || txtMaNcc.Text == "" || txtNXB.Text == "" || txtGiaBan.Text == "" || txtSLDat.Text == "" || txtSLKho.Text == ""
                || txtTenSach.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập Đầy Đủ Thông Tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (kiemtrakitu(txtMaSach.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Mã Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Bạn Chưa Nhập Mã Sách Cần Xóa");
                txtMaSach.Focus();
            }
            else if (kiemtrakitu(txtTenSach.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Tên Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Có Ký Tự Đặt Biệt Ở Tên Sách");
                txtTenSach.Focus();
            }
            else if (kiemtrakitu(txtNXB.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở NXB", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaSach, "Có Ký Tự Đặt Biệt Ở NXB");
                txtNXB.Focus();
            }
            else if (kiemtrakitu(txtTinhTrang.Text) == false)
            {
                MessageBox.Show("Có Ký Tự Đặt Biệt Ở Tình Trạng Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinhTrang.Focus();
            }
            else
            {

                Connect();
                SqlCommand cmdtk = new SqlCommand("select MaSach from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Mã Thẻ Này Không Có Trong Danh Sách ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtMaSach, "Mã Thẻ Này Không Có Trong Danh Sách");
                    txtMaSach.Focus();
                    data.Close();
                    data.Dispose();
                    Disconnect();
                }
                else
                {
                    data.Close();
                    data.Dispose();
                    Connect();
                    string update = "Update Sach Set MaSach=@MaSach,TenSach=@TenSach,NXB=@NXB,MaTheLoai=@MaTheLoai,MaNCC=@MaNCC,MaGiamGia=@MaGiamGia,DonGiaBan=@DonGiaBan,SLtrongKho=@SLtrongKho,SLDatHang=@SLDatHang,TinhTrang=@TinhTrang where MaSach=@MaSach";
                    SqlCommand command = new SqlCommand(update, sqlCon);
                    command.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                    command.Parameters.AddWithValue("TenSach", txtTenSach.Text);
                    command.Parameters.AddWithValue("NXB", txtNXB.Text);
                    command.Parameters.AddWithValue("MaTheLoai", txtMaLoai.Text);
                    command.Parameters.AddWithValue("MaNCC", txtMaNcc.Text);
                    command.Parameters.AddWithValue("MaGiamGia", txtMaGiam.Text);
                    command.Parameters.AddWithValue("DonGiaBan", txtGiaBan.Text);
                    command.Parameters.AddWithValue("SLtrongKho", txtSLKho.Text);
                    command.Parameters.AddWithValue("SLDatHang", txtSLDat.Text);
                    command.Parameters.AddWithValue("TinhTrang", txtTinhTrang.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Bạn Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disconnect();
                    KetnoiCSDL();
                }
            }
        }
        // Double Click vào 1 ô trên bản đễ hiện dữ liệu của nguyên 1 hàng đó
        private void dataGrV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataGrV1.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dataGrV1.CurrentRow.Cells[1].Value.ToString();
            txtNXB.Text = dataGrV1.CurrentRow.Cells[2].Value.ToString();
            txtMaLoai.Text = dataGrV1.CurrentRow.Cells[3].Value.ToString();
            txtMaNcc.Text = dataGrV1.CurrentRow.Cells[4].Value.ToString();
            txtMaGiam.Text = dataGrV1.CurrentRow.Cells[5].Value.ToString();
            txtGiaBan.Text = dataGrV1.CurrentRow.Cells[6].Value.ToString();
            txtSLKho.Text = dataGrV1.CurrentRow.Cells[7].Value.ToString();
            txtSLDat.Text = dataGrV1.CurrentRow.Cells[8].Value.ToString();
            txtTinhTrang.Text = dataGrV1.CurrentRow.Cells[9].Value.ToString();
        }
        //Hàm Kiễm Tra ký tự đặt biệt
        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNM qwertyuiopasdĐđ ÁÀẢẠÃ ĂẴẰẲẮẶ ÂẨẦẤẪẬ ÊỀẾỆỂỄ ÚÙỦỤŨU ÚƯỪỰỬỮ ÍÌỊỈIÌ ÝỲYỶỴỸ ÓÒOỎÕỌ ỘỒÔỐỔỖ ƠỜÓỞỢỠ ÉEÈẺẸẼ  fghjklzxcvbnm áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ -,.";//Các kí tự đang nhập
        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }
            return true;
        }
        // Chỉ Cho Phép Nhập Số 
        private void txtSLKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMaGiam.Text = null;
            txtMaLoai.Text = null;
            txtMaNcc.Text = null;
            txtMaSach.Text = null;
            txtNXB.Text = null;
            txtGiaBan.Text = null;
            txtSLDat.Text = null;
            txtSLKho.Text = null;
            txtTenSach.Text = null;
            txtTinhTrang.Text = null;
            KetnoiCSDL();
        }
    }
}


       
