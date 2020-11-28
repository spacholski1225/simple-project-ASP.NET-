using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TaskController : Controller
    {
        private TaskListService _taskListService;

        public TaskController(TaskListService taskListService)
        {
            _taskListService = taskListService;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Add(NewTaskViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _taskListService.AddNewTask(data.Title, data.Desc);

            return RedirectToAction("Index", "Home");
        }
    }
}
