using EmployeesInformation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace EmployeesInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            List<Employee> employees = EmployeesDataStore.GetEmployees();
            return Ok(employees);
        }

       
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {

            Employee emp = EmployeesDataStore.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound(); // Return 404 if the employee is not found
            }
            return Ok(emp);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {

           bool result = EmployeesDataStore.DeleteEmployeeById(id);
            if (result)
            {
                return Ok(); 
            }
            return StatusCode(500, "Internal server error");
        }

        [HttpPost]
        public IActionResult PostEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee data is null.");
            }

            // Perform validation on the employee data
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Insert employee into the database
                EmployeesDataStore.InsertEmployee( employee.Name, employee.JobTitle, employee.Salary);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception and return an internal server error
                Console.WriteLine($"An error occurred while inserting employee: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
