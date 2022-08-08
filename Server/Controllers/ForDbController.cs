using Landing.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Landing.Server
{
    [ApiController]
    [Route("[controller]")]
    public class ForDbController : ControllerBase
    {
        //private readonly ApplicationContext _applicationContext;

        //public ForDbController(ApplicationContext appContext)
        //{
        //    _applicationContext = appContext;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Post()
        //{

        //    var users = _applicationContext.Users;
        //    foreach (Users u in users)
        //    {
        //        Console.WriteLine(u);
        //    }

        //    return Ok();
        //}
    }
}
