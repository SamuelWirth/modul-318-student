using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace OVTool
{
    public partial class SendMail : Form
    {
        public SendMail(ListView resultate)
        {
            InitializeComponent();

            foreach (ListViewItem item in resultate.Items)
            {
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    rtbText.Text += subitem.Text + @"; ";
                }
                rtbText.Text += Environment.NewLine;
            }
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmailEmpfaenger.Text) || string.IsNullOrEmpty(rtbText.Text))
            {
                MessageBox.Show(@"Bitte alle Felder ausfüllen", @"Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var fromAddress = new MailAddress("swisstransportmail@gmail.com", "Swiss Transport");
                var toAddress = new MailAddress(tbEmailEmpfaenger.Text);
                const string fromPassword = "swisstransportpassword";
                string subject = tbBetreff.Text;
                string body = rtbText.Text;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                if (body != null)
                {
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                }
                MessageBox.Show(@"Mail wurde erfolgreich gesendet", @"Mail versendet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
