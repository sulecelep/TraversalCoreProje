﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _TotalRevenue:ViewComponent
    {
        Context c= new Context();   
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
