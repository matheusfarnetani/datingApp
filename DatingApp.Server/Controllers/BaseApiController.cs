using DatingApp.Server.Data;
using DatingApp.Server.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // /api/
    public class BaseApiController : ControllerBase
    {
    }
}
