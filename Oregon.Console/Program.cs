using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oregon.Core.Repository;
using Oregon.Data.Model;

namespace Oregon.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamProfileRepository = new TeamProfileRepository();

            using (WebClient wc = new WebClient())
            {
                var jsonString = wc.DownloadString("https://api.sportradar.us/soccer-t3/eu/tr/teams/sr:competitor:3052/profile.json?api_key=pqs6242mdsk3u3t95kuwy2xu");
                var objData = JsonConvert.DeserializeObject<TeamProfileModel>(jsonString);

                teamProfileRepository.Insert(objData);
                teamProfileRepository.Save();
            }

        }
    }
}
