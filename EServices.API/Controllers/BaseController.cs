using Microsoft.AspNetCore.Mvc;

namespace EServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
