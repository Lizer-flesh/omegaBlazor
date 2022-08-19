using Landing.Server.DAL.Core;
using Microsoft.AspNetCore.Mvc;
using Landing.Shared.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApplicationContext = Landing.Server.DAL.Core.ApplicationContext;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace Landing.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        
        private readonly ApplicationContext _applicationContext;

        public UsersController(ApplicationContext appContext)
        {
            _applicationContext = appContext;
        }

        // [HttpGet]
        // public IEnumerable<User> Get()
        // {
        //     
        //    // var queryable = _applicationContext.Cart.Where(e=>e.UserId == ).Select(e => e.ProductName);
        //     return _applicationContext.User;
        // }



        [HttpPost]
        public User Post([FromQuery] string login, [FromQuery] string password)
        {
            if (_applicationContext.User.Any(x => x.login == login && x.password == password ))
            {
                return _applicationContext.User.Where(x => x.login == login && x.password == password).FirstOrDefault();
            }
            else
            {
                return new User() {login =null};
            }
        }
    }
}


