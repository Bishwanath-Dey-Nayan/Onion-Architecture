using OA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository.Interface
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeVM> GetAll();
    }
}
