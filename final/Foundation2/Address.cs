public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country.Equals("USA", StringComparison.CurrentCultureIgnoreCase) 
        || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetStringRepresentation()
    {
        return $"{_streetAddress}\r\n{_city},{_stateProvince}  {_country}";
    }
}