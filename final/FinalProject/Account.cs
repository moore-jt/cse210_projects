

public class Account
{
    private int _accountId;
    private string _name;
    private decimal _balance;
    private List<Transaction> _transactions;

    public void AddTransaction(Transaction t)
    {
        _transactions.Add(t);
        t.Process();

        if (t is Income) _balance += t._amount;
        else if (t is Expense) _balance -= t._amount;

        Console.WriteLine($"New Balance: {_balance:C}");
    }

    public Transaction RemoveTransaction(Transaction t)
    {
        return null;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public List<Transaction> GetTransactions()
    {
        return null;
    }
}
