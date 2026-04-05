

public class Income : Transaction
{
   private string _source;

   public string Source
    {
        get {return _source;} 
        set {_source = value;}
    }

    public Income(decimal amount, string source) : base(amount)
    {
        _source = source;
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} | [+] {_amount:C} | Source: {_source}";
    }

    public override void Process() 
    { 
        Console.WriteLine($"[LOG] Income of {_amount:C} from {_source} processed.");
    }


}
