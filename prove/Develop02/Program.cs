using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();


        int choice = 0;

        while(true)
        {
            journal.DisplayMenu();
            choice = int.Parse(Console.ReadLine());
            
            if(choice == 1) // Write
            {
                Entry entry = new Entry();
                entry._currentPrompt = journal.GeneratePrompt();
                entry._date = DateTime.Now.ToShortDateString();

                Console.WriteLine(entry._currentPrompt);
                entry._userResponse = Console.ReadLine();
                Console.WriteLine($"Please add a location:");
                entry._location = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if(choice == 2) // Display Journal
            {
                journal.DisplayJournal();
            }
            else if(choice == 3) // Load File
            {
                Console.WriteLine("What is the name of the file?");
                journal._fileName = Console.ReadLine();
                journal.LoadFile();
            }
            else if(choice == 4) // Save File
            {
                Console.WriteLine("What is the file name?");
                journal._fileName = Console.ReadLine();
                journal.SaveFile();
            }
            else if(choice == 5) // End
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number 1-5");
            }




        }

        
    }
}
