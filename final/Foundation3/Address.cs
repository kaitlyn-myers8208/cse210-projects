public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        StreetAddress = streetAddress;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public string DisplayAddress()
    {
        string fullAddress = $"{StreetAddress}, {City}, {State} {ZipCode}";

        return fullAddress;
    }
}