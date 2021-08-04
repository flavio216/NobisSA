using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Tramites
{
    public partial class frmEnviarMail : Form
    {
        public frmEnviarMail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txtPara.Text);
            mmsg.Subject = txtAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
           // mmsg.Bcc.Add(txtCc.Text);

            mmsg.Body = txtCuerpo.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("flavio_ezequiel54@hotmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("flavio_ezequiel54@hotmail.com", "lu749678529406efd7");
            cliente.Port = 25;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.live.com";

            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Se envio con exito");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar"+ ex);
            }
          
        }
    }
}
