using MailKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading;
using System.Threading.Tasks;
using ThesisProject.WebApp.Options;

namespace ThesisProject.WebApp.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings) => this._emailSettings = emailSettings.Value;

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add((InternetAddress)new MailboxAddress(this._emailSettings.Login, this._emailSettings.Login));
                mimeMessage.To.Add((InternetAddress)new MailboxAddress(subject, email));
                mimeMessage.Subject = subject;
                mimeMessage.Body = (MimeEntity)new TextPart("html")
                {
                    Text = htmlMessage
                };
                using (SmtpClient client = new SmtpClient())
                {
                    await client.ConnectAsync(this._emailSettings.Host, this._emailSettings.Port, this._emailSettings.UseSSL, new CancellationToken());
                    await client.AuthenticateAsync(this._emailSettings.Login, this._emailSettings.Password, new CancellationToken());
                    await client.SendAsync(mimeMessage, new CancellationToken(), (ITransferProgress)null);
                    await client.DisconnectAsync(true, new CancellationToken());
                }
                mimeMessage = (MimeMessage)null;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}