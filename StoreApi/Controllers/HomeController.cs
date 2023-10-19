
using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet("Hi")]

        public string Hello()
        {
            return "Hello, World!";
        }

        [HttpGet("Students")]

        public string[] Students()
        {
            return new string[]{
                "Ahmet",
                "Mehmet",
                "Muhammed",
                "Nisa",
                "Tuna",
                "Abdullah"
            };
        }
    }
}