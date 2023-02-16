using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
public class MultyMailer
{
   

    public void SendEmail(string anyEmail,string name)
    {
        var email =new MimeMessage();
        email.From.Add(MailboxAddress.Parse("kabamouri824@gmail.com"));
        email.To.Add(MailboxAddress.Parse(anyEmail));
        email.Subject = "Resumption";
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = $"<p>Dear {name},</p><p>We are happy to have you in our organisation</p>"
        };

        using var smtp = new SmtpClient();
        smtp.Connect("smtp.gmail.com",465,useSsl: true);
       smtp.Authenticate("kabamouri824@gmail.com","");

       smtp.Send(email);
       smtp.Disconnect(true);
    }
    
}