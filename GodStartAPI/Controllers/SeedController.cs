using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using GodStartAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GodStartAPI.Controllers
{
    [Route("api/[controller]")]
    public class SeedController : Controller
    {

        private readonly ILogger<SeedController> _logger;
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;

        public SeedController(ILogger<SeedController> logger,
            AppDbContext context,
            IConfiguration config)
        {
            _logger = logger;
            _config = config;
            _context = context;
        }
        public IConfiguration config { get; }


        // GET api/<controller>/5
        //	THIS IS ONLY USED TO SEED THE TEST USERS ID TO THE LIST WITH ID 1.
        // ONLY USE THIS ONCE FROM POSTMAN /API/ACCOUNT/ID IF YOU HAVE DROPPED THE DATABASE.
        // IF YOU HAVE NOT DROPPED THE DATABASE, DONT USE THIS METHOD.
        //[HttpGet("{id:int}")]
        //public ActionResult ConnectJobAndRelated(int id)
        //{
        //    var job = _context.Jobs.SingleOrDefault(l => l.Id == id);
        //    var postNumber = _context.PostNumbers.SingleOrDefault(p => p.Id == 1);
        //    var category = _context.Categories.SingleOrDefault(c => c.Id == 2);
        //    job.Category = category;
        //    job.PostNumber = postNumber;
        //    _context.SaveChanges();
        //    return Created("", job);
        //}

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
