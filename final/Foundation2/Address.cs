

class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateOrProvince = "";
    private string _country = "";


    public Address()
    {

    }
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool USATrueFalse()
    {
        if(_country == "USA")
        {
            return true;
        }
        else 
            return false;
    }
    public string AddressString()
    {
        string address = $"{_streetAddress}\n{_city} {_stateOrProvince} {_country}";

        return address;
    }
    public string GetCountry()
    {
        return _country;
    }

}