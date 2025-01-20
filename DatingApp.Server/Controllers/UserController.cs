using DatingApp.Server.Data;
using DatingApp.Server.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Server.Controllers
{
    public class UsersController(DataContext context) : BaseApiController
    {
        //[AllowAnonymous] // default
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id:int}")] // users/id
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            return user;
        }
    }
}
