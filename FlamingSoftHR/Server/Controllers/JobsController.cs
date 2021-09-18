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
    public class JobsController : ControllerBase
    {
        private readonly IJobRepository jobRepository;

        public JobsController(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        // This method returns all the jobs between a range in the database through HTTP Get
        [HttpGet]
        public async Task<ActionResult> GetJobs(int skip = 0, int take = 10)
        {
            try
            {
                return Ok(await jobRepository.GetJobs(skip, take));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves the id of the job through the URI and if exists, returns the job, else returns NotFound Status Code
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            try
            {
                var job = await jobRepository.GetJob(id);

                if (job == null)
                {
                    return NotFound($"Job with the Id = {id} was not found");
                }

                return job;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("department/{id:int}")]
        public async Task<ActionResult> GetJobsByDepartment(int id)
        {
            try
            {
                return Ok(await jobRepository.GetJobsByDepartment(id));    
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        // This method recieves a job through HTTTP Post, creates the job and returns 201 Status Code
        [HttpPost]
        public async Task<ActionResult<Job>> AddJob(Job jobToAdd)
        {
            try
            {
                if (jobToAdd == null)
                {
                    return BadRequest();
                }

                var createdJob = await jobRepository.AddJob(jobToAdd);

                return CreatedAtAction(nameof(GetJob), new { id = createdJob.Id }, createdJob);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating the job record");
            }
        }

        // This method recieves an id through the URI and the job to update through HTTP Put. If the job exists,
        // updates its data and returns the updated job
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Job>> UpdateJob(int id, Job jobToUpdate)
        {
            try
            {
                if (id != jobToUpdate.Id)
                {
                    return BadRequest();
                }

                var currentJob = await jobRepository.GetJob(id);

                if (currentJob == null)
                {
                    return NotFound($"Job with the Id = {id} was not found");
                }

                return await jobRepository.UpdateJob(jobToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating the job record");
            }
        }

        // This method recieves an id through the URI and if the job exists, deletes it
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteJob(int id)
        {
            try
            {
                var jobToDelete = await jobRepository.GetJob(id);

                if (jobToDelete == null)
                {
                    return NotFound($"Job with the Id = {id} was not found");
                }

                await jobRepository.DeleteJob(id);

                return Ok($"Job with the Id = {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting the job record");
            }

        }

    }
}
