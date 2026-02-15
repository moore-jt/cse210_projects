using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Parse csv file
        string filePath = "Scriptures.csv";
        string[] lines = File.ReadAllLines(filePath);
        List<Scripture> scriptureLibrary = new List<Scripture>();

        for (int i=1; i < lines.Length; i++)
        {
            string[] parts = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            if (parts.Length >= 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int firstVerse = int.Parse(parts[2]);
                int lastVerse = int.Parse(parts[3]);
                string text = parts[4].Trim('"').Replace("\\n", Environment.NewLine);

                Reference reference = new Reference(book, chapter, firstVerse, lastVerse);
                Scripture newScripture = new Scripture(reference, text);

                scriptureLibrary.Add(newScripture);

            }
        }

        Random random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide 3 words, type a number to hide that many words, or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || selectedScripture.IsCompletelyHidden())
            {
                break;
            }
            
            int amountToHide = 3;
            
            if (int.TryParse(input, out int userNumber))
            {
                amountToHide = userNumber;
            }
            
            selectedScripture.HideRandomWords(amountToHide);

        }

        

    }
}
