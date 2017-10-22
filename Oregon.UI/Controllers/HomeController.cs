using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oregon.Core.Repository;

namespace Oregon.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TeamProfile()
        {
            TeamProfileRepository teamProfile = new TeamProfileRepository();

            var result = teamProfile.GetById(1);

            return View();
        }
    }
}