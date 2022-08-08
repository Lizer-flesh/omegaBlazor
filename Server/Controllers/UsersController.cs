using Landing.Server.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<Users> Get()
        {
            return _applicationContext.Users;
        }



        [HttpPost]
        public Users Post(string[] arr)
        {
            if (_applicationContext.Users.Any(x => x.login == arr[0] && x.password == arr[1]))
            {
                return _applicationContext.Users.Where(x => x.login == arr[0] && x.password == arr[1]).FirstOrDefault();
            }
            else
            {
                return new Users() {login =null};
            }
        }
    }
}


