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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Demothuctap.Forms
{
    public partial class frmBaocaoHangton : Form
    {
        public frmBaocaoHangton()
        {
            InitializeComponent();
        }

        DataTable tblHT;

        private void frmBaocaoHangton_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("select Mathuoc, Tenthuoc from tblThuoc", cboTenthuoc, "Mathuoc", "Tenthuoc");
            cboTenthuoc.SelectedIndex = -1;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT Mathuoc, Tenthuoc , Soluong, Dongianhap, Dongiaban FROM tblThuoc ";
            DataTable tblTV;
            tblTV = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblTV;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT Mathuoc, Tenthuoc,Soluong, Dongianhap, Dongiaban FROM tblThuoc ";

            DataTable tblTV;
            tblTV = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblTV;

            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;

            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["A1:B1"].Value = "Quản Lý Phòng Khám";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Xuân thụ - Bắc Ninh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 01674888948";

            exRange.Range["B6:F7"].Font.Size = 16;
            exRange.Range["B6:F7"].Font.Name = "Times new roman";
            exRange.Range["B6:F7"].Font.Bold = true;
            exRange.Range["B6:F7"].Font.ColorIndex = 3;
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["B7:F7"].MergeCells = true;
            exRange.Range["B6:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["C6:E6"].Value = "HÀNG TỒN KHO";
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["A11:A11"].ColumnWidth = 8;
            exRange.Range["B11:B11"].ColumnWidth = 12;
            exRange.Range["C11:C11"].ColumnWidth = 24;
            exRange.Range["D11:E11"].ColumnWidth = 12;
            exRange.Range["F11:F11"].ColumnWidth = 26;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã thuốc";
            exRange.Range["C11:C11"].Value = "Tên thuốc";
            exRange.Range["D11:D11"].Value = "Số lượng còn";
            exRange.Range["E11:E11"].Value = "Đơn giá nhập";
            exRange.Range["F11:F11"].Value = "Đơn giá bán";

            exRange = exSheet.Cells[1][hang + 11];
            exRange.Range["A1:F" + (tblTV.Rows.Count + 1) + ""].Borders.Color = Color.Black;
            exRange.Range["A2:F" + (tblTV.Rows.Count + 1) + ""].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange = exSheet.Cells[1, 1];

            for (hang = 0; hang <= tblTV.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= 4; cot++)
                    exSheet.Cells[cot + 2][hang + 12] = tblTV.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTenthuoc_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboTenthuoc.Text == "")
            {
                txtSoluong.Text = "";
            }
            str = "select Soluong from tblThuoc where Mathuoc=N'" + cboTenthuoc.SelectedValue + "'";
            txtSoluong.Text = Functions.GetFieldValues(str);
        }
    }
}
