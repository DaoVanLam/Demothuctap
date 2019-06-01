using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Demothuctap.Forms
{
    public partial class frmHotro : Form
    {
        public frmHotro()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(txtUser.Text);
                mail.To.Add(txtTo.Text);
                mail.Subject = (txtTieude.Text == "") ? "No subject" : txtTieude.Text;
                mail.Body = txtNoidung.Text;
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(txtUser.Text.Trim(), txtPass.Text.Trim());
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                MessageBox.Show("Gửi email thành công đến: " + txtTo.Text);
            }
            catch
            {
                MessageBox.Show("Lổi xảy ra trong quá trình gửi mail");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
