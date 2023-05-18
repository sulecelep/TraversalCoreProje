using AutoMapper.Internal;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPassword)
        {
            var user = await _userManager.FindByEmailAsync(forgetPassword.Mail);
            //Token benzersiz unique bir keydir. Bu key aracılığıyla Maile link gelecek.
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange",
                new
                {
                    userId = user.Id,
                    token = passwordResetToken,

                },HttpContext.Request.Scheme);
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("Traversal Admin", "traversalcore1907@gmail.com");
            mimeMessage.From.Add(mailboxAddress); //kimden geldi
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPassword.Mail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("traversalcore1907@gmail.com", "aaaa");
            client.Send(mimeMessage);
            client.Disconnect(true);



            return View();
        }
        [HttpGet]
        public IActionResult ResetPassword(string userid, string token)
        {
            TempData["userid"] = userid;
            TempData["token"] = token;
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPassword)
        {
            var userid = TempData["userid"].ToString();
            var token = TempData["token"].ToString();
            if(userid==null||token==null)
            {
                //hata mesajı
            }
            var user = await _userManager.FindByIdAsync(userid);
            var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
