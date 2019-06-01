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
    public partial class frmNhomthuoc : Form
    {
        public frmNhomthuoc()
        {
            InitializeComponent();
        }

        DataTable tblNT;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Manhomthuoc, Tennhomthuoc FROM tblNhomthuoc";
            tblNT = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            DataGridView.DataSource = tblNT; //Nguồn dữ liệu            
            DataGridView.Columns[0].HeaderText = "Mã nhóm thuốc";
            DataGridView.Columns[1].HeaderText = "Tên nhóm thuốc";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;
            DataGridView.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void frmNhomthuoc_Load(object sender, EventArgs e)
        {
            txtManhomthuoc.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhomthuoc.Focus();
                return;
            }
            if (tblNT.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhomthuoc.Text = DataGridView.CurrentRow.Cells["Manhomthuoc"].Value.ToString();
            txtTennhomthuoc.Text = DataGridView.CurrentRow.Cells["Tennhomthuoc"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void ResetValue()
        {
            txtManhomthuoc.Text = "";
            txtTennhomthuoc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtManhomthuoc.Enabled = true; //cho phép nhập mới
            txtManhomthuoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtManhomthuoc.Text.Trim().Length == 0) //Nếu chưa nhập mã nhóm thuốc
            {
                MessageBox.Show("Bạn phải nhập mã nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhomthuoc.Focus();
                return;
            }
            if (txtTennhomthuoc.Text.Trim().Length == 0) //Nếu chưa nhập tên nhóm thuốc
            {
                MessageBox.Show("Bạn phải nhập tên nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhomthuoc.Focus();
                return;
            }
            sql = "Select Manhomthuoc From tblNhomthuoc where Manhomthuoc=N'" + txtManhomthuoc.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhóm thuốc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhomthuoc.Focus();
                return;
            }

            sql = "INSERT INTO tblNhomthuoc VALUES(N'" + txtManhomthuoc.Text + "',N'" + txtTennhomthuoc.Text + "')";
            Class.Functions.RunSql(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhomthuoc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblNT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhomthuoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhomthuoc.Text.Trim().Length == 0) //nếu chưa nhập tên nhóm thuốc
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblNhomthuoc SET Tennhomthuoc=N'" + txtTennhomthuoc.Text.ToString() + "' WHERE Manhomthuoc=N'" + txtManhomthuoc.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValue();

            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhomthuoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhomthuoc WHERE Manhomthuoc=N'" + txtManhomthuoc.Text + "'";
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
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhomthuoc.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtManhomthuoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTennhomthuoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
