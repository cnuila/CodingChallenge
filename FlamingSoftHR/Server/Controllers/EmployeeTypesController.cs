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
    public class EmployeeTypesController : ControllerBase
    {
        private readonly IEmployeeTypeRepository employeeTypeRepository;

        public EmployeeTypesController(IEmployeeTypeRepository employeeTypeRepository)
        {
            this.employeeTypeRepository = employeeTypeRepository;
        }

        // This method returns all the employee types in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetEmployeeTypes()
        {
            try
            {
                return Ok(await employeeTypeRepository.GetEmployeeTypes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves the id of the employee type through the URI and if exists, returns the employee type, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeType>> GetEmployeeType(int id)
        {
            try
            {
                var employeeType = await employeeTypeRepository.GetEmployeeType(id);

                if (employeeType == null)
                {
                    return NotFound($"Employee Type with the Id = {id} was not found");
                }

                return employeeType;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves an employee type through HTTTP Post, creates the employee type and returns 201 Status Code
        [HttpPost]
        public async Task<ActionResult<EmployeeType>> AddEmployeeType(EmployeeType employeeTypeToAdd)
        {
            try
            {
                if (employeeTypeToAdd == null)
                {
                    return BadRequest();
                }

                var createdEmployeeType = await employeeTypeRepository.AddEmployeeType(employeeTypeToAdd);

                return CreatedAtAction(nameof(GetEmployeeType), new { id = createdEmployeeType.Id }, createdEmployeeType);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the employee type record");
            }
        }

        // This method recieves an id through the URI and the employee type to update through HTTP Put. If the employee type exists,
        // updates its data and returns the updated employee type
        [HttpPut("{id:int}")]
        public async Task<ActionResult<EmployeeType>> UpdateEmployeeType(int id, EmployeeType employeeTypeToUpdate)
        {
            try
            {
                if (id != employeeTypeToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentEmployeeType = await employeeTypeRepository.GetEmployeeType(id);

                if (currentEmployeeType == null)
                {
                    return NotFound($"Employee Type with the Id = {id} was not found");
                }

                return await employeeTypeRepository.UpdateEmployeeType(employeeTypeToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the employee type record");
            }
        }

        // This method recieves an id through the URI and if the employee type exists, deletes it
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployeeType(int id)
        {
            try
            {
                var employeeTypeToDelete = await employeeTypeRepository.GetEmployeeType(id);

                if (employeeTypeToDelete == null)
                {
                    return NotFound($"Employee Type with the Id = {id} was not found");
                }

                await employeeTypeRepository.DeleteEmployeeType(id);

                return Ok($"Employee Type with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the employee type record");
            }
        }

    }
}
