public class Order
{
    private List<Product> products = new List<Product>();
    public Customer Customer { get; set; }
    public double Price { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Price = 0;
    }

    public double CaclculateTotalOrderCost()
    {
        foreach (Product p in products)
        {
            Price += p.CalculatePrice();
        }
        Price += CalculateShippingCost();
        Price = Math.Round(Price, 2);
        
        return Price;
    }
    public int CalculateShippingCost()
    {
        int shippingCost;
        if (Customer.FromUnitedStates())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public string DisplayPackingLabel()
    {
        string packingLabel = "";
        foreach (Product p in products)
        {
            packingLabel += $"{p.Name} {p.Id} x{p.Quantity}\n";
        }

        return packingLabel;
    }
    public string DisplayShippingLabel()
    {
        string shippingLabel = Customer.CustomerAddress.DisplayAddress();

        return shippingLabel;
    }
    public void AddToProducts(Product product)
    {
        products.Add(product);
    }

}