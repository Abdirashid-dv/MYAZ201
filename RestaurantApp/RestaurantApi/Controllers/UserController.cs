using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Services.Exceptions;

namespace RestaurantApi.Controllers;

[ApiController]
[Route("api/user")]

public class UserController : ControllerBase
{
    private UserRepository _userRepository;

    public UserController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // GET: User by id
    [HttpGet("{id:int}")]
    public IActionResult GetUser(int id)
    {
        var user = _userRepository.GetOne(id);

        if (user == null)
            throw new NotFoundException(id);

        return Ok(user);
    }

    // POST: Login user
    [HttpPost("login")]
    public IActionResult Login(string email, string password)
    {
        var user = _userRepository.GetData(email, password);

        if (user == null)
            throw new BadRequestException();
        return Ok(user);
    }

    // POST: Register user
    [HttpPost("register")]
    public IActionResult Register(User user)
    {

        _userRepository.Post(user);

        return Created("User Created!", user);
    }

    // Delete: User by id
    [HttpDelete("{id:int}")]
    public IActionResult DeleteUser(int id)
    {
        var user = _userRepository.GetOne(id);

        if (user == null)
            throw new BadRequestException();

        _userRepository.Delete(id);
        return NoContent();
    }


}
