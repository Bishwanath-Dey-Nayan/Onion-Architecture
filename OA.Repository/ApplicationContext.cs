using Microsoft.EntityFrameworkCore;
using OA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository
{
     public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
