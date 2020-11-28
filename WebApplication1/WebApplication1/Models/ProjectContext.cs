using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
    
}
