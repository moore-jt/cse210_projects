

public class Expense : Transaction
{
    private string _merchant;

    public string Merchant 
    { 
        get { return _merchant; } 
        set { _merchant = value; } 
    }
    public Expense(decimal amount, Category category, string merchant) : base(amount)
    {
        _merchant = merchant;
        TransactionCategory = category;
    }

    public override void Process()
    {
        Console.WriteLine($"[LOG] Processing {_amount:C} expense at {_merchant}...");

        if (TransactionCategory != null)
        {
            bool isOver = TransactionCategory.CheckLimit(_amount);

            if (isOver)
            {
                Console.WriteLine($"!!! WARNING !!! This expense puts you over your {TransactionCategory.Name} budget!");
            }
        }
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} | [-] {_amount:C} | {_merchant} ({TransactionCategory.Name})";
    }
}
