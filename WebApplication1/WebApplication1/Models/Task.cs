﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool Done { get; set; }
    }
}
