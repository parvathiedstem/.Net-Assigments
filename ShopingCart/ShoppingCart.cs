class ShoppingCart
{
    private readonly List<ShoppingCartEntry> _entries;

    public ShoppingCart()
    {
        _entries = new List<ShoppingCartEntry>();
    }
    public void AddCart(ShoppingCartEntry product)
    {
        _entries.Add(product);
    }
      public void PrintCart()
    {
        foreach (var item in _entries)
        {
            Console.WriteLine(item);
        }
    }
    
    public double GetTotal()
    {
        double total = 0.0;
        foreach (var item in _entries)
        {
            total += item.Quantity * item.Price;
        }
        return total;
    }
  
}

