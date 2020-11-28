using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class TaskListViewModel
    {
        public IEnumerable<TaskListItemViewModel> Tasks { get; set; }
    }
}
