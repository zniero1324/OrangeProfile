using Microsoft.AspNetCore.Mvc;
using OKProfile.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace OKProfile.Controllers
{

    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(EmailModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Create a new instance of the SmtpClient class.
                    SmtpClient smtpClient = new SmtpClient("smtp.your-email-provider.com", 587); // Replace with your SMTP server and port

                    // Specify the credentials.
                    smtpClient.Credentials = new NetworkCredential("your-email@example.com", "your-email-password"); // Replace with your email and password

                    // Enable SSL for secure email sending.
                    smtpClient.EnableSsl = true;

                    // Create a new MailMessage instance.
                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress("your-email@example.com"), // Replace with your email
                        Subject = model.Subject,
                        Body = model.Body,
                        IsBodyHtml = true // Set to true if you're sending an HTML email
                    };

                    // Add the recipient.
                    mailMessage.To.Add(model.ToEmail);

                    // Send the email.
                    smtpClient.Send(mailMessage);

                    // Notify the user that the email was sent.
                    ViewBag.Message = "Email sent successfully.";
                }
            }
            catch (Exception ex)
            {
                // Notify the user of an error.
                ViewBag.Message = "Error sending email: " + ex.Message;
            }

            return View(model);
        }
    }

}
