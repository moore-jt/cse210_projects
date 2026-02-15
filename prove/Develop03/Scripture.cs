using System.Runtime.Serialization;
using System.Text.RegularExpressions;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string formattedText = Regex.Replace(text, @" (\d+)", "\n$1");

        string[] splitWords = formattedText.Split(" ");
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }

    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"~{_reference.GetDisplayText()}~\n{scriptureText.Trim()}"; 
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}