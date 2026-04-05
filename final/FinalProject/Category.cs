

public class Category
{
    public string Name { get; set; }
    private decimal _budgetLimit;
    private decimal _currentSpending;

    public Category(string name, decimal limit)
    {
        Name = name;
        _budgetLimit = limit;
        _currentSpending = 0;
    }

    public bool CheckLimit(decimal newExpenseAmount)
    {
        _currentSpending += newExpenseAmount;
        return _currentSpending > _budgetLimit;
    }
}
