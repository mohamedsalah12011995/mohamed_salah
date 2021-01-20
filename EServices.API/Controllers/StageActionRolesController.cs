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
    public class StageActionRolesController : ControllerBase
    {
        private readonly IStageActionRolesService _StageActionRolesService;
        private readonly IMapper _mapper;
        public StageActionRolesController(IStageActionRolesService StageActionRolesService, IMapper mapper)
        {
            _StageActionRolesService = StageActionRolesService;
            _mapper = mapper;
        }



        [HttpGet("GetStageActionRolesByActionIdByRoleId")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _StageActionRolesService.GetByRoleId(id);
            if (entity == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(entity);
        }

        [HttpGet("GetStageActionRolesByActionId")]
        public async Task<IActionResult> GetByStageActionId(int id)
        {
            var stageActionRole = await _StageActionRolesService.GetByStageActionId(id);
            if (stageActionRole == null)
            {
                return NotFound($"item against this id={id} does not found");
            }

            return Ok(stageActionRole);
        }


    }
}
