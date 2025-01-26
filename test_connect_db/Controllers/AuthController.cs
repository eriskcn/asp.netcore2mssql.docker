using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_connect_db.Data;
using test_connect_db.Models;

namespace test_connect_db.Controllers;

[Route("api/v0/auth")]
[ApiController]
public class AuthController(ApplicationDbContext context) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterModel model)
    {
        if (await context.Users
                .AnyAsync(user => user.Username == model.Username))
        {
            return BadRequest("Username is already exists.");
        }

        var user = new User
        {
            Username = model.Username,
            Password = model.Password,
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginModel model)
    {
        var user = await context.Users
            .FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

        if (user == null)
        {
            return Unauthorized("Invalid username or password.");
        }

        return Ok(new { Message = "Login successful!" });
    }
}