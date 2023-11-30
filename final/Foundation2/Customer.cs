public class Customer
{
    public string Name { get; set; }
    public Address CustomerAddress { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;        
    }
    public bool FromUnitedStates()
    {
        return CustomerAddress.IsInUSA();
    }

}