
using Demothuctap.Class;
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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMKcu.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ.");
                return;
            }
            if (txtMKmoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới.");
                return;
            }
            if (txtxacnhan.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới.");
                return;
            }

            if (txtMKmoi.Text.Trim() != txtxacnhan.Text.Trim())
            {
                MessageBox.Show("Mật khẩu nhập lại khác mật khẩu trên.");
                return;
            }

            Functions.RunSql("Update tblTaikhoan set Matkhau = '" + txtMKmoi.Text + "' where Taikhoan = '" + Functions.tk + "'");
            MessageBox.Show("Thay đổi mật khẩu thành công.");
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
