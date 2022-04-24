using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace KuzushiService
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TournamentServiceController
    {
        private readonly ILogger<TournamentServiceController> _logger;

        public TournamentServiceController(ILogger<TournamentServiceController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get a list of Events.
        /// </summary>
        [HttpGet(Name = "GetTournamentEvent")]
        public string GetTournamentEvent()
        {
            List<User> users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(new User($"TestUser{i}", "TestRank"));
            }
            TournamentEvent tournament = new TournamentEvent("testeventname", "ebi", DateTime.Now, users);
            return JsonConvert.SerializeObject(tournament);
        }
    }
}