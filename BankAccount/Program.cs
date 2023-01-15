using System.Globalization;
using System.Transactions;

BankStatementList bankstatement = new BankStatementList();

void ReadFromFile()
{
    string[] lines = File.ReadAllLines(@"C:\Users\hp\test.csv");
    string[] columns;
    string[] dates;

    Console.WriteLine("Contents of test.csv = ");
    foreach (string line in lines)
    {
        columns = line.Split(",");
        dates = columns[0].Split("-");

        DateTime parsedDate = DateTime.Parse($"{dates[2]}-{dates[1]}-{dates[0]}", CultureInfo.InvariantCulture);
        DateOnly date = DateOnly.FromDateTime(parsedDate);
        Console.WriteLine($"Press any key to exit.{dates[1]}");

        double Amount = Convert.ToDouble(columns[1]);
        string ToAccount = columns[2];

        BankStatement statement = new BankStatement(date, Amount, ToAccount);
        bankstatement.AddStatement(statement);

        Console.WriteLine("Enter the month : ");
        int month = Convert.ToInt32(Console.ReadLine());
        if (month == 01)
        {
            Console.WriteLine($"Net Balance of the month : {bankstatement.MonthlyNetBalance(month)}");
        }

        bankstatement.PrintStatement();
        Console.WriteLine($"Balance: {bankstatement.Balance()}");

    }
    // Keep the console window open in debug mode.
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}
ReadFromFile();