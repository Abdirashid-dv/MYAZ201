using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Services.Exceptions;

namespace RestaurantApi.Controllers;

[ApiController]
[Route("api/item")]

public class ItemController : ControllerBase
{
    private ItemRepository _itemRepository;

    public ItemController(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    // GET: All items
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = _itemRepository.GetAll();

        return Ok(items);
    }

    // GET: Item by id
    [HttpGet("{id}")]
    public IActionResult GetItem(int id)
    {
        var item = _itemRepository.GetOne(id);

        if (item == null)
            throw new NotFoundException(id);

        return Ok(item);
    }

    // POST: Add item
    [HttpPost]
    public IActionResult AddItem(string name, string description, decimal price, int categoryId)
    {
        var item = new Items
        {
            Name = name,
            Description = description,
            Price = price,
            CategoryId = categoryId
        };

        _itemRepository.Post(item);

        return Created("Item created!", item);
    }

    // Delete: Delete item

    [HttpDelete("{id}")]
    public IActionResult DeleteItem(int id)
    {
        var item = _itemRepository.GetOne(id);

        if (item == null)
            throw new BadRequestException();

        _itemRepository.Delete(id);

        return NoContent();
    }

}