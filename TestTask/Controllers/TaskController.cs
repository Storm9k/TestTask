using System;
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
            using (FirstTaskModel ft = new FirstTaskModel())
            {
                return View(ft);
            }
        }

        public IActionResult SecondTask()
        {
            using (SecondTaskModel st = new SecondTaskModel())
            {

                return View(st);
            }
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
                if (!String.IsNullOrEmpty(UserInput)) return View("ThirdTaskResult", Task);
                else return BadRequest("Не введена строка");
            }
        }
    }
}
