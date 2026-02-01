using System.Diagnostics.CodeAnalysis;
using System.IO;

public class Journal
{
    public List<string> _journalPrompts = new List<string>
    {
    "What moment from today would you like to remember a year from now, and why?",
    "What has been taking up the most mental space for you lately?",
    "Describe a small win you’ve had recently that you might normally overlook.",
    "What does your ideal ordinary day look like?",
    "When do you feel most like yourself, and what are you usually doing then?",
    "What is something you’ve learned about yourself in the past month?",
    "What’s a habit that’s helping you right now, even if it’s imperfect?",
    "What’s one thing you’re avoiding, and what might happen if you faced it?",
    "Who has positively influenced you recently, and how?",
    "What emotion have you been feeling most often lately?",
    "What’s something you’re looking forward to, even if it’s small?",
    "What part of your life feels most stable right now?",
    "What’s a decision you’re glad you made in the past?",
    "What does rest look like for you when it’s actually working?",
    "What’s something you want more of in your life, and why?",
    "What’s a recent challenge that taught you something useful?",
    "What boundaries have you set recently, or need to set?",
    "What’s a belief about yourself that might be worth reexamining?",
    "How have your priorities shifted compared to a year ago?",
    "What would you tell your past self from six months ago?",
    "What stood out to you most about today?",
    "How did you feel when you started the day, and how do you feel now?",
    "What was the most meaningful thing you did today?",
    "What took up most of your time today, and how did it feel?",
    "What was one small moment today that you appreciated?",
    "What challenged you today, even in a minor way?",
    "What energized you today?",
    "What drained your energy today?",
    "What did you learn or realize today?",
    "What decision did you make today, and how do you feel about it?",
    "Who did you interact with today, and how did it affect your mood?",
    "What did you avoid today, if anything?",
    "What went better today than you expected?",
    "What didn’t go as planned today, and how did you respond?",
    "What emotion showed up the most for you today?",
    "What are you proud of from today?",
    "What’s something you wish you had done differently today?",
    "What helped you get through today?",
    "What part of today felt the most calm or grounded?",
    "How would you summarize today in one sentence?"
    };

    public string _fileName = "";

    public List<Entry> _journal = new List<Entry>();

    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?\n");
    }

    public string GeneratePrompt()
    {
        string[] randomPrompt = Random.Shared.GetItems(_journalPrompts.ToArray(), 1);
        return randomPrompt[0];
    }

    public void AddEntry(Entry newEntry)
    {
        _journal.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public void LoadFile()
    {
        string[] lines = File.ReadAllLines(_fileName);
        _journal.Clear();
        foreach(string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("~");

            entry._date = parts[0];
            entry._currentPrompt = parts[1];
            entry._location = parts[2];
            entry._userResponse = parts[3];

            _journal.Add(entry);
        }
        Console.WriteLine("File loaded successfully");
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._date}~{entry._currentPrompt}~{entry._location}~{entry._userResponse}");
            }
        }

    }


}
