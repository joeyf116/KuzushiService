using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace KuzushiService
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GymServiceController
    {
        private readonly ILogger<GymServiceController> _logger;

        public GymServiceController(ILogger<GymServiceController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get a Gym.
        /// </summary>
        [HttpGet(Name = "GetGym")]
        public string GetGym()
        {
            Gym testGym = new Gym("TestGym", "TestLocation");
            return JsonConvert.SerializeObject(testGym);
        }
    }
}