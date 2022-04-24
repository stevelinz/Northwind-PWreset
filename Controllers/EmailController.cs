using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Northwind.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Northwind.Controllers
{
    
    public class EmailController : Controller
    {
         // this controller depends on the NorthwindRepository //linz
        private NorthwindContext _northwindContext; //linz

         public EmailController(NorthwindContext db) //linz
        {
            _northwindContext = db; 
        }
        string MailBody = "";
        string subject = "Northwind: Password Recovery";
        string mailTitle = "Northwind: Password Recovery";
        string fromEmail = "NWRecoveryWCTC@outlook.com";
        string fromEmailPassword = "ASzxc12#";
        
        public IActionResult Recover()
        {
            return View();
        }

        string resetCode = RanNum(4);
        [HttpPost]
         
        public IActionResult Recover(string toEmail, string resetCode)
        {
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
        
            ///////////////////////////////// linz
          //  string resetCode = RanNum(4);
            ResetPassword resetPassword = new ResetPassword
            {
                ResetPWemail = toEmail,   
                ResetCode = resetCode
            };

           _northwindContext.AddResetPassword(resetPassword);
            
            /////////////////////////////////

            MailBody = "<!DOCTYPE html>" +
                              "<html> " +
                              "<body style=\"background -color:#ff7f26;text-align:center;\"> " +
                              "<h1 style=\"color:#051a80;\">Password Recovery</h1> " +
                              "<h2 style=\"color:#051a80;\">log back in and click on " +
                              "<b> Reset Password </b></h2> " +
                              "<h3 style=\"color:#051a80;\">enter code: " + resetCode + " </h3> " +
                              "<h2 style=\"color:red;\"> " + "for login: " + toEmail +
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
        public static string RanNum(int length)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(rand.Next(0, 9));
            return sb.ToString();
        }
    }
}
