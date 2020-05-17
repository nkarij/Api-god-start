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
    public class PostNumberController : ControllerBase
    {

        private readonly ILogger<PostNumberController> _logger;
        private readonly IPostNumberRepository _postNumberRepository;
        private readonly IMapper _mapper;

        public PostNumberController(
                ILogger<PostNumberController> logger,
                IPostNumberRepository postNumberRepository,
                IMapper mapper
            )
        {
            _logger = logger;
            _postNumberRepository = postNumberRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var result = _postNumberRepository.GetAllPostNumbers();
                //var ressource = _mapper.Map<PostNumberRessource>(result);
                return Ok(result);
                //ICollection<PostNumberRessource> listOfPostNumbers = new List<PostNumberRessource>();

                //foreach (var item in result)
                //{
                //    var ressource = _mapper.Map<PostNumberRessource>(item);
                //    listOfPostNumbers.Add(ressource);
                //}
                //return Ok(listOfPostNumbers);
            }
            catch (Exception)
            {
                return BadRequest("Postnumbers not returned");
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody]PostNumber model)
        {

            try
            {
                _postNumberRepository.UpdatePostNumber(model);
                return Ok();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            
        }
    }
}
