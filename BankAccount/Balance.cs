using System.Transactions;

class BankStatementList
{
    //field
    private readonly List<BankStatement> _balancesheet;

    //properties

    //public List<Contact> Contacts
    public BankStatementList()
    {
        _balancesheet = new List<BankStatement>();
    }

    public void AddStatement(BankStatement statement)

    {
        _balancesheet.Add(statement);
    }
    public void PrintStatement()
    {

        foreach (var item in _balancesheet)
        {
            Console.WriteLine(item);
        }

    }
    public double MonthlyNetBalance(int Month)
    {
        double netBalance = 0.0;
        foreach (var item in _balancesheet)
        {
            if (item.date.Month == Month)
            {
                netBalance += item.Amount;
            }
        }
        return netBalance;
    }
    public double Balance()
    {
        double totalAmount = 0.0;
        foreach (var item in _balancesheet)
        {
            totalAmount += item.Amount;
        }
        return totalAmount;
    }
}
