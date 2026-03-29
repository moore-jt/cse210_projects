

public class User
{
    private int _userId;
    public string _userName;
    public string _email;
    public List<Account> _accounts;

    public void AddAccount(Account a)
    {
        
    }

    public bool RemoveAccount(Account a)
    {
        return false;
    }

    public List<Account> GetAccounts()
    {
        return null;
    }
    
}