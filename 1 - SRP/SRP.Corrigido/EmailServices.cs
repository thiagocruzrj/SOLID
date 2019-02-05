﻿using System.Net.Mail;

namespace SOLID._1___SRP.SRP.Corrigido
{
    public static class EmailServices
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Send(string from, string to, string subject, string message)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            client.Send(mail);
        }
    }
}
