﻿using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class TaskListService
    {
        private ProjectContext _context;

        public TaskListService(ProjectContext context)
        {
            _context = context;
        }

        public TaskListViewModel GetAllOpen()
        {
            var tasks = _context.Tasks.Where(x => !x.Done).Select(x => new TaskListItemViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Desc = x.Desc
                
            });
            var vm = new TaskListViewModel
            {
                Tasks = tasks
            };
            return vm;
        }

        public void AddNewTask(string title, string desc)
        {
            var task = new Task
            {
                Title = title,
                Desc = desc,
                Done = false
            };
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void FinishTask(int id)
        {
            var task = _context.Tasks.Find(id);
            task.Done = true;

            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

    }
}
