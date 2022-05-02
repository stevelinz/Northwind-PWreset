using System.Reflection.Metadata;
using System.Reflection.Emit;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Northwind.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;



namespace Northwind.Controllers
{
   
    public class EmailVerifyController : Controller
    {
         //  string codeVerifyTest = "0000";
         // this controller depends on the NorthwindRepository 
        private NorthwindContext _northwindContext; 
        private AppIdentityDbContext _appIdentityDbContext;


        ///////////////////////////////////
        public EmailVerifyController(NorthwindContext db, AppIdentityDbContext appIdentityDbContext)
        {
            _northwindContext = db;
            _appIdentityDbContext = appIdentityDbContext;
        }

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
         
        public async Task<ViewResult> RecoverPairAsync(string toEmail, string codeVerifyTest ) 
        {
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
        
           
            MailBody = "<!DOCTYPE html>" +
                              "<html> " +
                              "<body style=\"background -color:#ff7f26;text-align:left;\"> " +
                              "<h2 style=\"color:#051a80;\">Northwind: Password Reset Verification</h2></br> " +
                              "<h2 style=\"color:#051a80;\">The verification data entered was " +
                              "<h3 style=\"color:#051a80;\">4-digit numeric code: " + codeVerifyTest +  " </h3></br> " +                    
                              "<h3 style=\"color:red;\"> " + "Email of record: " + toEmail + "</h3>" + "</br>" + 
                              "If this information is correct, please proceed to the </br> Northwind Register page " +
                              "and re-register your company"+ "</br></br>" +
                              "If the information is incorrect, please re-apply </br> for a new 4-digit numeric verification code " +                          
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
                     
            
            int found = 0;
            
            int test1 = await _northwindContext.Database.ExecuteSqlRawAsync($"select * "
 
           +" FROM Northwind_35_SGL_FINAL.[dbo].ResetPasswords "
           +" LEFT JOIN Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords "
           +" ON Northwind_35_SGL_FINAL.[dbo].ResetPasswords.ResetPWemail = Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords.ResetComparePWemail "
           +" WHERE Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords.ResetComparePWemail = ResetPWemail ");

           if(test1 == -1){
                found = found + 1;
           }

           int test2 = await _northwindContext.Database.ExecuteSqlRawAsync($"select * "
 
           +" FROM Northwind_35_SGL_FINAL.[dbo].ResetPasswords "
           +" LEFT JOIN Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords "
           +" ON Northwind_35_SGL_FINAL.[dbo].ResetPasswords.ResetCode = Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords.ResetCompareCode "
           +" WHERE Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords.ResetComparePWemail = ResetPWemail ");

           if(test2 == -1){
                found = found + 1;
           }

             if(found == 2)
             {
                   int result0 = await _northwindContext.Database
                   .ExecuteSqlRawAsync($"delete from [Northwind_35_SGL_FINAL].[dbo].[Customers] where email = @p0",toEmail); 
                   int result1 = await _northwindContext.Database
                   .ExecuteSqlRawAsync($"delete from [Northwind_35_SGL_FINAL].[dbo].[ResetComparePasswords] where ResetComparePWemail = @p0",toEmail);
                   int result2 = await _northwindContext.Database
                   .ExecuteSqlRawAsync($"delete from [Northwind_35_SGL_FINAL].[dbo].[ResetPasswords] where ResetPWemail = ResetPWemail");
                   int result3 = await _appIdentityDbContext.Database
                   .ExecuteSqlRawAsync($"delete from [Identity_35_SGL_FINAL].[dbo].[AspNetUsers] where email = @p0",toEmail); 
                 
             }
            found = 0;

               
            return View();
       
        }

    }
}
