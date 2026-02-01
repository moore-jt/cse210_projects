

using System.Runtime.CompilerServices;

public class Entry
{
    public string _date = "";
    public string _location = "";
    public string _currentPrompt = "";
    
    public string _userResponse = "";


    public void Display()
    {
        Console.WriteLine($"{_date} - {_location} - Prompt: {_currentPrompt}");
        Console.WriteLine(_userResponse);
        Console.WriteLine();
    }
    
}   