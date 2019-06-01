using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demothuctap.Forms
{
    public partial class frmDVTinh : Form
    {
        public frmDVTinh()
        {
            InitializeComponent();
        }

        DataTable tblDVT;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaDVT, TenDVT FROM tblDVTinh";
            tblDVT = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            DataGridView.DataSource = tblDVT; //Nguồn dữ liệu            
            DataGridView.Columns[0].HeaderText = "Mã đơn vị tính";
            DataGridView.Columns[1].HeaderText = "Tên đơn vị tính";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;
            DataGridView.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void frmDVTinh_Load(object sender, EventArgs e)
        {
            txtMadonvitinh.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadonvitinh.Focus();
                return;
            }
            if (tblDVT.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMadonvitinh.Text = DataGridView.CurrentRow.Cells["MaDVT"].Value.ToString();
            txtTendonvitinh.Text = DataGridView.CurrentRow.Cells["TenDVT"].Value.ToString();
            btnSua.Enabled = true;
            // btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void ResetValue()
        {
            txtMadonvitinh.Text = "";
            txtTendonvitinh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMadonvitinh.Enabled = true; //cho phép nhập mới
            txtMadonvitinh.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMadonvitinh.Text.Trim().Length == 0) //Nếu chưa nhập mã đơn vị tính
            {
                MessageBox.Show("Bạn phải nhập mã đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadonvitinh.Focus();
                return;
            }
            if (txtTendonvitinh.Text.Trim().Length == 0) //Nếu chưa nhập tên đơn vị tính
            {
                MessageBox.Show("Bạn phải nhập tên đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendonvitinh.Focus();
                return;
            }
            sql = "Select MaDVT From tblDVTinh where MaDVT=N'" + txtMadonvitinh.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đơn vị tính này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadonvitinh.Focus();
                return;
            }

            sql = "INSERT INTO tblDVTinh VALUES(N'" +
                txtMadonvitinh.Text + "',N'" + txtTendonvitinh.Text + "')";
            Class.Functions.RunSql(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMadonvitinh.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblDVT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadonvitinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTendonvitinh.Text.Trim().Length == 0) //nếu chưa nhập tên đơn vị tính
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblDVTinh SET TenDVT=N'" + txtTendonvitinh.Text.ToString() + "' WHERE MaDVT=N'" + txtMadonvitinh.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValue();

            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDVT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadonvitinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblDVTinh WHERE MaDVT=N'" + txtMadonvitinh.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMadonvitinh.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtMadonvitinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTendonvitinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
