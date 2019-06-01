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
    public partial class frmTimHDB : Form
    {
        public frmTimHDB()
        {
            InitializeComponent();
        }

        DataTable tblTKHDB;

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboMaHDB.Focus();
        }

        private void frmTimHDB_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
            Functions.FillCombo("SELECT Manhanvien, Tennhanvien FROM tblNhanvien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHDB FROM tblHDB", cboMaHDB, "MaHDB", "MaHDB");
            cboMaHDB.SelectedIndex = -1;
            Functions.FillCombo("SELECT Makhach, Tenkhach FROM tblKhachhang", cboMaKhach, "Makhach", "Tenkhach");
            cboMaKhach.SelectedIndex = -1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaHDB.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") && (cboManhanvien.Text == "") && (cboMaKhach.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            sql = "SELECT a.MaHDB, b.Tennhanvien ,a.Ngayban, c.Tenkhach, a.TongTien FROM tblHDB AS a, tblNhanvien AS b, tblKhachhang AS c WHERE 1=1 AND a.Manhanvien=b.Manhanvien AND a.Makhach=c.Makhach ";

            if (cboMaHDB.Text != "")
                sql = sql + " AND MaHDB Like N'%" + cboMaHDB.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(Ngayban) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngayban) =" + txtNam.Text;
            if (cboManhanvien.Text != "")
                sql = sql + " AND Tennhanvien Like N'%" + cboManhanvien.Text + "%'";
            if (cboMaKhach.Text != "")
                sql = sql + " AND Tenkhach Like N'%" + cboMaKhach.Text + "%'";

            tblTKHDB = Functions.GetDataToTable(sql);
            if (tblTKHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTKHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblTKHDB;
            Load_DataGridView();

        }

        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn nhập";
            DataGridView.Columns[1].HeaderText = "Tên  nhân viên";
            DataGridView.Columns[2].HeaderText = "Ngày bán";
            DataGridView.Columns[3].HeaderText = "Tên khách";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 150;
            DataGridView.Columns[4].Width = 80;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
            cboManhanvien.SelectedValue = -1;
            cboMaHDB.SelectedValue = -1;
            cboMaKhach.SelectedValue = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView.CurrentRow.Cells["MaHDB"].Value.ToString();
                frmHoadonban frm = new frmHoadonban();
                cboMaHDB.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
