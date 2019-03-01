using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TasksProject.Models;

namespace TasksProject.Data
{
    public class TaskContext:DbContext
    {
        public TaskContext() : base("Base") { }
        public DbSet<Task> Tasks { get; set; }
    }
}