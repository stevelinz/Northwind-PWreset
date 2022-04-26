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
   
    public class EmailVerifyController : Controller
    {
           string codeVerifyTest = "0000";
         // this controller depends on the NorthwindRepository 
        private NorthwindContext _northwindContext; 

        ///////////////////////////////////
        public EmailVerifyController(NorthwindContext db) => _northwindContext = db;
        public IActionResult ResetComparePassword() => View(_northwindContext.ResetComparePasswords.OrderBy(r => r.ResetComparePWemail));
        public IActionResult Index(int id){
            ViewBag.id = id;
            return View(_northwindContext.ResetComparePasswords.OrderBy(c => c.ResetComparePWemail));
        }


        string MailBody = "";
        string subject = "Northwind: Password Reset Verification";
        string mailTitle = "Northwind: Password Reset Verification";
        string fromEmail = "NWRecoveryWCTC@outlook.com";
        string fromEmailPassword = "ASzxc12#";
        
       
        public IActionResult RecoverPair()
        {
            return View();
        }

        [HttpPost]
         
        public ViewResult RecoverPair(string toEmail, string codeVerifyTest ) 
        {
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
        
           ////////////////////  new behavior
           
            MailBody = "<!DOCTYPE html>" +
                              "<html> " +
                              "<body style=\"background -color:#ff7f26;text-align:center;\"> " +
                              "<h1 style=\"color:#051a80;\">Northwind: Password Reset Verification</h1> " +
                              "<h2 style=\"color:#051a80;\">log back in and " +
                              "<b> Verify Code and Email </b></h2> " +
                              "<h3 style=\"color:#051a80;\">enter code: " + codeVerifyTest +  " </h3> " +                    
                              "<h2 style=\"color:red;\"> " + "for login: " + toEmail + "</h2>" +                           
                              "</body> " + "</html>";
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

            ViewBag.EmailSentMessage = "Verification Email sent successfully";
            
            ResetComparePassword resetPwVerify = new ResetComparePassword 
            {
                    ResetComparePWemail = toEmail,
                    ResetCompareCode = codeVerifyTest
                  
            };

            _northwindContext.AddResetComparePassword(resetPwVerify);
            
            return View();
       
        }

    }
}
