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

namespace Demothuctap
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongDateString() + " _ " + DateTime.Now.ToLongTimeString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            if (Functions.tk == "admin")
                menuDMNV.Visible = true;
            else
                menuDMNV.Visible = false;
            timer1.Start();
        }       

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhanvien f = new Forms.frmNhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhachhang f = new Forms.frmKhachhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhacungcap f = new Forms.frmNhacungcap();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDN f = new Forms.frmTimHDN();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDB f = new Forms.frmTimHDB();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhómThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhomthuoc f = new Forms.frmNhomthuoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDVTinh f = new Forms.frmDVTinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tênThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmThuoc f = new Forms.frmThuoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHotro f = new Forms.frmHotro();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHoadonnhap f = new Forms.frmHoadonnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHoadonban f = new Forms.frmHoadonban();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaoDoanhthu f = new Forms.frmBaocaoDoanhthu();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaoHangton f = new Forms.frmBaocaoHangton();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void fanPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmfanpage f = new Forms.frmfanpage();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDoiMK f = new Forms.frmDoiMK();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void kếtQuảKinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaoKQKD f = new Forms.frmBaocaoKQKD();
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


    }
}
