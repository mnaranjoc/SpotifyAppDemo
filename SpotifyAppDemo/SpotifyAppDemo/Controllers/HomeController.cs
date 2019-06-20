using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpotifyAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.AuthUri = GetAuthUri();

            return View();
        }

        private string GetAuthUri()
        {
            string clientId = "b49eac7e20ae4dac90a11f528089c830";
            string redirectUri = "http://localhost:54034/";
            //string scope = "playlist_modify_private";//Scope scope = Scope.PLAYLIST_MODIFY_PRIVATE;

            return "https://accounts.spotify.com/en/authorize?client_id=" + clientId +
                "&response_type=token&redirect_uri=" + redirectUri +
                //"&state=&scope=" + scope + //scope.GetStringAttribute() +
                "&show_dialog=true";
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