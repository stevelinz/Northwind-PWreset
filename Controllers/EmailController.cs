using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Northwind.Models;

namespace Northwind.Controllers
{
    
    public class EmailController : Controller
    {
        string MailBody = "";
        string subject = "Northwind: Password Recovery";
        string mailTitle = "Northwind: Password Recovery";
        string fromEmail = "NWRecoveryWCTC@outlook.com";
        string fromEmailPassword = "ASzxc12#";
        
        public IActionResult Recover()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recover(string toEmail)
        {
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
            string reSetCode = RanNum(4);
            string userEmail = toEmail;

            /////////////////////////////////  need to add these to a Db maybe not the right way 
            // using (var ctx = new ResetContext())
            // {
            //     var rePW = new ResetPassword() {ResetPWemail = userEmail};

            //     ctx.ResetPasswords.Add(rePW);

            //     var reCode = new ResetPassword() {ResetCode = reSetCode};

            //     ctx.ResetPasswords.Add(reCode);

            //     ctx.SaveChanges();                
            // }
              
            ////////////////////////////////

            MailBody = "<!DOCTYPE html>" +
                              "<html> " +
                              "<body style=\"background -color:#ff7f26;text-align:center;\"> " +
                              "<h1 style=\"color:#051a80;\">Password Recovery</h1> " +
                              "<h2 style=\"color:#051a80;\">log back in and click on " +
                              "<b> Reset Password </b></h2> " +
                              "<h3 style=\"color:#051a80;\">enter code: " + reSetCode + " </h3> " +
                              "<h2 style=\"color:red;\"> " + "for login: " + userEmail +
                              " </h2> " + "</body> " + "</html>";
            message.Body = MailBody;
            message.IsBodyHtml = true;

            //Server Details
            SmtpClient smtp = new SmtpClient();
            //Outlook ports - 465 (SSL) or 587 (TLS)
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //Credentials
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
            credentials.UserName = fromEmail;
            credentials.Password = fromEmailPassword;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credentials;

            smtp.Send(message);

            ViewBag.EmailSentMessage = "Email sent successfully";

            return View();
        }
        private string RanNum(int length)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(rand.Next(0, 9));
            return sb.ToString();
        }
    }
}
