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

namespace Demothuctap.Forms
{
    public partial class frmThuoc : Form
    {
        public frmThuoc()
        {
            InitializeComponent();
        }

        DataTable tblT;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblThuoc";
            tblT = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblT;
            DataGridView.Columns[0].HeaderText = "Mã thuốc";
            DataGridView.Columns[1].HeaderText = "Tên thuốc";
            DataGridView.Columns[2].HeaderText = "Đơn vị tính";
            DataGridView.Columns[3].HeaderText = "Tên nhóm thuốc";
            DataGridView.Columns[4].HeaderText = "Đơn giá nhập";
            DataGridView.Columns[5].HeaderText = "Đơn giá bán";
            DataGridView.Columns[6].HeaderText = "Số lượng ";
            DataGridView.Columns[7].HeaderText = "Ngày sản xuất";
            DataGridView.Columns[8].HeaderText = "Hạn sử dụng";
            DataGridView.Columns[9].HeaderText = "Công dụng";
            DataGridView.Columns[10].HeaderText = "Chống chỉ định";
            DataGridView.Columns[11].HeaderText = "Thành phần thuốc";
            DataGridView.Columns[12].HeaderText = "Ảnh";
           
            DataGridView.Columns[0].Width = 60;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 60;
            DataGridView.Columns[3].Width = 60;
            DataGridView.Columns[4].Width = 60;
            DataGridView.Columns[5].Width = 60;
            DataGridView.Columns[6].Width = 50;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;
            DataGridView.Columns[9].Width = 100;
            DataGridView.Columns[10].Width = 100;
            DataGridView.Columns[11].Width = 100;
            DataGridView.Columns[12].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMathuoc.Text = "";
            txtTenthuoc.Text = "";
            mskNgaysx.Text = "";
            mskHansd.Text = "";
            txtCongdung.Text = "";
            txtChongchidinh.Text = "";
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
            cboManhomthuoc.Text = "";
            cboDonvitinh.Text = "";
            txtThanhphan.Text = "";

            txtSoluong.Enabled = false;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            txtMathuoc.Enabled = false;           
            btnLuu.Enabled = true;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo("SELECT * FROM tblNhomthuoc", cboManhomthuoc, "Manhomthuoc", "Tennhomthuoc");
            cboManhomthuoc.SelectedIndex = -1;
            Functions.FillCombo("SELECT * from tblDVTinh", cboDonvitinh, "MaDVT", "TenDVT");
            cboDonvitinh.SelectedIndex = -1;
            ResetValues();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string manhomthuoc;
            string madonvitinh;
            string sql;

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMathuoc.Focus();
                return;
            }
            if (tblT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMathuoc.Text = DataGridView.CurrentRow.Cells["Mathuoc"].Value.ToString();
            txtTenthuoc.Text = DataGridView.CurrentRow.Cells["Tenthuoc"].Value.ToString();
            manhomthuoc = DataGridView.CurrentRow.Cells["Manhomthuoc"].Value.ToString();

            sql = "SELECT Tennhomthuoc FROM tblNhomthuoc WHERE Manhomthuoc=N'" + manhomthuoc + "'";
            cboManhomthuoc.Text = Functions.GetFieldValues(sql);

            mskNgaysx.Text = DataGridView.CurrentRow.Cells["NgaySX"].Value.ToString();
            mskHansd.Text = DataGridView.CurrentRow.Cells["HanSD"].Value.ToString();

            sql = "SELECT Anh FROM tblThuoc WHERE Mathuoc=N'" + txtMathuoc.Text + "'";
            txtAnh.Text = Functions.GetFieldValues(sql); // hàm getFieldValues có tác dụng lấy dữ liệu từ 1 câu truy vấn
            picAnh.Image = Image.FromFile(txtAnh.Text);
          
            txtSoluong.Text = DataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongianhap.Text = DataGridView.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDongiaban.Text = DataGridView.CurrentRow.Cells["Dongiaban"].Value.ToString();

            madonvitinh = DataGridView.CurrentRow.Cells["MaDVT"].Value.ToString();
            sql = "SELECT TenDVT FROM tblDVTinh WHERE MaDVT=N'" + madonvitinh + "'";
            cboDonvitinh.Text = Functions.GetFieldValues(sql);

            txtThanhphan.Text = DataGridView.CurrentRow.Cells["Thanhphan"].Value.ToString();
            txtChongchidinh.Text = DataGridView.CurrentRow.Cells["Chongchidinh"].Value.ToString();
            txtCongdung.Text = DataGridView.CurrentRow.Cells["Congdung"].Value.ToString();
           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues(); // xóa trắng các textbox
            txtMathuoc.Enabled = true;
            txtMathuoc.Focus();
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
            //Matangtudongthuoc();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMathuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMathuoc.Focus();
                return;
            }

            if (txtTenthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenthuoc.Focus();
                return;
            }

            if (cboManhomthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboManhomthuoc.Focus();
                return;
            }

