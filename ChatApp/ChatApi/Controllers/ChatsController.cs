using ChatEntities;
using ChatRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Controllers;

[ApiController]
[Route("api/chat")]

public class ChatsController : ControllerBase
{
    private readonly RepositoryContext _context;

    public ChatsController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Chats.ToList());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne([FromRoute] int id)
    {
        var entities = _context.Chats.Where(chatId => chatId.Id.Equals(id)).SingleOrDefault();

        if (entities is not null)
            return Ok(entities);
        return NotFound();
    }

    [HttpPost]
    public IActionResult Post(Chats chat)
    {
        try
        {
            chat.SendDate = DateTime.Now;
            _context.Chats.Add(chat);
            _context.SaveChanges();
            return Created("Item Created", chat);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    [HttpPut]
    public IActionResult Update(int id, Chats chat)
    {
        var entities = _context.Chats.Where(chatId => chatId.Id.Equals(id)).SingleOrDefault();

        if (entities is null)
            return NotFound();

        entities.Message = chat.Message;
        entities.Username = chat.Username;
        entities.SendDate = chat.SendDate;
        _context.SaveChanges();

        return NoContent();
    }
}