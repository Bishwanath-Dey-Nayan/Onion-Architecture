using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices employeeServices;

        public EmployeeController(IEmployeeServices es)
        {
            employeeServices = es;
        }

        [HttpGet]
        [Route("GetAllEmployee")]
        public IActionResult GetAllEmployee()
        {
            return Ok(employeeServices.GetAllEmployee());
        }
    }
}