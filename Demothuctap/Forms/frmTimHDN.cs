using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Demothuctap.Class;

namespace Demothuctap.Forms
{
    public partial class frmTimHDN : Form
    {
        public frmTimHDN()
        {
            InitializeComponent();
        }

        DataTable tblTKHDN;

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboMaHDN.Focus();
        }

        private void frmTimHDN_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
            Functions.FillCombo("SELECT Manhanvien, Tennhanvien FROM tblNhanvien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHDN FROM tblHDN", cboMaHDN, "MaHDN", "MaHDN");
            cboMaHDN.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNCC, TenNCC FROM tblNCC", cboMaNCC, "MaNCC", "TenNCC");
            cboMaNCC.SelectedIndex = -1;
        }

        

        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn nhập";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Ngày nhập";
            DataGridView.Columns[3].HeaderText = "Tên nhà cung cấp";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 80;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 150;
            DataGridView.Columns[4].Width = 80;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
         
            string sql;
            if ((cboMaHDN.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") && (cboManhanvien.Text == "") && (cboMaNCC.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT a.MaHDN, b.Tennhanvien ,a.Ngaynhap, c.TenNCC,  a.TongTien FROM tblHDN AS a, tblNhanvien AS b, tblNCC AS c WHERE 1=1 AND a.Manhanvien=b.Manhanvien AND a.MaNCC=c.MaNCC ";

            if (cboMaHDN.Text != "")
                sql = sql + " AND MaHDN Like N'%" + cboMaHDN.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(Ngaynhap) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngaynhap) =" + txtNam.Text;
            if (cboManhanvien.Text != "")
                sql = sql + " AND Tennhanvien Like N'%" + cboManhanvien.Text + "%'";
            if (cboMaNCC.Text != "")
                sql = sql + " AND TenNCC Like N'%" + cboMaNCC.Text + "%'";

            tblTKHDN = Functions.GetDataToTable(sql);
            if (tblTKHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTKHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblTKHDN;
            Load_DataGridView();
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {       
            ResetValues();
            DataGridView.DataSource = null;
            cboManhanvien.SelectedValue = -1;
            cboMaHDN.SelectedValue = -1;
            cboMaNCC.SelectedValue = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView.CurrentRow.Cells["MaHDN"].Value.ToString();
                frmHoadonnhap frm = new frmHoadonnhap();
                cboMaHDN.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
