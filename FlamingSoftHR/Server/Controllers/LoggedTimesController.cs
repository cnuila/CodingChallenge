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
    public class LoggedTimesController : ControllerBase
    {
        private readonly ILoggedTimeRepository loggedTimeRepository;

        public LoggedTimesController(ILoggedTimeRepository loggedTimeRepository)
        {
            this.loggedTimeRepository = loggedTimeRepository;
        }

        // This method returns all the logged times in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetLoggedTime()
        {
            try
            {
                return Ok(await loggedTimeRepository.GetLoggedTimes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves the id of the logged time through the URI and if exists, returns the logged time, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<LoggedTime>> GetLoggedTime(int id)
        {
            try
            {
                var loggedTime = await loggedTimeRepository.GetLoggedTime(id);

                if (loggedTime == null)
                {
                    return NotFound($"Logged Time with the Id = {id} was not found");
                }

                return loggedTime;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves a logged time through HTTTP Post, creates the logged time and returns 201 Status Code
        [HttpPost]
        public async Task<ActionResult<LoggedTime>> AddLoggedTime(LoggedTime loggedTimeToAdd)
        {
            try
            {
                if (loggedTimeToAdd == null)
                {
                    return BadRequest();
                }

                var createdLoggedTime= await loggedTimeRepository.AddLoggedTime(loggedTimeToAdd);

                return CreatedAtAction(nameof(GetLoggedTime), new { id = createdLoggedTime.Id }, createdLoggedTime);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the logged time record");
            }
        }

        // This method recieves an id through the URI and the logged time to update through HTTP Put. If the logged time exists,
        // updates its data and returns the updated logged time
        [HttpPut("{id:int}")]
        public async Task<ActionResult<LoggedTime>> UpdateLoggedTime(int id, LoggedTime loggedTimeToUpdate)
        {
            try
            {
                if (id != loggedTimeToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentLoggedTime = await loggedTimeRepository.GetLoggedTime(id);

                if (currentLoggedTime == null)
                {
                    return NotFound($"Logged Time with the Id = {id} was not found");
                }

                return await loggedTimeRepository.UpdateLoggedTime(loggedTimeToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the logged time record");
            }
        }

        // This method recieves an id through the URI and if the logged time exists, deletes it
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteLoggedTime(int id)
        {
            try
            {
                var loggedTimeToDelete = await loggedTimeRepository.GetLoggedTime(id);

                if (loggedTimeToDelete == null)
                {
                    return NotFound($"Logged Time with the Id = {id} was not found");
                }

                await loggedTimeRepository.DeleteLoggedTime(id);

                return Ok($"Loggeed Time with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the logged time record");
            }

        }

    }
}
