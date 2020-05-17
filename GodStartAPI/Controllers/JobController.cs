using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GodStartAPI.Models;
using GodStartAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GodStartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _jobRepository;
        private readonly ILogger<JobController> _logger;
        private readonly IMapper _mapper;

        public JobController(
            IJobRepository jobRepository,
            ILogger<JobController> logger,
            IMapper mapper)
        {
            _jobRepository = jobRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var result = _jobRepository.GetAllJobs();
                //return Ok(result);
                ICollection<JobRessource> listOfJobs = new List<JobRessource>();

                foreach (var item in result)
                {
                    var ressource = _mapper.Map<JobRessource>(item);
                    listOfJobs.Add(ressource);
                }
                return Ok(listOfJobs);
            }
            catch (Exception)
            {

                return BadRequest("Jobs not returned");
            }
            
        }
    }
}
