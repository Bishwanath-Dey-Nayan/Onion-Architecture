using OA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services.Interfaces
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeVM> GetAllEmployee();
    }
}
