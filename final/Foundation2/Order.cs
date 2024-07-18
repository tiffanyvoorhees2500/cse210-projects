public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotal();
        }

        return total;
    }

    public decimal CalculateShipping()
    {
        if (_customer.IsInUsa())
        {
            //Shipping cost within USA
            return 5;
        }
        else
        {
            //Shipping cost outside the USA
            return 35;
        }
    }

    public decimal CalculateTotalWithShipping()
    {
        return CalculateTotal() + CalculateShipping();
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }

    public string GetPackingLabelStringRepresentation()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetPackingLabelString()}\r\n";
        }

        return label;
    }

    public string GetShippingLabelStringRepresentation()
    {
        return $"{_customer.GetName()}\r\n{_customer.GetAddressStringRepresentation()}";
    }

    public string GetTotalStringRepresentation()
    {
        string orderTitle = "Order Total:";
        string shippingTitle = "Shipping:";
        string grandTitle = "GRAND TOTAL:";

        return $"{orderTitle.PadRight(15)}${CalculateTotal()}\r\n{shippingTitle.PadRight(15)}${CalculateShipping()}\r\n_______________________\r\n{grandTitle.PadRight(15)}${CalculateTotalWithShipping()}";
    }
}