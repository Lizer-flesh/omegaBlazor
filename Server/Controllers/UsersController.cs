using Landing.Server.DAL.Core;
using Microsoft.AspNetCore.Mvc;
using Landing.Shared.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public IQueryable<string> Get([FromQuery] int identUser)
        {
            if (_applicationContext.Cart.Any(e => e.UserId == identUser))
            {
                return _applicationContext.Cart.Where(e => e.UserId == identUser).Select(e => e.ProductName);
            }
            //return _applicationContext.Cart.Where(e=>e.UserId == identUser).Select(e => e.ProductName);
            else
            {
                return null;
            }
        }

        [HttpPost]
        public User Post([FromQuery] string login, [FromQuery] string password)
        {
            if (_applicationContext.User.Any(x => x.login == login && x.password == password ))
            {
                // var userId = _applicationContext.Cart.Where(e=>e.UserId==)
                return _applicationContext.User.Where(x => x.login == login && x.password == password).FirstOrDefault();
            }
            else
            {
                return new User() {login =null};
            }
        }
        
        
    }
}


