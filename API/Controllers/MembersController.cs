using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetMembers()
    {
        var members = context.Users.ToList();
        return members;
    }

    [HttpGet("{id}")]
    [Authorize]
    public ActionResult<AppUser> GetMember(string id)
    {
        var member = context.Users.Find(id);
        if (member == null) return NotFound();

        return member;
    }
}
