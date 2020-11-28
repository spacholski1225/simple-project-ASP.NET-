﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private TaskListService _taskListService;

        public HomeController(TaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        public IActionResult Index()
        {

            var vm = _taskListService.GetAllOpen();

            return View(vm);
        }

        public IActionResult Finish(int id)
        {
            if (id != 0)
            {
                _taskListService.FinishTask(id);
            }
            return RedirectToAction("Index");
        }
    }
}
