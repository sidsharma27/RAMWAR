using MovieMadness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace MovieMadness.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Email em)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                    mail.To.Add("ramrar.help@gmail.com");
                    mail.From = new MailAddress(em.From);
                    mail.Subject = em.Subject;
                    mail.Body = em.Body;
                    mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("ramrar.help", "codercamps27");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Email sent!");
                return View("Index", em);
            }
            else
            {
                MessageBox.Show("Came across an issue sending your email");
                return View();
            }
        }
    }
}