using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace DesignerPainelDeControle
{
    class EnvioDeEmail
    {
        Attachment anexo;
        SmtpClient smtp = new SmtpClient();
        MailMessage mail = new MailMessage();

        public void EnviodeEmail(string Para, string Cc, string Cco, string Mensagem, string Assunto, string Anexos)
        {
            if(Anexos != "")
            {
                anexo = new Attachment(Anexos);
                mail.Attachments.Add(anexo);
            }
            

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("gerenciamentoprojetosacademy@gmail.com", "academy6658478");
            mail.From = new MailAddress("gerenciamentoprojetosacademy@gmail.com", "gerenciamentoprojetosacademy@gmail.com");
            mail.IsBodyHtml = true;

            if(!string.IsNullOrWhiteSpace(Para))
            {
                mail.To.Add(new MailAddress(Para));
            }
            if (!string.IsNullOrWhiteSpace(Cc))
            {
                mail.To.Add(new MailAddress(Cc));
            }
            if (!string.IsNullOrWhiteSpace(Cco))
            {
                mail.To.Add(new MailAddress(Cco));
            }

            mail.Subject = Assunto;
            mail.Body = Mensagem;
            smtp.Send(mail);
        }
    }
}
