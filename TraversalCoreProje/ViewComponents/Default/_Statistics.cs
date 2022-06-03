using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.destinationCount = c.Destinations.Count();
            ViewBag.guidesCount = c.Guides.Count();
            ViewBag.customerCount = "298";

            return View();
        }
    }
}
