namespace frmQuanLiBanSach
{
    partial class rptTheoNgay
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBanSach = new frmQuanLiBanSach.QLBanSach();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new frmQuanLiBanSach.QLBanSachTableAdapters.DataTable1TableAdapter();
            this.dtpTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.lbTheoNgay = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanSach)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.QLBanSach;
            // 
            // QLBanSach
            // 
            this.QLBanSach.DataSetName = "QLBanSach";
            this.QLBanSach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TheoNgay";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmQuanLiBanSach.rptTheoNgay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(632, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dtpTheoNgay
            // 
            this.dtpTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTheoNgay.Location = new System.Drawing.Point(90, 12);
            this.dtpTheoNgay.Name = "dtpTheoNgay";
            this.dtpTheoNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTheoNgay.TabIndex = 1;
            this.dtpTheoNgay.Value = new System.DateTime(2017, 11, 5, 0, 0, 0, 0);
            // 
            // lbTheoNgay
            // 
            this.lbTheoNgay.AutoSize = true;
            this.lbTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheoNgay.Location = new System.Drawing.Point(12, 17);
            this.lbTheoNgay.Name = "lbTheoNgay";
            this.lbTheoNgay.Size = new System.Drawing.Size(72, 16);
            this.lbTheoNgay.TabIndex = 2;
            this.lbTheoNgay.Text = "Chọn ngày";
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(296, 14);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(75, 23);
            this.btIn.TabIndex = 3;
            this.btIn.Text = "In báo cáo";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // rptTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 419);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.lbTheoNgay);
            this.Controls.Add(this.dtpTheoNgay);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptTheoNgay";
            this.Text = "Báo cáo theo ngày";
            this.Load += new System.EventHandler(this.rptTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private QLBanSach QLBanSach;
        private QLBanSachTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.DateTimePicker dtpTheoNgay;
        private System.Windows.Forms.Label lbTheoNgay;
        private System.Windows.Forms.Button btIn;
    }
}