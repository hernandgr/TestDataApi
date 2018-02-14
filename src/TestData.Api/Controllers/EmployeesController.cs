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
            new Employee { Id= 1, Name= "Juan", ContractTypeName="HourlySalaryEmployee", RoleId = 1, RoleName = "Administrator", HourlySalary = 60000m, MonthlySalary = 80000m},
            new Employee { Id= 2, Name= "Sebastian", ContractTypeName="MonthlySalaryEmployee", RoleId = 2, RoleName = "Contractor", HourlySalary = 60000m, MonthlySalary = 80000m}
        };

        /// <summary>
        /// Gets a list of employees with their data.
        /// </summary>
        /// <returns>The list of employees.</returns>
        /// <response code="200">Returns the list of employees</response>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        /// <summary>
        /// Gets an employee with the given id.
        /// </summary>
        /// <param name="id">The identifier of the employee to search.</param>
        /// <returns>The data of the employee with the given id.</returns>
        /// <response code="200">The employee data.</response>
        /// <response code="404">No employee data found for the given id.</response>
        //[HttpGet("{id:int}")]
        //public IActionResult Get(int id)
        //{
        //    var employee = employees.FirstOrDefault(x => x.Id == id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(employee);
        //}
    }
}
