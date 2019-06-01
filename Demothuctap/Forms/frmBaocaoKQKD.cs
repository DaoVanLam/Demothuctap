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
using Demothuctap.Class;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Demothuctap.Forms
{
    public partial class frmBaocaoKQKD : Form
    {
        public frmBaocaoKQKD()
        {
            InitializeComponent();
        }

        DataTable tblTKHDB;
        DataTable tblTKHDN;

        private void frmBaocaoKQKD_Load(object sender, EventArgs e)
        {
            btnThongke.Enabled = true;
            dtpTungay.Enabled = true;
            dtpDenngay.Enabled = true;
        }

        private void LoadDataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn nhập";
            DataGridView.Columns[1].HeaderText = "Ngày nhập";
            DataGridView.Columns[2].HeaderText = "Mã nhân viên";
            DataGridView.Columns[3].HeaderText = "Mã nhà cung cấp";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 110;
            DataGridView.Columns[2].Width = 90;
            DataGridView.Columns[3].Width = 90;
            DataGridView.Columns[4].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView1()
        {
            DataGridView1.Columns[0].HeaderText = "Mã hóa đơn bán";
            DataGridView1.Columns[1].HeaderText = "Ngày bán";
            DataGridView.Columns[2].HeaderText = "Mã nhân viên";
            DataGridView1.Columns[3].HeaderText = "Mã khách hàng";
            DataGridView1.Columns[4].HeaderText = "Tổng tiền";
            DataGridView1.Columns[0].Width = 200;
            DataGridView1.Columns[1].Width = 110;
            DataGridView1.Columns[2].Width = 90;
            DataGridView1.Columns[3].Width = 90;
            DataGridView1.Columns[3].Width = 90;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (tblTKHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView.CurrentRow.Cells["MaHDN"].Value.ToString();
                frmHoadonnhap frm = new frmHoadonnhap();
                frm.txtMaHDN.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (tblTKHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView1.CurrentRow.Cells["MaHDB"].Value.ToString();
                frmHoadonban frm = new frmHoadonban();
                
                frm.txtMaHDBan.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            string sql, tn, dn;
            double tc, tt, ttn;
            tn = dtpTungay.Value.ToString("MM/dd/yyyy");
            dn = dtpDenngay.Value.ToString("MM/dd/yyyy");
            if (dtpTungay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpTungay.Focus();
                return;
            }
            if (dtpDenngay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDenngay.Focus();
                return;
            }
            
            sql = "Select * From tblHDN Where Ngaynhap >= '" + tn + "' and Ngaynhap <= '" + dn + "' ";
            tblTKHDN = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblTKHDN;
            LoadDataGridView();
            sql = "Select * From tblHDB Where Ngayban >= '" + tn + "' and Ngayban <= '" + dn + "' ";
            tblTKHDB = Functions.GetDataToTable(sql);
            DataGridView1.DataSource = tblTKHDB;
            LoadDataGridView1();
            lbltc.Text = Functions.GetFieldValues("Select sum(TongTien) From tblHDN Where Ngaynhap >= '" + tn + "' and Ngaynhap <= '" + dn + "' ");
            lbltt.Text = Functions.GetFieldValues("Select sum(TongTien) From tblHDB Where Ngayban >= '" + tn + "' and Ngayban <= '" + dn + "' ");
            if (lbltc.Text == "")
                lbltc.Text = "0";
            if (lbltt.Text == "")
                lbltt.Text = "0";
            tc = Convert.ToDouble(lbltc.Text);
            tt = Convert.ToDouble(lbltt.Text);
            ttn = tt - tc ;
            lbltln.Text = Convert.ToString(ttn);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
