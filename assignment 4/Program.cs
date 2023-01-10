int amount = 10000;
int pin = 5869;
int cardnumber = 45786;
int amountToWithdraw = 0;
int balanceAmount = 0;
int amountToDeposit = 0;
int choices = 0;



int Deposit()
{
    Console.WriteLine("Enter the amount to be deposite");
    amountToDeposit = Convert.ToInt32(Console.ReadLine());
    amountToDeposit = balanceAmount + amountToDeposit;
    return amountToDeposit;
}

int Withdraw()
{
    Console.WriteLine("Enter the amount to withdraw");
    amountToWithdraw = Convert.ToInt32(Console.ReadLine());
    if (amount >= amountToWithdraw)
    {
        balanceAmount = amount - amountToWithdraw;
    }
       return amountToWithdraw;
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
    if ((pinNumber.Equals(pin)) & (cardNumber.Equals(cardnumber)))
    {
        while (!choices.Equals(4))
        {
            Mainmenu();
            switch (choices)
            {
                case 1:
                    Console.WriteLine($"The current balance in your account is {amount}: ");
                    break;
                case 2:
                    Withdraw();
                    Console.WriteLine($"Please collect the cash { amountToWithdraw}");
                    Console.WriteLine($"The current balance is now {balanceAmount}");
                    break;
                case 3:
                    Deposit();
                    Console.WriteLine($"The current balance in the account is{amountToDeposit}");
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