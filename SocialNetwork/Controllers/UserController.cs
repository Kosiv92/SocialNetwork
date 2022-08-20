using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetLibrary.Models;

namespace SocialNetwork.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        List<User> _users = new List<User>
        {
            new User { Id = 1, UserName = "Mark", Age = 18, City = "London"},
            new User { Id = 2, UserName = "Carl", Age = 28, City = "New-York"},
            new User { Id = 3, UserName = "Ivan", Age = 30, City = "Moscow"}
        };

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            if(id <0 || id > _users.Count) return NotFound();

            User? user = _users.FirstOrDefault(u => u.Id == id);
            if(user == null) return NotFound(new {message = "Пользователь не найден"});
            else return user;
        }


    }
}
