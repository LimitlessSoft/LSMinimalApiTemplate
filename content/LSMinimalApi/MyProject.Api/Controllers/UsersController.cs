using MyProject.Contracts.IManagers;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Api.Controllers;

[ApiController]
public class UsersController (IUserManager userManager)
    : ControllerBase
{
    [HttpGet]
    [Route("/users")]
    public IActionResult GetUsers() =>
        Ok(userManager.GetUsers());
}