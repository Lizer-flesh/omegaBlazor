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
        public async Task<IActionResult> GetAsync()
        {
            _applicationContext.User.Add(new User()
                { Name = "Mihail", Surname = "Skopin", login = "mopin", password = "1234" });
            _applicationContext.User.Add(new User()
                { Name = "Sergey", Surname = "Davydov", login = "davs", password = "5678" });
            _applicationContext.SaveChanges();
            return Ok();
        }



        //[HttpPost]
        //public Users Post(string[] arr)
        //{
        //    if (_applicationContext.User.Any(x => x.login == arr[0] && x.password == arr[1]))
        //    {
        //       return _applicationContext.User.Where(x => x.login == arr[0] && x.password == arr[1]).FirstOrDefault();
        //    }
        //    else
        //    {
        //        return new Users() {login =null};
        //    }
        //}
    }
}


