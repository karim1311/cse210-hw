public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;


    public Product(string name,int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }


    // METHODS
    public string ShowProductName()
    {
        return $"{_name}";
    }

    public string ProductId()
    {
        return $"{_id}";
    }

    public string ProductNameAndId()
    {
        return $"{_name}#{_id} ({_quantity})";
    }

    public string GetDisplayText()
    {
        return $"Id:{_id}\nName:{_name}\nPrice:{_price}\nQuantity:{_quantity}";
    }




    public double TotalCost()
    {
        double totalCost = 0D;
        totalCost = _price * _quantity;
        return totalCost;
    }

}