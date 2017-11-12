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
    public partial class NhapSach : Form
    {
        SqlConnection sqlCon = new SqlConnection(" Server = .; Database = BOOKSTORE; Integrated Security = true");
        ErrorProvider Error = new ErrorProvider();
        int numberOfRows = 0;
        public NhapSach()
        {
            InitializeComponent();
        }

        private void NhapSach_Load(object sender, EventArgs e)
        {
            KetnoiCSDL();
        }
        private void KetnoiCSDL()
        {
            sqlCon.Open();
            string sql = "Select * From Hoa_Don_Mua";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            dataGridView2.DataSource = dt;

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
    }
}
