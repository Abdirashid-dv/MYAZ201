namespace Models;

public class Product
{
    public int ProductId { get; set; }
    public String ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddYears(1);
    public int StockQuantity { get; set; }
}