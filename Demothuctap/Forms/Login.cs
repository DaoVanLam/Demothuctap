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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Baitapwinform\Demothuctap\Demothuctap\Data\TTCN1.mdf;Integrated Security=True");

            string sqlSelect = "Select * from tblTaikhoan where Taikhoan=N'" + txtTaiKhoan.Text + "'and Matkhau=N'" + txtMatKhau.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                Functions.tk = txtTaiKhoan.Text;
                this.Hide();
                Form main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Bạn hãy nhập lại !");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
