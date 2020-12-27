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

namespace Retail_Management_System.Screens
{
    public partial class ResetAdmin : Form
    {
        public Func<bool,bool> onDispose;
        private static string _code;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public ResetAdmin()
        {
            InitializeComponent();
            ResetAdmin._code = RandomString(16);
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_txt.Text) || string.IsNullOrEmpty(email_txt.Text)) { return; }
            string htmlString = $@"<h3>Verification code</h3><a>{_code}</a>";
            Email(htmlString, email_txt.Text);
        }
        public void Email(string htmlString,string email)
        {
            System.Threading.Thread.Sleep(2000);
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("palihug.company@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Verification Code";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("palihug.company@gmail.com", "4244124M@rk");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show($"Verification sent to {email}");
                EnableBtns(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed");
            }
        }
        private void EnableBtns(bool state)
        {
            verification_code.Enabled = state;
            continue_btn.Enabled = state;
        }
        private void ResetAdmin_Load(object sender, EventArgs e)
        {
            EnableBtns(false);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            if(_code == verification_code.Text)
            {
                this.Dispose();
                onDispose(true);
            } else
            {
                onDispose(false);
            }
        }
    }
}
