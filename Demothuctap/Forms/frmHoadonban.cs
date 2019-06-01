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
using COMExcel = Microsoft.Office.Interop.Excel;
using Demothuctap.Class;

namespace Demothuctap.Forms
{
    public partial class frmHoadonban : Form
    {
        public frmHoadonban()
        {
            InitializeComponent();
        }

        DataTable tblCTHDB;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.Mathuoc, b.Tenthuoc, a.Soluong, b.Dongiaban,a.Thanhtien FROM tblChitietHDB AS a, tblThuoc AS b WHERE a.MaHDB = N'" + txtMaHDBan.Text + "' AND a.Mathuoc=b.Mathuoc";
            tblCTHDB = Functions.GetDataToTable(sql);
            DataGridViewChitiet.DataSource = tblCTHDB;
            DataGridViewChitiet.Columns[0].HeaderText = "Mã hàng";
            DataGridViewChitiet.Columns[1].HeaderText = "Tên hàng";
            DataGridViewChitiet.Columns[2].HeaderText = "Số lượng";
            DataGridViewChitiet.Columns[3].HeaderText = "Đơn giá";
            DataGridViewChitiet.Columns[4].HeaderText = "Thành tiền";
            DataGridViewChitiet.Columns[0].Width = 80;
            DataGridViewChitiet.Columns[1].Width = 130;
            DataGridViewChitiet.Columns[2].Width = 80;
            DataGridViewChitiet.Columns[3].Width = 90;
            DataGridViewChitiet.Columns[4].Width = 90;
            DataGridViewChitiet.AllowUserToAddRows = false;
            DataGridViewChitiet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoadon()
        {
            string str;
            str = "SELECT Ngayban FROM tblHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
            txtNgayban.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "SELECT Manhanvien FROM tblHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
            cboManhanvien.Text = Functions.GetFieldValues(str);
            str = "SELECT Makhach FROM tblHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
            cboMakhach.Text = Functions.GetFieldValues(str);
            str = "SELECT Tongtien FROM tblHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
            txtTongtien.Text = Functions.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void frmHoadonban_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtMaHDBan.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenkhach.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtTenthuoc.ReadOnly = true;
            txtDongiaban.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtTongtien.Text = "0";
            Functions.FillCombo("SELECT Makhach FROM tblKhachhang", cboMakhach, "Makhach", "Tenkhach");
            cboMakhach.SelectedIndex = -1;
            Functions.FillCombo("SELECT Manhanvien FROM tblNhanvien", cboManhanvien, "Manhanvien", "Tennhanvien");
            cboManhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT Mathuoc FROM tblThuoc", cboMathuoc, "Mathuoc", "Tenthuoc");
            cboMathuoc.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoadon();
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaHDBan.Text = "";
            txtNgayban.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboMakhach.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMathuoc.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHDBan.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }
        private void ResetValuesThuoc()
        {
            cboMathuoc.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "0";
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

        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMakhach.Text == "")
            {
                txtTenkhach.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select Tenkhach from tblKhachhang where Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtTenkhach.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from tblKhachhang where Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtDiachi.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where Makhach= N'" + cboMakhach.SelectedValue + "'";
            txtDienthoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMathuoc_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMathuoc.Text == "")
            {
                txtTenthuoc.Text = "";
                txtDongiaban.Text = "";
            }
            // Khi chọn mã thuốc thì các thông tin về thuốc hiện ra
            str = "SELECT Tenthuoc FROM tblThuoc WHERE Mathuoc =N'" + cboMathuoc.SelectedValue + "'";
            txtTenthuoc.Text = Functions.GetFieldValues(str);
            str = "SELECT Dongiaban FROM tblThuoc WHERE Mathuoc =N'" + cboMathuoc.SelectedValue + "'";
            txtDongiaban.Text = Functions.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtDongiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongiaban.Text);
            tt = sl * dg ;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDB FROM tblHDB WHERE MaHDB=N'" + txtMaHDBan.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtNgayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayban.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMakhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMakhach.Focus();
                    return;
                }
                sql = "INSERT INTO tblHDB(MaHDB,Ngayban,Manhanvien,Makhach,Tongtien) VALUES (N'" + txtMaHDBan.Text.Trim() + "',N'" +
                       Functions.ConvertDateTime(txtNgayban.Text.Trim()) + "',N'" +
                        cboManhanvien.SelectedValue + "','" +
                        cboMakhach.SelectedValue + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);
            }
            // Lưu thông tin của các loại thuốc
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

            sql = "SELECT Mathuoc FROM tblChitietHDB WHERE Mathuoc=N'" + cboMathuoc.SelectedValue + "' AND MaHDB = N'" + txtMaHDBan.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thuốc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesThuoc();
                cboMathuoc.Focus();
                return;
            }
            // Kiểm tra xem số lượng thuốc trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblThuoc WHERE Mathuoc = N'" + cboMathuoc.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng loại thuốc này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            //Trước chạy được, sao tự dưng lại lỗi ???
            sql = "INSERT INTO tblChitietHDB(MaHDB,Mathuoc,Makhach,Manhanvien,Ngayban,Soluong,Dongia,Thanhtien) VALUES(N'" + txtMaHDBan.Text.Trim() + "',N'" + cboMathuoc.SelectedValue + "',N'" + cboMakhach.SelectedValue + "',N'" + cboManhanvien.SelectedValue + "','" +Functions.ConvertDateTime( txtNgayban.Text )+ "'," + txtSoluong.Text + "," + txtDongiaban.Text + "," + txtThanhtien.Text + ")";
            Functions.RunSql(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của thuốc vào bảng tblDanhmucThuoc
            SLcon = sl - Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblThuoc SET Soluong =" + SLcon + " WHERE Mathuoc= N'" + cboMathuoc.SelectedValue + "'";
            Functions.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM tblHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHDB SET Tongtien =" + Tongmoi + " WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
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
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mathuoc = DataGridViewChitiet.CurrentRow.Cells["Mathuoc"].Value.ToString();
                DelThuoc(txtMaHDBan.Text, mathuoc);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(DataGridViewChitiet.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMaHDBan.Text, Thanhtien);
                LoadDataGridView();
            }
        }

        private void DelThuoc(string Mahoadon, string Mathuoc)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitietHDB WHERE MaHDB = N'" + Mahoadon + "' AND Mathuoc=N'" + Mathuoc + "'";
            s = Convert.ToDouble(Functions.GetFieldValues(sql));
            sql = "DELETE tblChitietHDB WHERE MaHDB=N'" + Mahoadon + "' AND Mathuoc = N'" + Mathuoc + "'";
            Functions.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT Soluong FROM tblThuoc WHERE Mthuoc= N'" + Mathuoc + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblThuoc SET Soluong =" + SLcon + " WHERE Mathuoc= N'" + Mathuoc + "'";
            Functions.RunSql(sql);
        }

        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHDB WHERE MaHDB = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHDB SET Tongtien =" + Tongmoi + " WHERE MaHDB = N'" +
