public class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }

    public Product(string name, int id, double price, int quantity)
    {
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }
    public double CalculatePrice()
    {
        double TotalPrice = Price * Quantity;

        return TotalPrice;
    }
}