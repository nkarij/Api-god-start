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
    public class CategoryController : ControllerBase
    {

        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(
                ILogger<CategoryController> logger,
                ICategoryRepository categoryRepository,
                IMapper mapper
            )
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var result = _categoryRepository.GetAllCategories();
                //var ressource = _mapper.Map<CategoryRessource>(result);
                //return Ok(ressource);
                ICollection<CategoryRessource> listOfCategories = new List<CategoryRessource>();

                foreach (var item in result)
                {
                    var ressource = _mapper.Map<CategoryRessource>(item);
                    listOfCategories.Add(ressource);
                }
                return Ok(listOfCategories);
            }
            catch (Exception)
            {
                return BadRequest("categories not returned");
            }
        }
    }
}
