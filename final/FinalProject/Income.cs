

public class Income : Transaction
{
    public string _source;


    public Income(decimal amount) : base(amount) {}
    public override void Process()
    {
        
    }

    public override string GetSummary()
    {
        return string.Empty;   
    }


}