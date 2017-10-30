using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oregon.Core.Infrastructure;
using Oregon.Core.Repository;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeamProfileRepository teamProfileRepository;
        private readonly ITeamStatsRepository teamStatsRepository;


        public HomeController(ITeamProfileRepository teamProfileRepository, ITeamStatsRepository teamStatsRepository)
        {
            this.teamProfileRepository = teamProfileRepository;
            this.teamStatsRepository = teamStatsRepository;
        }

        // GET: Home
        public ActionResult TeamProfile()
        {
            const int firstCategory = 1;
            const int firstTeam = 1;

            var categoryId = GetValueFromQueryString("countryCode", firstCategory);
            var teamId = GetValueFromQueryString("teamId", firstTeam);

            var categories = teamProfileRepository.GetCategoryInfo();

            var selectedCategoryCode = categories.FirstOrDefault(q => q.Id == categoryId)?.Country_code;

            var countries = categories.Select(item => new SelectListItem
            {
                Text = item.Name,
                Value = item.Id.ToString(),
                Selected = item.Id == categoryId
            }).Distinct().ToList();

            var allTeams = teamProfileRepository.GetAllTeams();
            IEnumerable<Team> teams = null;

            if (categoryId > 0)
            {
                teams = allTeams.Where(q => q.Category.Country_code == selectedCategoryCode);
            }

            var countrysTeams = teams.Select(item => new SelectListItem
            {
                Text = item.Name,
                Value = item.Id.ToString(),
                Selected = item.Id == teamId
            }).Distinct().ToList();

            var exactTeam = countrysTeams.FirstOrDefault(m => m.Value == teamId.ToString());
            int exactTeamId;
            int.TryParse(exactTeam?.Value, out exactTeamId);
            var exactTeamProfile = teamProfileRepository.GetById(exactTeamId);
            //var exactTeamStatistics = teamStatsRepository.GetByStatsId(exactTeamId);


            ViewBag.Countries = countries;
            ViewBag.CountrysTeams = countrysTeams;
            ViewBag.ExactTeamProfile = exactTeamProfile;
            return View();
        }

        public ActionResult TeamStats()
        {
            const int firstCategory = 1;
            const int firstTeam = 1;

            var categoryId = GetValueFromQueryString("countryCode", firstCategory);
            var teamId = GetValueFromQueryString("teamId", firstTeam);

            var categories = teamProfileRepository.GetCategoryInfo();

            var selectedCategoryCode = categories.FirstOrDefault(q => q.Id == categoryId)?.Country_code;

            var countries = categories.Select(item => new SelectListItem
            {
                Text = item.Name,
                Value = item.Id.ToString(),
                Selected = item.Id == categoryId
            }).Distinct().ToList();

            var allTeams = teamProfileRepository.GetAllTeams();
            IEnumerable<Team> teams = null;

            if (categoryId > 0)
            {
                teams = allTeams.Where(q => q.Category.Country_code == selectedCategoryCode);
            }

            var countrysTeams = teams.Select(item => new SelectListItem
            {
                Text = item.Name,
                Value = item.Id.ToString(),
                Selected = item.Id == teamId
            }).Distinct().ToList();

            var exactTeam = countrysTeams.FirstOrDefault(m => m.Value == teamId.ToString());
            int exactTeamId;
            int.TryParse(exactTeam?.Value, out exactTeamId);

            var exactTeamStats = teamStatsRepository.GetByStatsId(exactTeamId);

            ViewBag.Countries = countries;
            ViewBag.CountrysTeams = countrysTeams;
            ViewBag.ExactTeamStats= exactTeamStats;
            return View();
        }

        private int GetValueFromQueryString(string param, int defaultValue)
        {
            string value = Request.QueryString.Get(param);

            try
            {
                return int.Parse(value);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}