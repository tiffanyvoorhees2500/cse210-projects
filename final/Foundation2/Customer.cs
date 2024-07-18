public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressStringRepresentation()
    {
        return _address.GetStringRepresentation();
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
}