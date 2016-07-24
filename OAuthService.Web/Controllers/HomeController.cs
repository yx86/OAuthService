﻿using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OAuthService.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<ActionResult> Private()
        {
            var claimsPrincipal = User as ClaimsPrincipal;

            //using (var client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Authorization =
            //        new AuthenticationHeaderValue("Bearer", 
            //        claimsPrincipal.FindFirst("access_token").Value);

            //    var profile = await client.GetAsync("http://localhost:3467/api/Profiles");

            //    var profileContent = await profile.Content.ReadAsStringAsync();
            //}

            return View(claimsPrincipal.Claims);
        }
    }
}