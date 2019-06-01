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
    public partial class frmHoadonnhap : Form
    {
        public frmHoadonnhap()
        {
            InitializeComponent();
        }

        DataTable tblCTHDN;

        private void LoadInfoHoadon()
        {
            string str;
            str = "SELECT Ngaynhap FROM tblHDN WHERE MaHDN = N'" + txtMaHDN.Text + "'";
            txtNgaynhap.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "SELECT Manhanvien FROM tblHDN WHERE MaHDN = N'" + txtMaHDN.Text + "'";
            cboManhanvien.Text = Functions.GetFieldValues(str);
            str = "SELECT MaNCC FROM tblHDN WHERE MaHDN = N'" + txtMaHDN.Text + "'";
            cboMaNCC.Text = Functions.GetFieldValues(str);
            str = "SELECT Tongtien FROM tblHDN WHERE MaHDN = N'" + txtMaHDN.Text + "'";
            txtTongtien.Text = Functions.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.Mathuoc, b.Tenthuoc, a.Soluong, a.Dongia,a.Thanhtien FROM tblChitietHDN AS a, tblThuoc AS b WHERE a.MaHDN = N'" + txtMaHDN.Text + "' AND a.Mathuoc=b.Mathuoc";
            tblCTHDN = Functions.GetDataToTable(sql);
            DataGridViewChitiet.DataSource = tblCTHDN;
            DataGridViewChitiet.Columns[0].HeaderText = "Mã thuốc";
            DataGridViewChitiet.Columns[1].HeaderText = "Tên thuốc";
            DataGridViewChitiet.Columns[2].HeaderText = "Số lượng";
            DataGridViewChitiet.Columns[3].HeaderText = "Đơn giá nhập";
            DataGridViewChitiet.Columns[4].HeaderText = "Thành tiền";
            DataGridViewChitiet.Columns[0].Width = 80;
            DataGridViewChitiet.Columns[1].Width = 130;
            DataGridViewChitiet.Columns[2].Width = 80;
            DataGridViewChitiet.Columns[3].Width = 90;
            DataGridViewChitiet.Columns[4].Width = 90;
            DataGridViewChitiet.AllowUserToAddRows = false;
            DataGridViewChitiet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmHoadonnhap_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            //txtMaHDN.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtTenthuoc.ReadOnly = true;
            txtDongianhap.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;

            txtTongtien.Text = "";

            Functions.FillCombo("SELECT MaNCC FROM tblNCC", cboMaNCC, "MaNCC", "TenNCC");
            cboMaNCC.SelectedIndex = -1;

            Functions.FillCombo("SELECT Manhanvien FROM tblNhanvien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;

            Functions.FillCombo("SELECT Mathuoc FROM tblThuoc", cboMathuoc, "Mathuoc", "Tenthuoc");
            cboMathuoc.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            //if (txtMaHDN.Text != "")
            //{
            //    LoadInfoHoadon();
            //    btnHuy.Enabled = true;
            //    btnIn.Enabled = true;
            //}
            LoadInfoHoadon();
            LoadDataGridView();
        }

        private void ResetValues() // Xóa trắng các texbox 
        {
            txtMaHDN.Text = "";
            //txtNgayban.Text = DateTime.Now.ToShortDateString();
            txtNgaynhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboManhanvien.Text = "";
            cboMaNCC.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMathuoc.Text = "";

            txtDongianhap.Text = ""; //********
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHDN.Text = Functions.CreateKey("HDN");
            LoadDataGridView();
            matudong();
        }

        private void matudong()
        {
            string g;
            if ( tblCTHDN.Rows.Count == 0)
            {
                g = "KC01";
            }
            else
            {
                int k;
                g = "KC";
                k = Convert.ToInt32(tblCTHDN.Rows[tblCTHDN.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k <= 10)
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            txtMaHDN.Text = g;
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select Tennhanvien from tblNhanvien where Manhanvien =N'" + cboManhanvien.SelectedValue + "'";
            txtTennhanvien.Text = Functions.GetFieldValues(str);
        }

        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }
            //Khi chọn Mã nhà cung cấp thì các thông tin của NCC sẽ hiện ra
            str = "Select TenNCC from tblNCC where MaNCC = N'" + cboMaNCC.SelectedValue + "'";
            txtTenNCC.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from tblNCC where MaNCC = N'" + cboMaNCC.SelectedValue + "'";
            txtDiachi.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from tblNCC where MaNCC= N'" + cboMaNCC.SelectedValue + "'";
            txtDienthoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMathuoc_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMathuoc.Text == "")
            {
                txtTenthuoc.Text = "";
                txtDongianhap.Text = "";
            }
            // Khi chọn mã thuốc thì các thông tin về thuốc hiện ra
            str = "SELECT Tenthuoc FROM tblThuoc WHERE Mathuoc =N'" + cboMathuoc.SelectedValue + "'";
            txtTenthuoc.Text = Functions.GetFieldValues(str);
            str = "SELECT Dongianhap FROM tblThuoc WHERE Mathuoc =N'" + cboMathuoc.SelectedValue + "'";
            txtDongianhap.Text = Functions.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            //sl=Convert.ToDouble(txtSoluong.Text);
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg ;
            txtThanhtien.Text = tt.ToString();
        }

        private void ResetValuesThuoc()
        {
            cboMathuoc.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi, gianhap, giaban;

            sql = "SELECT MaHDN FROM tblHDN WHERE MaHDN=N'" + txtMaHDN.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDNhap được sinh tự động do đó không có trường hợp trùng khóa
                if (txtNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgaynhap.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNCC.Focus();
                    return;
                }
                sql = "INSERT INTO tblHDN(MaHDN,Ngaynhap,Manhanvien,MaNCC, Tongtien) VALUES (N'" + txtMaHDN.Text.Trim() + "',N'" +
                       Functions.ConvertDateTime(txtNgaynhap.Text.Trim()) + "',N'" +
                        cboManhanvien.SelectedValue + "','" +
                        cboMaNCC.SelectedValue + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);
            }
            // Lưu thông tin của các loại thuốc nhập
            if (cboMathuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMathuoc.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }

            if (txtDongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Đơn giá của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongianhap.Focus();
                return;
            }
            //********
            sql = "SELECT Mathuoc FROM tblChitietHDN WHERE Mathuoc=N'" + cboMathuoc.SelectedValue + "' AND MaHDN = N'" + txtMaHDN.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thuốc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesThuoc();
                cboMathuoc.Focus();
                return;
            }
            // Kiểm tra xem số lượng thuốc trong kho còn không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblThuoc WHERE Mathuoc = N'" + cboMathuoc.SelectedValue + "'"));
            sql = "INSERT INTO tblChitietHDN(MaHDN,Mathuoc,MaNCC,Manhanvien,Ngaynhap,Soluong,Dongia,Thanhtien) VALUES(N'" + txtMaHDN.Text.Trim() + "',N'" + cboMathuoc.SelectedValue + "',N'" + cboMaNCC.SelectedValue + "',N'" + cboManhanvien.SelectedValue + "'," + txtNgaynhap.Text + "," + txtSoluong.Text + "," + txtDongianhap.Text + "," + txtThanhtien.Text + ")";
            Functions.RunSql(sql);

            LoadDataGridView();

            // cập nhật giá nhập của thuốc trong bảng tblThuoc khi nhập thuốc*********XEM LẠI
            gianhap = Convert.ToDouble(txtDongianhap.Text);
            sql = "UPDATE tblThuoc SET Dongianhap =" + gianhap + "WHERE Mathuoc= N'" + cboMathuoc.SelectedValue + "'";
            Functions.RunSql(sql);

            //Cập nhật giá bán của thuốc trong bảng tblThuoc khi nhập hàng
            gianhap = Convert.ToDouble(txtDongianhap.Text);
            giaban = gianhap * 110 / 100;
            sql = "UPDATE tblThuoc SET Dongiaban =" + giaban + "WHERE Mathuoc= N'" + cboMathuoc.SelectedValue + "'";
            Functions.RunSql(sql);


            // Cập nhật lại số lượng của thuốc vào bảng tblThuoc
            SLcon = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblThuoc SET Soluong =" + SLcon + " WHERE Mathuoc= N'" + cboMathuoc.SelectedValue + "'";
            Functions.RunSql(sql);

            // Cập nhật lại tổng tiền cho hóa đơn nhập
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM tblHDN WHERE MaHDN = N'" + txtMaHDN.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHDN SET Tongtien =" + Tongmoi + " WHERE MaHDN = N'" + txtMaHDN.Text + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesThuoc();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
        }

        private void DataGridViewChitiet_DoubleClick(object sender, EventArgs e)
        {
            string mathuoc;
            Double Thanhtien;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mathuoc = DataGridViewChitiet.CurrentRow.Cells["Mathuoc"].Value.ToString();
                DelThuoc(txtMaHDN.Text, mathuoc);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(DataGridViewChitiet.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMaHDN.Text, Thanhtien);
                LoadDataGridView();
            }
        }

        private void DelThuoc(string Mahoadon, string Mathuoc)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitietHDN WHERE MaHDN = N'" + Mahoadon + "' AND Mathuoc=N'" + Mathuoc + "'";
            s = Convert.ToDouble(Functions.GetFieldValues(sql));
            sql = "DELETE tblChitietHDN WHERE MaHDN=N'" + Mahoadon + "' AND MaHang = N'" + Mathuoc + "'";
            Functions.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT Soluong FROM tblThuoc WHERE Mathuoc = N'" + Mathuoc + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblThuoc SET Soluong =" + SLcon + " WHERE Mathuoc= N'" + Mathuoc + "'";
            Functions.RunSql(sql);
        }

        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHDN WHERE MaHDN = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHDN SET Tongtien =" + Tongmoi + " WHERE MaHDN = N'" + Mahoadon + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Mathuoc,Soluong FROM tblChitietHDN WHERE MaHDN= N'" + txtMaHDN.Text + "'";
                DataTable tblThuoc = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblThuoc.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các loại thuốc 
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblThuoc WHERE Mathuoc = N'" + tblThuoc.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblThuoc.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblThuoc SET Soluong =" + slcon + " WHERE Mathuoc= N'" + tblThuoc.Rows[hang][0].ToString() + "'";
                    Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChitietHDN WHERE MaHDN=N'" + txtMaHDN.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHDN WHERE MaHDN=N'" + txtMaHDN.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnHuy.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        //private void btnTimkiem_Click(object sender, EventArgs e)
        //{
        //    if (cboMaHDN.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cboMaHDN.Focus();
        //        return;
        //    }
        //    txtMaHDN.Text = cboMaHDN.Text;
        //    LoadInfoHoadon();
        //    LoadDataGridView();
        //    btnHuy.Enabled = true;
        //    btnLuu.Enabled = true;
        //    btnIn.Enabled = true;
        //    cboMaHDN.SelectedIndex = -1;
        //}

        //private void cboMaHDN_DropDown(object sender, EventArgs e)
        //{
        //    Functions.FillCombo("SELECT MaHDN FROM tblHDN", cboMaHDN, "MaHDN", "MaHDN");
        //    cboMaHDN.SelectedIndex = -1;
        //}

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int thuoc = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinThuoc;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quản lý phòng khám";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Bắc Ninh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 01645619738";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHDN, a.Ngaynhap, a.Tongtien, b.TenNCC, b.Diachi, b.Dienthoai, c.Tennhanvien FROM tblHDN AS a, tblNCC AS b, tblNhanvien AS c WHERE a.MaHDN = N'" + txtMaHDN.Text + "' AND a.MaNCC = b.MaNCC AND a.Manhanvien = c.Manhanvien";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenthuoc, a.Soluong, b.Dongianhap, a.Thanhtien " +
                  "FROM tblChitietHDN AS a , tblThuoc AS b WHERE a.MaHDN = N'" +
                  txtMaHDN.Text + "' AND a.Mathuoc = b.Mathuoc";
            tblThongtinThuoc = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên thuốc";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (thuoc = 0; thuoc < tblThongtinThuoc.Rows.Count; thuoc++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][thuoc + 12] = thuoc + 1;
                for (cot = 0; cot < tblThongtinThuoc.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][thuoc + 12] = tblThongtinThuoc.Rows[thuoc][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][thuoc + 12] = tblThongtinThuoc.Rows[thuoc][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][thuoc + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][thuoc + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][thuoc + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][thuoc + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán thuốc";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
