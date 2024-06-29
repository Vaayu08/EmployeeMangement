using EmployeeMangement.Interface;
using EmployeeMangement.Models;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> GetEmployee()
        {
            return _employeeService.GetEmployeeDetails();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public List<Employee>GetEmployees()
        {
            return _employeeService.GetEmployeeDetails();
        }
        
        
        // POST api/<EmployeesController>
        [HttpPost]
        public Employee AddEmployee([FromBody] Employee emp)
        {
            var employee = _employeeService.AddEmployee(emp);
            return employee;
        }

        
    }
}
