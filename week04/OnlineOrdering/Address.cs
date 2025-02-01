public class Address
{
    private string _street;
    private string _city;
    private string _stateorprovince;
    private string _country;

    // CONSTRUCTOR
    public Address(string street,string city,string stateorprovince,string country)
    {
        _street = street;
        _city = city;
        _stateorprovince = stateorprovince;
        _country = country;
    }

    // METHODS
    public bool IsInUsa()
    {
        if(_country!="United States")
        {
            return false;
        } else
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        return $"{_street}\n{_city}, {_stateorprovince}\n{_country}";
    }
}