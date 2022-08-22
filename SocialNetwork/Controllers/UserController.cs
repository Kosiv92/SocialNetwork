using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SocialNetLibrary.Models;
using System.Text.Json;

namespace SocialNetwork.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        List<User> _users;

        public UserController()
        {
            _users = new List<User>
            {
            new User { Id = 1, UserName = "Mark", Age = 18, City = "London"},
            new User { Id = 2, UserName = "Carl", Age = 28, City = "New-York"},
            new User { Id = 3, UserName = "Ivan", Age = 30, City = "Moscow"}
            };
        }

        /// <summary>
        /// Get list of users
        /// </summary>
        /// <returns>All application users</returns>
        [HttpGet()]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            if (_users.Count == 0) return NotFound();
            else return _users;
        }

        /// <summary>
        /// Get user by his Id
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>User with specified id</returns>
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            if (id < 0 || id > _users.Count) return NotFound();

            User? user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound(new { message = "Пользователь не найден" });
            else return user;
        }

        /// <summary>
        /// Delete user by his Id
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Result of delete-operation</returns>
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<User>> DeleteUser(int id)
        {
            if (id < 0 || id > _users.Count) return NotFound();
            User? user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound(new { message = "Пользователь не найден" });
            else
            {                
                _users.Remove(_users.FirstOrDefault(u => u.Id == id));
                return _users;
            }
        }

        [HttpPost()]
        public ActionResult<IEnumerable<User>> AddUsers(HttpContext context)
        {            
            var data = context.Request.Body;
            
            using(StreamReader sr = new StreamReader(data))
            {
                string json = sr.ReadToEnd();
                var newUsers = JsonConvert.DeserializeObject<List<User>>(json);
                _users.AddRange(newUsers);
            }
                               
            return _users;
        }


    }
}
