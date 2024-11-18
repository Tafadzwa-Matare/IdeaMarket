using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ideaMarket.Email
{
    public class DevEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ideamarket.ict@gmail.com", "th1nkb1g"),
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true
        };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("account-security-noreply@IdeaMarket.com")
            };
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = htmlMessage;
            return client.SendMailAsync(mailMessage);
        }
    }
}
