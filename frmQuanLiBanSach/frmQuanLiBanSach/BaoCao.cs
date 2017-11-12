using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmQuanLiBanSach
{
    public partial class rptTheoNgay : Form
    {
        public rptTheoNgay()
        {
            InitializeComponent();
        }

        private void rptTheoNgay_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.QLBanSach.DataTable1, dtpTheoNgay.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
