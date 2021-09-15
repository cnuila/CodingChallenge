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
    public class LoggedTimeTypesController : ControllerBase
    {
        private readonly ILoggedTimeTypeRepository loggedTimeTypeRepository;

        public LoggedTimeTypesController(ILoggedTimeTypeRepository loggedTimeTypeRepository)
        {
            this.loggedTimeTypeRepository = loggedTimeTypeRepository;
        }

        // This method returns all the logged time types in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetLoggedTimeTypes()
        {
            try
            {
                return Ok(await loggedTimeTypeRepository.GetLoggedTimeTypes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves the id of the logged time type through the URI and if exists, returns the logged time type, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<LoggedTimeType>> GetLoggedTimeType(int id)
        {
            try
            {
                var loggedTimeType = await loggedTimeTypeRepository.GetLoggedTimeType(id);

                if (loggedTimeType == null)
                {
                    return NotFound($"Logged Time Type with the Id = {id} was not found");
                }

                return loggedTimeType;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves a logged time type through HTTTP Post, creates the logged time type and returns 201 Status Code
        [HttpPost]
        public async Task<ActionResult<LoggedTimeType>> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd)
        {
            try
            {
                if (loggedTimeTypeToAdd == null)
                {
                    return BadRequest();
                }

                var createdLoggedTimeType= await loggedTimeTypeRepository.AddLoggedTimeType(loggedTimeTypeToAdd);

                return CreatedAtAction(nameof(GetLoggedTimeType), new { id = createdLoggedTimeType.Id }, createdLoggedTimeType);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the logged time type record");
            }
        }

        // This method recieves an id through the URI and the logged time type to update through HTTP Put. If the logged time type exists,
        // updates its data and returns the updated logged time type
        [HttpPut("{id:int}")]
        public async Task<ActionResult<LoggedTimeType>> UpdateLoggedTimeType(int id, LoggedTimeType loggedTimeTypeToUpdate)
        {
            try
            {
                if (id != loggedTimeTypeToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentLoggedTimeType= await loggedTimeTypeRepository.GetLoggedTimeType(id);

                if (currentLoggedTimeType == null)
                {
                    return NotFound($"Logged Time Type with the Id = {id} was not found");
                }

                return await loggedTimeTypeRepository.UpdateLoggedTimeType(loggedTimeTypeToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the logged time type record");
            }
        }

        // This method recieves an id through the URI and if the logged time type exists, deletes it
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteLoggedTimeType(int id)
        {
            try
            {
                var loggedTimeTypeToDelete = await loggedTimeTypeRepository.GetLoggedTimeType(id);

                if (loggedTimeTypeToDelete == null)
                {
                    return NotFound($"Logged Time Type with the Id = {id} was not found");
                }

                await loggedTimeTypeRepository.DeleteLoggedTimeType(id);

                return Ok($"Loggeed Time Type with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the logged time type record");
            }

        }

    }
}
