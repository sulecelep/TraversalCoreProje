using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            //ViewBag.commentCount=context.Comments.Where(x=>x.DestinationID==id).Count();    Böyle de yapılabilir.
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            ViewBag.v = values.Count();
            return View(values);
        }
    }
}
