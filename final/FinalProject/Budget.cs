

public class Budget
{
    public int _budgetId;
    public Category _category;
    public decimal _limit;
    private DateTime _startDate;
    private DateTime _endDate;

    public decimal UpdateSpending()
    {
        return 0;
    }

    public bool IsOverBudget()
    {
        return false;
    }
}