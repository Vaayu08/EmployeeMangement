using EmployeeMangement.Models;

namespace EmployeeMangement.Interface
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
        
    }
}
