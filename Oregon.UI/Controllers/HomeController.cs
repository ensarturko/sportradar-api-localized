using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oregon.Core.Infrastructure;
using Oregon.Core.Repository;

namespace Oregon.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITeamProfileRepository teamProfile;

        public HomeController(ITeamProfileRepository teamProfile)
        {
            this.teamProfile = teamProfile;
        }

        // GET: Home
        public ActionResult TeamProfile()
        {
            var result = teamProfile.GetById(1);

            return View();
        }
    }
}