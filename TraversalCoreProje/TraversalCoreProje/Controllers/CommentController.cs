using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController( UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
           // ViewBag.destID=id;
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            //p.DestinationID = 3;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
