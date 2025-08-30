using Microsoft.AspNetCore.Mvc;

namespace FinCoreAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {

    }
}
