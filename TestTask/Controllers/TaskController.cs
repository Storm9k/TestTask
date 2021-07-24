using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Models;
using System.Collections.Generic;


namespace TestTask
{
    public class TaskController : Controller
    {
        private readonly ILogger<TaskController> logger;
        private ITask<int> ft;
        private ITask<LinkedList<int>> st;
        private ITask<bool> ts;

        public TaskController(ILogger<TaskController> _logger, ITask<int> _ft, ITask<LinkedList<int>> _st, ITask<bool> _ts)
        {
            logger = _logger;
            ft = _ft;
            st = _st;
            ts = _ts;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstTask()
        {
            //Создаем модель представленияя и передаем ее в представление 
            using (ft = new FirstTask())
            {
                return View(ft);
            }
        }

        public IActionResult SecondTask()
        {
            //Создаем модель представленияя и передаем ее в представление 
            using (st = new SecondTask())
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
            using (ts = new ThirdTask(UserInput))
            {
                if (!String.IsNullOrEmpty(UserInput)) return View("ThirdTaskResult", ts);
                else return BadRequest("Не введена строка");
            }
        }
    }
}
