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
    public class FieldTypesController : ControllerBase
    {
        private readonly IFieldTypesService _FieldTypesService;
        private readonly IMapper _mapper;
        public FieldTypesController(IFieldTypesService FieldTypesService, IMapper mapper)
        {
            _FieldTypesService = FieldTypesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _FieldTypesService.GetAll();
            if (entity == null)
            {
                return NoContent();
            }

            return Ok(entity);
        }

        [HttpGet("GetEntityByPageNo")]
        public async Task<IActionResult> GetByPage(int pgNo, int PgSize = 10)
        {
            var entity = await _FieldTypesService.GetByPage(pgNo, PgSize);
            if (entity == null)
            {
                return NoContent();
            }
            return Ok(entity);

        }


    }
}
