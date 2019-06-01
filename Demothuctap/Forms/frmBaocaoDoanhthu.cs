using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demothuctap.Class;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Demothuctap.Forms
{
    public partial class frmBaocaoDoanhthu : Form
    {
        public frmBaocaoDoanhthu()
        {
            InitializeComponent();
        }

        DataTable tblBCHDB;
        DataTable tblDT;

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblHDB";
            tblBCHDB = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblBCHDB;
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn bán";
            DataGridView.Columns[1].HeaderText = "Ngày bán";
            DataGridView.Columns[2].HeaderText = "Mã nhân viên";
            DataGridView.Columns[3].HeaderText = "Mã khách";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";

            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmBaocaoDoanhthu_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            cboDK.Enabled = true;
            cboThang.Enabled = false;
            txtNam.Enabled = false;

            cboDK.Items.Add("Thang");
            cboDK.Items.Add("Nam");

            cboThang.Items.Add("1");
            cboThang.Items.Add("2");
            cboThang.Items.Add("3");
            cboThang.Items.Add("4");
            cboThang.Items.Add("5");
            cboThang.Items.Add("6");
            cboThang.Items.Add("7");
            cboThang.Items.Add("8");
            cboThang.Items.Add("9");
            cboThang.Items.Add("10");
            cboThang.Items.Add("11");
            cboThang.Items.Add("12");

            load_datagrid();
    
            //txtThang.ReadOnly = true;

        }

        private void load_datagrid()
        {
            string sql;
            sql = "select distinct month(Ngayban),year(Ngayban) from tblHDB";
            tblDT = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblDT;
            dataGridView1.Columns[0].HeaderText = "Tháng";
            dataGridView1.Columns[1].HeaderText = "Năm";
            dataGridView1.Columns[0].Width = 58;
            dataGridView1.Columns[1].Width = 75;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            cboThang.Text = "";
            txtNam.Text = "";
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void cboDK_TextChanged(object sender, EventArgs e)
        {
            if (cboDK.Text.Trim() == "Thang")
            {
                txtNam.Enabled = true;
                cboThang.Enabled = true;
            }
            if (cboDK.Text.Trim() == "Nam")
            {
                txtNam.Enabled = true;
                cboThang.Enabled = false;
            }
            //    if (cboDK.Text.Trim() == "Quy")
            //{
            //    txtNam.Enabled = true;
            //    cboThang.Enabled = false;
            //    cboQuy.Enabled = true;
            //}
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            //if (cboDK.Text.Trim() == "Quy")
            //{
            //    if (txtNam.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    if (cboQuy.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Nhập điều kiện quý!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    string sql;
            //    sql = "Select a.MaHDB, a.Mathuoc, b.Tenthuoc, b.Dongiaban, c.Tongtien FROM tblChitietHDB as a, tblThuoc as b, tblHDB as c WHERE a.Mathuoc=b.Mathuoc and a.MaHDB=c.MaHDB AND(YEAR(c.Ngayban)="+ txtNam.Text + ") AND (QUARTER(c.Ngayban)=" + cboQuy.Text + "  ) ORDER BY c.Tongtien asc";
            //    DataTable tblH;
            //    tblH = Functions.GetDataToTable(sql);
            //    DataGridView.DataSource = tblH;
            //}
            if (cboDK.Text.Trim() == "Nam")
            {
                if (txtNam.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql;
                sql = "Select a.MaHDB, a.Mathuoc, b.Tenthuoc, b.Dongiaban, c.Tongtien FROM tblChitietHDB as a, tblThuoc as b, tblHDB as c WHERE a.Mathuoc=b.Mathuoc and a.MaHDB=c.MaHDB AND(YEAR(c.Ngayban)="+ txtNam.Text + ")  ORDER BY c.Tongtien asc";
                DataTable tblH;
                tblH = Functions.GetDataToTable(sql);
                DataGridView.DataSource = tblH;
            }
            if (cboDK.Text.Trim() == "Thang")
            {
                if (txtNam.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboThang.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện tháng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql;
                sql = "Select a.MaHDB, a.Mathuoc, b.Tenthuoc, b.Dongiaban, c.Tongtien FROM tblChitietHDB as a, tblThuoc as b, tblHDB as c WHERE a.Mathuoc=b.Mathuoc and a.MaHDB=c.MaHDB AND(YEAR(c.Ngayban)="+ txtNam.Text + "  ) AND (MONTH(c.Ngayban)  =" + cboThang.Text + "  ) ORDER BY c.Tongtien asc";
                DataTable tblH;
                tblH = Functions.GetDataToTable(sql);
                DataGridView.DataSource = tblH;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            double dt, giagoc, lai;
            string sql;
            if (txtThang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần phải nhập tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThang.Focus();
                return;
            }
            if (txtNam.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần phải nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNam.Focus();
                return;
            }
            sql = "select sum(Tongtien) from tblHDB where 1=1";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(Ngayban) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngayban) =" + txtNam.Text;
            dt = Convert.ToDouble(Functions.GetFieldValues(sql));
            txtdoanhthu2.Text = dt.ToString();
            giagoc = Convert.ToDouble(Functions.GetFieldValues("select sum(a.Dongiaban ) from tblThuoc as a, tblChitietHDB as b,tblHDB as c where a.Mathuoc=b.Mathuoc and b.MaHDB=c.MaHDB and (month(c.Ngayban)=" + txtThang.Text + " and year(c.Ngayban)=" + txtNam.Text + ")"));
            lai = dt - giagoc;
            txtloinhuan2.Text = lai.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtThang.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            txtNam.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            txtdoanhthu2.Text = "";
        }

        private void cboThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                MessageBox.Show("Bạn phải chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach, doanhthu;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quản Lý Phòng Khám";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Xuân Thụ - Bắc Ninh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 01674888948";
            exRange.Range["A7:A7"].Font.Bold = true;
            exRange.Range["A7:A7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B7:B7"].Font.Bold = true;
            exRange.Range["B7:B7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A7:A7"].Value = "Tháng: ";
            exRange.Range["B7:B7"].Value = txtThang.Text;
            exRange.Range["B5:F5"].Font.Size = 16;
            exRange.Range["B5:F5"].Font.Bold = true;
            exRange.Range["B5:F5"].Font.ColorIndex = 3;
            exRange.Range["B5:F5"].MergeCells = true;
            exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:F5"].Value = "BÁO CÁO DOANH THU";
            sql = "select distinct b.Mathuoc, b.Tenthuoc, sum(a.Soluong), sum(a.Thanhtien) from tblChitietHDB as a, tblThuoc as b, tblHDB as c where a.Mathuoc=b.Mathuoc and a.MaHDB=c.MaHDB and month(c.Ngayban)=" + txtThang.Text + " and year(c.Ngayban)=" + txtNam.Text + " group by b.Mathuoc,b.Tenthuoc";
            danhsach = Functions.GetDataToTable(sql);
            exRange.Range["A9:F9"].Font.Bold = true;
            exRange.Range["A9:F9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B9:B9"].ColumnWidth = 12;
            exRange.Range["C9:C9"].ColumnWidth = 18;
            exRange.Range["D9:D9"].ColumnWidth = 12;
            exRange.Range["E9:E9"].ColumnWidth = 15;
            exRange.Range["F9:F9"].ColumnWidth = 12;
            exRange.Range["A9:A9"].Value = "STT";
            exRange.Range["B9:B9"].Value = "Mã thuốc";
            exRange.Range["C9:C9"].Value = "Tên thuốc";
            exRange.Range["D9:D9"].Value = "Số lượng bán";
            exRange.Range["E9:E9"].Value = "Đơn giá bán";

            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 10] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 10] = danhsach.Rows[hang][cot].ToString();
                }
            }
            sql = "select sum(Tongtien) from tblHDB where month(Ngayban)=" + txtThang.Text + " and year(Ngayban)=" + txtNam.Text + "";
            doanhthu = Functions.GetDataToTable(sql);
            exRange = exSheet.Cells[1][hang + 12];
            exRange.Range["E1:E1"].Font.Bold = true;
            exRange.Range["E1:E1"].Value = "Tổng doanh thu =";
            exRange.Range["F1:F1"].Value = doanhthu.Rows[0][0].ToString();
            double dt, ln, giagoc;
            sql = "select sum(b.Dongiaban ) from tblChitietHDB as a, tblThuoc as b, tblHDB as c where a.Mathuoc=b.Mathuoc and a.MaHDB=c.MaHDB and month(c.Ngayban)=" + txtThang.Text + " and year(c.Ngayban)=" + txtNam.Text + "";
            dt = Convert.ToDouble(Functions.GetFieldValues("select sum(Tongtien) from tblHDB where month(Ngayban)=" + txtThang.Text + " and year(Ngayban)=" + txtNam.Text + ""));
            giagoc = Convert.ToDouble(Functions.GetFieldValues(sql));
            ln = dt - giagoc;
            exRange = exSheet.Cells[1][hang + 13];
            exRange.Range["E1:E1"].Font.Bold = true;
            exRange.Range["E1:E1"].Value = "Lợi nhuận =";
            exRange.Range["F1:F1"].Value = ln.ToString();
            exRange = exSheet.Cells[1][hang + 15];
            exRange.Range["E1:F1"].MergeCells = true;
            exRange.Range["E1:F1"].Font.Italic = true;
            exRange.Range["E1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
