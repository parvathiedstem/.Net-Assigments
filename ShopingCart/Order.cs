class Order
{
    private double _tax = 0.001;

    public double GetTotalPrice(double sum)
    {
        double grandtotal = sum + (sum * _tax);
        return grandtotal;
    }
}