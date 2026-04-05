using System.Text.Json.Serialization;

public class Account
{
    [JsonInclude]
    private string _name;
    [JsonInclude]
    private decimal _balance;
    [JsonInclude]
    private List<Transaction> _transactions;

    public string Name
    {
        get {return _name; } 
        set {_name = value; }
    }

    public decimal Balance 
    { 
        get {return _balance;} 
    }

    public Account(string name)
    {
        _name = name;
        _balance = 0;
        _transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction t)
    {
       _transactions.Add(t);

       t.Process();

       if (t is Income)
       {
            _balance += t.Amount;
       }
       else if (t is Expense)
       {
            _balance -= t.Amount;
       }
    }

    public bool RemoveTransaction(Transaction t)
    {
        if (_transactions.Contains(t))
        {
            if (t is Income)
            {
                _balance -= t.Amount;

            }
            else if (t is Expense)
            {
                _balance += t.Amount;
            }

            _transactions.Remove(t);

            Console.WriteLine($"[SYSTEM] Transaction removed. Adjusted balance: {_balance:C}");
            return true;
        }
        else
        {
            Console.WriteLine("[ERROR] Transaction not found in this account.");
            return false;
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public List<Transaction> GetTransactions()
    {
        return _transactions;
    }
}
