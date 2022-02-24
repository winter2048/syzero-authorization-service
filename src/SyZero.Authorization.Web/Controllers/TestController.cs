using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SyZero.AspNetCore.Controllers;

namespace SyZero.Authorization.Web.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : BaseApiController
    {
     
        [HttpGet("Test1")]
        public IActionResult Test1()
        {
            System.Console.WriteLine(SySession.UserId);
            return Ok();
        }
    }
}