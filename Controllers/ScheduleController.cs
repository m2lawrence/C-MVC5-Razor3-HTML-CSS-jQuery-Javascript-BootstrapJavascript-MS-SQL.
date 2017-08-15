using WebAppSchedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSchedule.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            return View();
        }
    
        // GET: Step 2.
        public ActionResult Step2()
        {
            var Step2 = new WebAppSchedule.Models.Stage2();
            Step2.EventDate = DateTime.Now;

            if (Session["Step2"] != null)
            {
                Step2 = Session["Step2"] as WebAppSchedule.Models.Stage2;
            }
            return View(Step2);
        }
        
        // SET: Step 2.
        [HttpPost]
        public ActionResult Step2(Stage2 viewModel)
        {
            if (ModelState.IsValid)
            {
                Session.Add("Step2", viewModel); //if it's valid, then will store it and move on.
                return this.RedirectToAction("Step2");
            }
            return View(viewModel);
        }
    }
}
