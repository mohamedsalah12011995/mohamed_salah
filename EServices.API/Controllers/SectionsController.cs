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
    public class SectionsController : ControllerBase
    {
        private readonly ISectionsService _SectionsService;
        private readonly IMapper _mapper;
        public SectionsController(ISectionsService SectionsService, IMapper mapper)
        {
            _SectionsService = SectionsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _SectionsService.GetAll();
            if (entity == null)
            {
                return NoContent();
            }

            return Ok(entity);
        }

    }
}
