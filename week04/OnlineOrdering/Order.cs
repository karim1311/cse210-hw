public class Order 
{
    // ATTRIBUTES
    private Customer _customer;
    private List<Product> _products = new List<Product>();


    // CONSTRUCTORS
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // METHODS
    public void AddProduct(string name,int id, double price, int quantity){
        Product product = new Product(name,id,price,quantity);

        _products.Add(product);
    }

    public void ShowProducts()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetDisplayText());
        }
    }

    public string TotalCost()
    {
        double totalCost = 0D;
        foreach(Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        double shippingCost = 0D;
        if(_customer.UsaCustomer()==true)
        {
            shippingCost = 5D;
            Console.WriteLine($"The subtotal of your order is ${totalCost}");
            Console.WriteLine($"This order will be shipped within the U.S.");
            Console.WriteLine($"Shipping Cost inside US : ${shippingCost}");
        } else
        {
            shippingCost = 35;
            Console.WriteLine("This order will be shipped outside the U.S.");
            Console.WriteLine($"Shipping Cost outside US : ${shippingCost}");
            Console.WriteLine($"The subtotal of your order is ${totalCost}");
        };

        totalCost = totalCost + shippingCost;

        return $"Total: ${totalCost}";
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += ' ' + product.ProductNameAndId() + '\n'; 
        }
        return $"{packingLabel}";
    }

    public string ShippingLabel()
    {
        return $"{_customer.CustomerName()}\n{_customer.CustomerAddress()}";
    }


}