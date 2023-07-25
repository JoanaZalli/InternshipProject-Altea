using Application.Contracts;
using Application.DTOS;
using Application.Models;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpServer;
        private readonly int _smpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;


        public EmailService(IOptions<SmtpConfig> smtpConfigOptions)
        {
            var smtpConfig = smtpConfigOptions.Value;
            _smtpServer = smtpConfig.SmtpServer;
            _smpPort = smtpConfig.SmtpPort;
            _smtpUsername = smtpConfig.SmtpUsername;
            _smtpPassword = smtpConfig.SmtpPassword;
        }
       
        public async Task SendEmailAsync(string email, string subject, string body)
        {
            using (var message = new MailMessage())
            {

                message.From = new MailAddress(_smtpUsername);
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;


                using (var smtpClient = new SmtpClient(_smtpServer, _smpPort))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    smtpClient.EnableSsl = true;

                    await smtpClient.SendMailAsync(message);
                }
            }
        }

    }
}
