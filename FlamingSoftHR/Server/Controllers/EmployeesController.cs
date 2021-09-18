using System;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Models;
using FlamingSoftHR.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlamingSoftHR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        //This method returns a employee based on his user id
        [HttpGet("{userId}")]
        public async Task<ActionResult<Employee>> GetEmployeeByUserId(string userId)
        {
            try
            {
                var employee = await employeeRepository.GetEmployeeByUserId(userId);

                if (employee == null)
                {
                    return NotFound($"Employee with User Id = {userId} was not found");
                }

                return employee;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }


        // This method returns all the employees in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return Ok(await employeeRepository.GetEmployees());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves the id of the employee through the URI and if exists, returns the employee, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var employee = await employeeRepository.GetEmployee(id);

                if (employee == null)
                {
                    return NotFound($"Employee with the Id = {id} was not found");
                }

                return employee;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves an employee through HTTTP Post, creates the employee and returns 201 Status Code, if the user id
        // exists already returns a bad request
        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee(Employee employeeToAdd)
        {
            try
            {
                if (employeeToAdd == null)
                {
                    return BadRequest();
                }

                var employee = await employeeRepository.GetEmployeeByUserId(employeeToAdd.UserId);

                if (employee != null)
                {
                    ModelState.AddModelError("User Id", "Employee user id already in use");
                    BadRequest(ModelState);
                }

                var createdEmployee = await employeeRepository.AddEmployee(employeeToAdd);

                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the employee record");
            }
        }

        // This method recieves an id through the URI and the employee to update through HTTP Put. If the employee exists,
        // updates their data and returns the updated employee
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employeeToUpdate)
        {
            try
            {
                if (id != employeeToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentEmployee = await employeeRepository.GetEmployee(id);

                if (currentEmployee == null)
                {
                    return NotFound($"Employee with the Id = {id} was not found");
                }

                return await employeeRepository.UpdateEmployee(employeeToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the employee record");
            }
        }

        // This method recieves an id through the URI and if the employee exists, deletes him
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            try
            {
                var employeeToDelete = await employeeRepository.GetEmployee(id);

                if (employeeToDelete == null)
                {
                    return NotFound($"Employee with the Id = {id} was not found");
                }

                await employeeRepository.DeleteEmployee(id);

                return Ok($"Employee with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the employee record");
            }

        }

    }
}