            if (mskNgaysx.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysx.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysx.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskNgaysx.Text = "";
                mskNgaysx.Focus();
                return;
            }

            if (mskHansd.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHansd.Focus();
                return;
            }
            if (!Functions.IsDate(mskHansd.Text))
            {
                MessageBox.Show("Bạn phải nhập lại hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskHansd.Text = "";
                mskHansd.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            
            if (cboDonvitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính cho thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDonvitinh.Focus();
                return;
            }

            if (txtThanhphan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thành phần của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThanhphan.Focus();
                return;
            }


            if (txtCongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCongdung.Focus();
                return;
            }

            if (txtChongchidinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chống chỉ định của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChongchidinh.Focus();
                return;
            }


            sql = "SELECT Mathuoc FROM tblThuoc WHERE Mathuoc=N'" + txtMathuoc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thuốc này đã tồn tại, bạn phải nhập mã thuốc khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMathuoc.Focus();
                return;
            }

            sql = "INSERT INTO tblThuoc(Mathuoc, Tenthuoc, MaDVT, Manhomthuoc, Thanhphan, Dongianhap, Dongiaban, Soluong, NgaySX, HanSD, Chongchidinh, Congdung, Anh) VALUES(N'" + txtMathuoc.Text.Trim() + "',N'" + txtTenthuoc.Text.Trim() + "',N'" + cboDonvitinh.SelectedValue.ToString() + "',N'" + cboManhomthuoc.SelectedValue.ToString() + "', N'" + txtThanhphan.Text.Trim() + "'," + txtDongianhap.Text + "," + txtDongiaban.Text + "," + txtSoluong.Text.Trim() + ",'" + Functions.ConvertDateTime(mskNgaysx.Text) + "','" + Functions.ConvertDateTime(mskHansd.Text) + "', N'" + txtChongchidinh.Text.Trim() + "', N'" + txtCongdung.Text.Trim() + "','" + txtAnh.Text + "')";

            Functions.RunSql(sql);           
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMathuoc.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (tblT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMathuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMathuoc.Focus();
                return;
            }

            if (txtTenthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenthuoc.Focus();
                return;
            }

            if (mskNgaysx.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysx.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysx.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysx.Text = "";
                mskNgaysx.Focus();
                return;
            }

            if (mskHansd.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHansd.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysx.Text))
            {
                MessageBox.Show("Bạn phải nhập lại hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHansd.Text = "";
                mskHansd.Focus();
                return;
            }

            if (cboManhomthuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhóm thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboManhomthuoc.Focus();
                return;
            }

            if (cboDonvitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính cho thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDonvitinh.Focus();
                return;
            }

            if (txtCongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCongdung.Focus();
                return;
            }

            if (txtThanhphan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thành phần của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThanhphan.Focus();
                return;
            }

            if (txtChongchidinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chống chỉ định của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChongchidinh.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }

            sql = "UPDATE tblThuoc SET Tenthuoc=N'" + txtTenthuoc.Text.Trim().ToString() +"',NgaySX='" + Functions.ConvertDateTime(mskNgaysx.Text) +"',HanSD='" + Functions.ConvertDateTime(mskHansd.Text) +"',Thanhphan=N'" + txtThanhphan.Text + "',Congdung=N'" + txtCongdung.Text + "',Chongchidinh=N'" + txtChongchidinh.Text +"',Soluong=" + txtSoluong.Text +",Anh='" + txtAnh.Text +"',Manhomthuoc=N'" + cboManhomthuoc.SelectedValue.ToString() +"',MaDVT=N'" + cboDonvitinh.SelectedValue.ToString() +"' WHERE Mathuoc=N'" + txtMathuoc.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (tblT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMathuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                sql = "DELETE tblThuoc WHERE Mathuoc=N'" + txtMathuoc.Text + "'";
                Functions.RunSqlDel(sql);  // RunSQL thực hiện câu lệnh SQl
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMathuoc.Enabled = false;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT Mathuoc, Tenthuoc, MaDVT,  Manhomthuoc, Thanhphan, Dongianhap, Dongiaban, Soluong, NgaySX, HanSD, Chongchidinh,Congdung, Anh FROM tblThuoc"; 
            tblT = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblT;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;

            if ((txtMathuoc.Text == "") && (txtTenthuoc.Text == "") && (cboManhomthuoc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT * from tblThuoc WHERE 1=1";

            if (txtMathuoc.Text != "")
                sql += " AND Mathuoc LIKE N'%" + txtMathuoc.Text + "%'";
            if (txtTenthuoc.Text != "")
                sql += " AND Tenthuoc LIKE N'%" + txtTenthuoc.Text + "%'";
            if (cboManhomthuoc.Text != "")
                sql += " AND Manhomthuoc LIKE N'%" + cboManhomthuoc.SelectedValue + "%'";

            tblT = Functions.GetDataToTable(sql);

            if (tblT.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Có " + tblT.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridView.DataSource = tblT;
            ResetValues();
        }
    }
}
