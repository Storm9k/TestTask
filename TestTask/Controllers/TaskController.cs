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
            //Создаем модель представленияя и передаем ее в представление 
            using (FirstTaskModel ft = new FirstTaskModel())
            {
                return View(ft);
            }
        }

        public IActionResult SecondTask()
        {
            //Создаем модель представленияя и передаем ее в представление 
            using (SecondTaskModel st = new SecondTaskModel())
            {

                return View(st);
            }
        }

        [HttpGet]
        public IActionResult ThirdTask()
        {
            //Отправка Get запроса пользователю
            return View();
        }

        [HttpPost]
        public IActionResult ThirdTask(string UserInput)
        {
            //Создаем модель представленияя и передаем ее через Post запрос в представление 
            using (ThirdTask Task = new ThirdTask(UserInput))
            {
                if (!String.IsNullOrEmpty(UserInput)) return View("ThirdTaskResult", Task);
                else return BadRequest("Не введена строка");
            }
        }
    }
}
