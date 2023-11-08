using StoreApp.Models;
using StoreApp.Models.Exceptions;

namespace StoreApp.Repositories;

public class ProductRepository
{
    private List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>()
        {
            new Product(){Id = 1, ProductName = "Computer", Price = 75_000},
            new Product(){Id = 2, ProductName = "Iphone", Price = 50_000},
            new Product(){Id = 3, ProductName = "AirPods", Price = 75_00},

        };
    }

    // Methods
    public void Add(Product item)
    {
        _products.Add(item);
    }
    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public Product GetOneProduct(int id)
    {
        try
        {
            var product = _products.SingleOrDefault(prd => prd.Id.Equals(id));

            if (product is null)
                throw new ProductNotFoundException(id);

            return product;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}