using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eservices.Core.Contracts;
using EServices.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiledLookupsController : ControllerBase
    {
        private readonly IFieldLookupsService _FiledLookupsService;
        private readonly IMapper _mapper;
        public FiledLookupsController(IFieldLookupsService FiledLookupsService, IMapper mapper)
        {
            _FiledLookupsService = FiledLookupsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _FiledLookupsService.GetAll();
            if (entity == null)
            {
                return NoContent();
            }

            return Ok(entity);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _FiledLookupsService.GetById(id);
            if (entity == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(entity);
        }


    }
}
