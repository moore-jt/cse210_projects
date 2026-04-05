

public abstract class Transaction
{
    protected decimal _amount;
    protected DateTime _date;
    protected string _description;
    protected Category _category;

    public decimal Amount
    { 
        get { return _amount; } 
    }

    public DateTime Date 
    { 
        get { return _date; } 
        set { _date = value; } 
    }

    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }

    public Category TransactionCategory
    {
        get { return _category; }
        set { _category = value; }
    }
    
    public Transaction(decimal amount)
    {
        _amount = amount;
        _date = DateTime.Now;
    }

    public abstract void Process();

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} | Transaction: {_amount:C}";
    }



}
