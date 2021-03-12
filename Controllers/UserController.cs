using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithOutGrpc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return Enumerable.Range(1, 10000).Select(x => new User
            {
                Id= x,
                Name = $"Name {x} from Sales"

            }).ToArray();
        }
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
