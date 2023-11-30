public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateOrProvince { get; set; }
    public string Country { get; set; }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }
    public bool IsInUSA()
    {
        if (Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayAddress()
    {
        string fullAddress = $"{StreetAddress}\n{City}, {StateOrProvince}, {Country}";

        return fullAddress;
    }
}