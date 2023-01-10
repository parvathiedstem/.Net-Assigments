int a = 0;
int b = 0;
int c = 0;

Console.Write("Please enter a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter c: ");
c = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine($"result: {(((a + b) / c) * a)}");
}
catch(DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");
}
catch(Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}