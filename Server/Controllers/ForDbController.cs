using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Landing.Server
{
    [ApiController]
    [Route("[controller]")]
    public class ForDbController : ControllerBase
    {
        private readonly ApplicationContext _applicationContext;

        public ForDbController(ApplicationContext appContext)
        {
            _applicationContext = appContext;
        }

        //[HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            //_applicationContext.Users.Add(new Users() { Name = "Mihail", Surname = "Skopin", login = "skom", password = "mopinON11" });
            //_applicationContext.Users.Add(new Users() { Name = "Sergey", Surname = "Davidov", login = "davs", password = "1234" });
            //_applicationContext.Users.Add(new Users() { Name = "Denis", Surname = "Butenko", login = "butd", password = "5678" });
            //_applicationContext.SaveChanges();

            var users = _applicationContext.Users;
            foreach (Users u in users)
            {
                Console.WriteLine(u);
            }
           
            return Ok();
        }
    }
}
