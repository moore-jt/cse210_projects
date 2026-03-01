

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well Done! ");
        ShowSpinner(2);
        Console.WriteLine();
        Console.Write($"You have completed another {_duration} seconds of {_name}. ");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerCharacters = ["|", "/", "-", "\\"];

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string c = spinnerCharacters[i];
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(c);
            Console.ResetColor();
            Thread.Sleep(250);

            Console.Write("\b \b");

            i++;
            if (i >= spinnerCharacters.Count)
            {
                i = 0;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}