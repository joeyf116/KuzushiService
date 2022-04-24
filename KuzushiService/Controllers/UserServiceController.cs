using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace KuzushiService
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserServiceController
    {
        private readonly ILogger<UserServiceController> _logger;

        public UserServiceController(ILogger<UserServiceController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get a list of Users.
        /// </summary>
        [HttpGet(Name = "GetUser")]
        public string GetUser()
        {
            User testUser = new User("TestUser", "TestRank");
            return JsonConvert.SerializeObject(testUser);
        }
    }
}