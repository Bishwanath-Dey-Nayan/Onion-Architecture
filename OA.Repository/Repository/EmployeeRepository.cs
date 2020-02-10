using Microsoft.EntityFrameworkCore;
using OA.Models;
using OA.Repository.Interface;
using OA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _context;
        private DbSet<Employee> entities;

        public EmployeeRepository(ApplicationContext context)
        {
            _context = context;
            entities = _context.Set<Employee>();
        }
        public IEnumerable<EmployeeVM> GetAll()
        {
            var employee = entities.ToList();
            List<EmployeeVM> empvm = employee.Select(e => new EmployeeVM
            {
                EmpId = e.Id,
                EmpName = e.Name
            }).ToList();

            return empvm;

        }
    }
}
