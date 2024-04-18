using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DOTNET_PROJECT.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;

        public EmailSender(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUsername = smtpUsername;
            _smtpPassword = smtpPassword;
        }

        // Implementing SendEmailAsync method
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            await SendEmailConfirmationAsync(email, subject); // Calling the SendEmailConfirmationAsync method
        }

        // Implementing SendEmailConfirmationAsync method
        public async Task SendEmailConfirmationAsync(string email, string subject)
        {
            var smtpClient = new SmtpClient(_smtpServer, _smtpPort)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpUsername, _smtpPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpUsername),
                Subject = subject,
                Body = "", // Empty body for confirmation email
                IsBodyHtml = true
            };
            mailMessage.To.Add(email);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
