namespace StoreApp.Models;

public class Product : IComparable
{
    // Properties
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is Product otherProduct)
            return this.Price.CompareTo(otherProduct.Price);
        else
            throw new ArgumentException("They are not Same Class");
    }
}