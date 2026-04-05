using System.Text.Json.Serialization;


public class User
{
    private string _username;
    private string _email;

    [JsonInclude]

    private List<Account> _accounts;
    private List<Budget> _budgets;

    public string Username { get { return _username; } set { _username = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public List<Budget> Budgets { get { return _budgets; } }

    public User(string username, string email)
    {
        _username = username;
        _email = email;
        _accounts = new List<Account>();
        _budgets = new List<Budget>(); // Initialize
    }

    public void AddAccount(Account a)
    {
        if (a != null)
        {
            _accounts.Add(a);
            Console.WriteLine($"[USER] Account '{a.Name}' successfully linked to {_username}.");
        }
    }

    public void AddBudget(Budget b)
    {
        _budgets.Add(b);
    }

    public List<Account> GetAccounts() => _accounts;

    public decimal GetTotalBalance()
    {
        decimal total = 0;
        foreach (Account acc in _accounts) { total += acc.GetBalance(); }
        return total;
    }
}
