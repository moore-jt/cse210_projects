

using System.Security.Cryptography;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }


    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Breathe Out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.ResetColor();
        }

        DisplayEndingMessage();
    }
}