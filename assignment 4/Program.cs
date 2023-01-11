int amount = 10000;
int pin = 5869;
int cardnumber = 45786;
int choices = 0;





void Balance()
{
    Console.WriteLine($"The current balance in your account is {amount}: ");
}

void Deposit()
{
    Console.WriteLine("Enter the amount to be deposite");
    int amountToDeposit = Convert.ToInt32(Console.ReadLine());
    amount += amountToDeposit;
    Balance();
}

void Withdraw()
{
    Console.WriteLine("Enter the amount to withdraw");
    int amountToWithdraw = Convert.ToInt32(Console.ReadLine());
    if (amount >= amountToWithdraw)
    {
        amount -= amountToWithdraw;
    }
    else
    {
        Console.WriteLine("Insufficient Balance");
    }
    Balance();
}

void Mainmenu()
{
    Console.WriteLine("1.To check balance");
    Console.WriteLine("2.To withdraw amount");
    Console.WriteLine("3.To deposite amount");
    Console.WriteLine("4.To cancel the transaction");
    Console.WriteLine("select the choice");
    choices = Convert.ToInt32(Console.ReadLine());
}
try
{
    Console.Write("enter the pin number: ");
    int pinNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter card number: ");
    int cardNumber = Convert.ToInt32(Console.ReadLine());
    if (pin == pinNumber && cardnumber == cardNumber)
    {
        while (!choices.Equals(4))
        {
            Mainmenu();
            switch (choices)
            {
                case 1:
                    Balance();
                    break;
                case 2:
                    Withdraw();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using ATM");
                    break;
                default:
                    Console.WriteLine("Please select correct option");
                    break;
            }
        }

    }
    else
        Console.WriteLine("Invalid Pin or Cardnumber");
}
catch (Exception ex)
{
    throw ex;
 }