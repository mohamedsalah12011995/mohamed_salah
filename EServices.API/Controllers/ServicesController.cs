using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eservices.API.DTO;
using Eservices.Core.Contracts;
using EServices.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService _ServicesService;
        private readonly IMapper _mapper;
        public ServicesController(IServicesService ServicesService, IMapper mapper)
        {
            _ServicesService = ServicesService;
            _mapper = mapper;
        }

        [HttpGet ("all")]

        public async Task<IActionResult> GetAll()
        {

            var entities = await _ServicesService.GetAll();
            if (entities == null)
            {
                return NoContent();
            }
           var dtos =  _mapper.Map<List<Services>>(entities);

            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _ServicesService.GetById(id);
            if (entity == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(entity);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ServicesService.DeleteById(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ServiceDTO entity)
        {
            var datatoSave = _mapper.Map<Services>(entity);
            var data = await _ServicesService.Save(datatoSave);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ServiceDTO entity)
        {
            var datatoSave = _mapper.Map<Services>(entity);
            var data = await _ServicesService.Save(datatoSave);
            return Ok(data);
        }

        [HttpGet("GetEntityByPageNo")]
        public async Task<IActionResult> GetByPage(int pgNo, int PgSize = 10)
        {
            var entity = await _ServicesService.GetByPage(pgNo, PgSize);
            if (entity == null)
            {
                return NoContent();
            }
            return Ok(entity);

        }


    }
}
