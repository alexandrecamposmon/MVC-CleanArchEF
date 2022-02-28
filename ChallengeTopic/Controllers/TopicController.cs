using ChallengeTopic.ApplicationCore.Intefaces.Services;
using ChallengeTopic.ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTopic.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicService topicService;
        public TopicController(ITopicService topicService)
        {
            this.topicService = topicService;
        }
        public IActionResult Index(int id)
        {
            var topic = topicService.GetByID(id);
            return View(topic);
        }
        public IActionResult New()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            var topic = topicService.GetByID(id);
            return View(topic);
        }
        public IActionResult DeleteConfirmation(int id)
        {
            var topic = topicService.GetByID(id);
            return View(topic);
        }

        [HttpPost]
        public IActionResult New(Topic topic)
        {
            topic.CriationDate = DateTime.Now;
            topicService.Add(topic);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Edit(Topic topic)
        {
            topicService.Update(topic);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Delete(int id)
        {
            topicService.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
