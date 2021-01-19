using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Models;

namespace TestTask
{
    public class TaskController : Controller
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstTask()
        {
            using (FirstTaskModel Task = new FirstTaskModel())
            {
                
                ViewBag.Array = Task.array;
                ViewBag.Sum = Task.Result();
            }
                return View();
        }

        public IActionResult SecondTask()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ThirdTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ThirdTask(string UserInput)
        {
            using (ThirdTask Task = new ThirdTask(UserInput))
            {
                return View("ThirdTaskResult", Task);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
