public class Product
{
    protected string? name;

    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Product()
    {
    }

    public Product(double Price)
    {
        this.price = Price;
    }
}