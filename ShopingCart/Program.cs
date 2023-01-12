var product1 = new ShoppingCartEntry("AC", 25000, 2);
var product2 = new ShoppingCartEntry("shoe", 2000, 3);
var product3 = new ShoppingCartEntry("headset", 2000, 5);
var cart = new ShoppingCart();
Order order = new Order();



try
{
    void AddCart()
    {
        cart.AddCart(product1);
        cart.AddCart(product2);
        cart.AddCart(product3);
    }
    {
        AddCart();
        cart.PrintCart();
        GrandTotal();
    }
    void GrandTotal()
    {
        double grandtotal = cart.GetTotal();
        Console.WriteLine($"Total price is {order.GetTotalPrice(grandtotal)}: ");
    }
}
catch (Exception ex)
{
    throw ex;
}


