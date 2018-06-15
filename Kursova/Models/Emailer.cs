using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Kursova.Models
{
    public class Emailer
    {
        //public static string Email { get { return "pytchak.md@gmail.com"; } }
        public static void Send(string subject, string text,string Email)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(Email);
            mail.Subject = subject; ;
            mail.Body = text;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mail);
        }
    }
}