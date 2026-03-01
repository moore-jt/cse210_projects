using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        int selection;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (selection == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (selection == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (selection == 4)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Please try again.");
            }
        }
    }
}
