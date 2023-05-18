using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	public class MailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(MailRequest mailRequest)
		{
			MimeMessage mimeMessage=new MimeMessage();
			MailboxAddress mailboxAddress = new MailboxAddress("Traversal Admin", "traversalcore1907@gmail.com");
			mimeMessage.From.Add(mailboxAddress); //kimden geldi
			MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.RecieverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder=new BodyBuilder();
			bodyBuilder.TextBody = mailRequest.Body;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject=mailRequest.Subject;
			SmtpClient client=new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("traversalcore1907@gmail.com", "jhfgdjhfg");
			client.Send(mimeMessage);
			client.Disconnect(true);

			return View();
		}
	}
}
