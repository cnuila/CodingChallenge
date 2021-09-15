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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        // This method returns all the departments in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetDeparments()
        {
            try
            {
                return Ok(await departmentRepository.GetDepartments());
            } catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
            
        }

        // This method recieves the id of the department through the URI and if exists, returns the department, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDeparment(int id)
        {
            try
            {
                var department = await departmentRepository.GetDepartment(id);

                if (department == null)
                {
                    return NotFound($"Department with the Id = {id} was not found");
                }

                return department;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }

        // This method recieves a department through HTTTP Post, creates the department and returns 201 Status Code
        [HttpPost]
        public async Task<ActionResult<Department>> AddDepartment(Department departmentToAdd)
        {
            try
            {
                if (departmentToAdd == null)
                {
                    return BadRequest();
                }

                var createdDepartment = await departmentRepository.AddDepartment(departmentToAdd);

                return CreatedAtAction(nameof(GetDeparment), new { id = createdDepartment.Id }, createdDepartment);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the department record");
            }

        }

        // This method recieves an id through the URI and the department to update through HTTP Put. If the department exists,
        // updates its data and returns the updated department
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Department>> UpdateDepartment(int id, Department departmentToUpdate)
        {
            try
            {
                if ( id != departmentToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentDepartment = await departmentRepository.GetDepartment(id);

                if (currentDepartment == null)
                {
                    return NotFound($"Department with the Id = {id} was not found");
                }

                return await departmentRepository.UpdateDepartment(departmentToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the department record");
            }

        }

        // This method recieves an id through the URI and if the department exists, deletes it
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            try
            {
                var departmentToDelete = await departmentRepository.GetDepartment(id);

                if (departmentToDelete == null)
                {
                    return NotFound($"Department with the Id = {id} was not found");
                }

                await departmentRepository.DeleteDepartment(id);

                return Ok($"Department with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the department record");
            }

        }

    }
}
