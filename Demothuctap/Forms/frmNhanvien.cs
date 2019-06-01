using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Demothuctap.Class;
using System.Windows.Forms;

namespace Demothuctap.Forms
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        // Khai báo biến toàn cục
        DataTable tblNV;
        private string ma;

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Manhanvien,Tennhanvien,Chucvu,Gioitinh,Diachi,Dienthoai,Ngaysinh,CMT FROM tblNhanvien";
            tblNV = Functions.GetDataToTable(sql); //lấy dữ liệu
            DataGridView.DataSource = tblNV;
            //DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            //DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            //DataGridView.Columns[2].HeaderText = "Chức vụ";
            //DataGridView.Columns[3].HeaderText = "Giới tính";
            //DataGridView.Columns[4].HeaderText = "Địa chỉ";
            //DataGridView.Columns[5].HeaderText = "Điện thoại";
            //DataGridView.Columns[6].HeaderText = "Ngày sinh";
            //DataGridView.Columns[7].HeaderText = "CMT";
            //DataGridView.Columns[0].Width = 100;
            //DataGridView.Columns[1].Width = 150;
            //DataGridView.Columns[2].Width = 100;
            //DataGridView.Columns[3].Width = 100;
            //DataGridView.Columns[4].Width = 150;
            //DataGridView.Columns[5].Width = 100;
            //DataGridView.Columns[6].Width = 100;
            //DataGridView.Columns[7].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = DataGridView.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennhanvien.Text = DataGridView.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            txtChucvu.Text = DataGridView.CurrentRow.Cells["Chucvu"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam") chkGioitinh.Checked = true;
            else chkGioitinh.Checked = false;
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNgaysinh.Text = DataGridView.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            txtCMT.Text = DataGridView.CurrentRow.Cells["CMT"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtChucvu.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            mskNgaysinh.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
            //matudong();
            //macmt();
        }

        
        private void matudong()
        {
            string g;
            if (tblNV.Rows.Count ==0)
            {
                g = "NV"+ txtCMT.Text;
            }
            else
            {
                int k;
                g = "NV";
                k = Convert.ToInt32(tblNV.Rows[tblNV.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k <= 10)
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            txtManhanvien.Text = g;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtChucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChucvu.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }

            if (txtCMT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập CMT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMT.Focus();
                return;
            }

            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT Manhanvien FROM tblNhanvien WHERE Manhanvien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            
            if (Functions.CheckKey("SELECT CMT FROM tblNhanvien WHERE CMT=N'" + txtCMT.Text.Trim() + "'"))
            {
                MessageBox.Show("CMT này đã có, bạn phải nhập CMT khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMT.Focus();
                txtCMT.Text = "";
                return;
            }

            sql = "INSERT INTO tblNhanvien(Manhanvien,Tennhanvien,Chucvu,Gioitinh, Diachi,Dienthoai, Ngaysinh,CMT) VALUES (N'" + txtManhanvien.Text.Trim() + "',N'" + txtTennhanvien.Text.Trim() + "',N'" + txtChucvu.Text.Trim() + "',N'" + gt + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "','" + Functions.ConvertDateTime(mskNgaysinh.Text) + "','" + txtCMT.Text.Trim() + "')";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            // macmt();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtChucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChucvu.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            //if (!Functions.IsDate(mskNgaysinh.Text))
            //{
            //    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskNgaysinh.Text = "";
            //    mskNgaysinh.Focus();
            //    return;
            //}
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanvien SET  Tennhanvien=N'" + txtTennhanvien.Text.Trim().ToString() +
                    "',Chucvu=N'" + txtChucvu.Text.Trim().ToString() +
                    "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',Dienthoai='" + mskDienthoai.Text.ToString() + "',Gioitinh=N'" + gt +
                    "',Ngaysinh='" + mskNgaysinh.Text +
                    "' WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtManhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTennhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }


        private void txtChucvu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskDienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskNgaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        //private void cmt()
        //{

        //    string matudong = "NV_" + txtCMT.Text.ToString();
        //    txtManhanvien.Text = ma;

        //}

        private void txtManhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMT_TextChanged(object sender, EventArgs e)
        {
            string tiento;
            tiento = "NV_";
            string x = Convert.ToString(txtCMT.Text.Trim());
            string ma = tiento + x;
            txtManhanvien.Text = ma.ToString();

        }
    }
}
