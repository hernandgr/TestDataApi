using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestData.Api.Models;

namespace TestData.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly List<Employee> employees = new List<Employee>
        {
            new Employee { Id= 1, Name= "Juan", RoleId = 1, RoleName = "Administrator", AnnualSalary= 60000m},
            new Employee { Id= 2, Name= "Sebastian", RoleId = 2, RoleName = "Contractor", AnnualSalary= 80000m}
        };

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}