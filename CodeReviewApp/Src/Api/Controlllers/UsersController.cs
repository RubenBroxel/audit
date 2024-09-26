using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodeReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IUserRepository _userRepository;

        /*public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }*/

        // GET: api/Users
        [HttpGet]
        public ActionResult GetUsers()//<IEnumerable<User>>
        {
            //var users = _userRepository.GetUsers();
            return Ok();
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public ActionResult GetUser(int id)//<User> 
        {
            //var user = _userRepository.GetUser(id);
            if (id == null)
            {
                return NotFound();
            }
            return Ok();
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult CreateUser()//<User> 
        {
            ///_userRepository.AddUser(user);
            //return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            return Ok();
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id)//, User user)
        {
            if (id != null)//user.Id)
            {
                return BadRequest();
            }
            //_userRepository.UpdateUser(user);
            return NoContent();
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            ///var user = _userRepository.GetUser(id);
            if (id == null)
            {
                return NotFound();
            }
            //_userRepository.DeleteUser(user);
            return NoContent();
        }
    }
}