Mahoadon + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Mathuoc,Soluong FROM tblChitietHDB WHERE MaHDB = N'" + txtMaHDBan.Text + "'";
                DataTable tblThuoc = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblThuoc.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblThuoc WHERE Mathuoc = N'" + tblThuoc.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblThuoc.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblThuoc SET Soluong =" + slcon + " WHERE Mathuoc= N'" + tblThuoc.Rows[hang][0].ToString() + "'";
                    Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChitietHDB WHERE MaHDB=N'" + txtMaHDBan.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHDB WHERE MaHDB=N'" + txtMaHDBan.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnHuy.Enabled = false;
                btnIn.Enabled = false;
            }
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
            sql = "SELECT a.MaHDB, a.Ngayban, a.Tongtien, b.Tenkhach, b.Diachi, b.Dienthoai, c.Tennhanvien FROM tblHDB AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.MaHDB = N'" + txtMaHDBan.Text + "' AND a.Makhach = b.Makhach AND a.Manhanvien = c.Manhanvien";
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
            sql = "SELECT b.Tenthuoc, a.Soluong, b.Dongiaban, a.Thanhtien " +
                  "FROM tblChitietHDB AS a , tblThuoc AS b WHERE a.MaHDB = N'" +
                  txtMaHDBan.Text + "' AND a.Mathuoc = b.Mathuoc";
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
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;
        }

        //private void btnTimkiem_Click(object sender, EventArgs e)
        //{
        //    if (cboMaHDBan.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cboMaHDBan.Focus();
        //        return;
        //    }
        //    txtMaHDBan.Text = cboMaHDBan.Text;
        //    LoadInfoHoadon();
        //    LoadDataGridView();
        //    btnHuy.Enabled = true;
        //    btnLuu.Enabled = true;
        //    btnIn.Enabled = true;
        //    cboMaHDBan.SelectedIndex = -1;
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        //private void cboMaHDBan_DropDown(object sender, EventArgs e)
        //{
        //    Functions.FillCombo("SELECT MaHDB FROM tblHDB", cboMaHDBan, "MaHDB", "MaHDB");
        //    cboMaHDBan.SelectedIndex = -1;
        //}

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
