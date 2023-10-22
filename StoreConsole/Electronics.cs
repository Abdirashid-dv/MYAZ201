public class Electronics : Product
{
    private string brand;
    public string Brand
    {
        get { return brand; }
    }


    private double wattage;

    public double Wattage
    {
        get { return wattage; }
    }


    public Electronics(double Price) : base(Price)
    {
        name = "Mobile LightWeight Charger";
        brand = "Samsung";
        wattage = 44.5578;
    }

    public override string ToString()
    {
        return $"{name}---> {brand}---> {wattage:N3}";
    }


}