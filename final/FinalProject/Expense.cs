

public class Expense : Transaction
{
    public string _merchant;
    public bool _recurring;

    public Expense(decimal amount) : base(amount)
    {
        
    }

    public override void Process()
    {

    }

    public override string GetSummary()
    {
        return string.Empty;
    }
}