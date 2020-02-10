using OA.Repository.Interface;
using OA.Services.Interfaces;
using OA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services.Services
{
    public class EmployeeServices : IEmployeeServices
    {

        private readonly IEmployeeRepository employeeRepository;

        public EmployeeServices(IEmployeeRepository emp)
        {
            employeeRepository = emp;
        }
        public IEnumerable<EmployeeVM> GetAllEmployee()
        {
            return employeeRepository.GetAll(); 
        }
    }
}
