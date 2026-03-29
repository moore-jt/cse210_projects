

public abstract class Transaction
{
    protected decimal _amount;
    public DateTime _date;
    public string _description;

    public Transaction(decimal amount)
    {
        
    }

    public abstract void Process();

    public virtual string GetSummary()
    {
        return string.Empty;
    }



}