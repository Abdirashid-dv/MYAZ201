using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
    private readonly RepositoryContext _productRepository;

    public ProductsController(RepositoryContext productRepository)
    {
        _productRepository = productRepository;
    }

    //  api/products/search-by-product-name
    [HttpGet("search-by-product-name")]
    public IActionResult SearchByProductName([FromQuery] string name)
    {
        var products = _productRepository.Products
            .Where(p => p.ProductName.ToLower().Contains(name.ToLower()))
            .ToList();
        return Ok(products);
    }


}