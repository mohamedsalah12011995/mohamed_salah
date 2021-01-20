using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eservices.API.DTO;
using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private readonly IEntitiesService _entitiesService;
        private readonly IMapper _mapper;
        public EntitiesController(IEntitiesService entitiesService , IMapper mapper)
        {
            _entitiesService = entitiesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _entitiesService.GetAll();
            if (entity == null)
            {
                return NoContent();
            }

            return Ok(entity);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _entitiesService.GetById(id);
            if (entity == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(entity);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _entitiesService.DeleteById(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(EntityDTO entity)
        {
            var datatoSave = _mapper.Map<Entities>(entity);
            var data = await _entitiesService.Save(datatoSave);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EntityDTO entity)
        {
            var datatoSave = _mapper.Map<Entities>(entity);
            var data = await _entitiesService.Save(datatoSave);
            return Ok(data);
        }

        [HttpGet("GetEntityByPageNo")]
        public async Task<IActionResult> GetByPage(int pgNo, int PgSize = 10)
        {
            var entity = await _entitiesService.GetByPage(pgNo, PgSize);
            if (entity == null)
            {
                return NoContent();
            }
            return Ok(entity);

        }

        [HttpGet("GetEntityByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            var entity = await _entitiesService.GetByName(name);
            if (entity == null)
            {
                return NotFound($"item against this id={name} does not found");
            }

            return Ok(entity);
        }
    }
}
