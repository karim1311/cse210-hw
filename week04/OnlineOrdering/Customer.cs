public class Customer
{
    // ATTRIBUTES
    private string _name;
    private Address _address;


    // CONSTRUCTOR
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    // METHODS
    public string CustomerName(){
        return $"{_name}";
    }

    public string CustomerAddress(){
        return $"{_address.GetDisplayText()}";
    }
    public bool UsaCustomer()
    {
        if(_address.IsInUsa()!=true)
        {
            return false;
        } else 
        {
            return true;
        }
    }
}