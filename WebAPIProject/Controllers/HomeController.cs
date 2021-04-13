using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
         public ActionResult GetJsonDataModel()
    {
        var webClient = new WebClient();
        webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
        var json = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/todos");
        var objJson = JsonConvert.DeserializeObject<List<rootobject>>(json); //here we will map the Json to C# class
        //here we will return this model to view
        return View(objJson);  //you have to pass model to view
    }

        public ActionResult GetJsonCommentModel()
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/comments");
            var objJson = JsonConvert.DeserializeObject<List<comments>>(json); //here we will map the Json to C# class
                                                                                 //here we will return this model to view
            return View(objJson);  //you have to pass model to view
        }
        public ActionResult GetJsonAlbumModel()
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/albums");
            var objJson = JsonConvert.DeserializeObject<List<albums>>(json); //here we will map the Json to C# class
                                                                               //here we will return this model to view
            return View(objJson);  //you have to pass model to view
        }
    }

   
}
   


