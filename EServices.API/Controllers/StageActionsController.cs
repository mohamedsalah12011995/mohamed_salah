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
    public class StageActionsController : ControllerBase
    {
        private readonly IStageActionsService _StageActionsService;
        private readonly IMapper _mapper;
        public StageActionsController(IStageActionsService StageActionsService, IMapper mapper)
        {
            _StageActionsService = StageActionsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _StageActionsService.GetAll();
            if (entity == null)
            {
                return NoContent();
            }

            return Ok(entity);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _StageActionsService.GetById(id);
            if (entity == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(entity);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _StageActionsService.DeleteById(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(EntityDTO entity)
        {
            var datatoSave = _mapper.Map<StageActions>(entity);
            var data = await _StageActionsService.Save(datatoSave);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Put(StageActionDTO entity)
        {
            var datatoSave = _mapper.Map<StageActions>(entity);
            var data = await _StageActionsService.Save(datatoSave);
            return Ok(data);
        }

        [HttpGet("GetEntityByPageNo")]
        public async Task<IActionResult> GetByPage(int pgNo, int PgSize = 10)
        {
            var entity = await _StageActionsService.GetByPage(pgNo, PgSize);
            if (entity == null)
            {
                return NoContent();
            }
            return Ok(entity);

        }


    }
}
