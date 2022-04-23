using Microsoft.AspNetCore.Mvc;

namespace KuzushiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserServiceController : ControllerBase
    {
        private readonly ILogger<UserServiceController> _logger;

        public UserServiceController(ILogger<UserServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public string Get()
        {
            User testUser = new User("TestUser", "TestRank");
            return $"Name: {testUser.Name}, Rank: {testUser.Rank}";
        }
    }
}