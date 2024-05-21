using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.API.Models;
using Server.API.Utils;

namespace Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private readonly GamesContext context;

        public AchievementsController(GamesContext context)
        {
            this.context = context;
        }

        // GET: api/Achievements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Achievement>>> GetAchivements()
        {
            return await context.Achievements.ToListAsync();
        }
    }
}