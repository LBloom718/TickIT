using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TickIT.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tickets = new List<Ticket>();
            var ticket1 = new Ticket
            {
                Date = DateTime.Now,
                Description  = "My computer wont turn on.",
                Status = Status.OPEN,
                Area = Area.HARDWARE 
      

            };
            tickets.Add(ticket1);
            return View(tickets);


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}