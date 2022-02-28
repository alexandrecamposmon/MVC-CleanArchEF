using ChallengeTopic.ApplicationCore.Intefaces.Services;
using ChallengeTopic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTopic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITopicService topicService;
        public HomeController(ITopicService topicService)
        {
            this.topicService = topicService;
        }

        public IActionResult Index()
        {
            var topics = topicService.FindAll(0,100).ToList();
            return View(topics);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
