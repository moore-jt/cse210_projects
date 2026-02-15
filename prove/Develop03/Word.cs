using System.Diagnostics;

class Word
{
    private string _word;
    private bool _isHidden;

    
    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            if (_word.Contains(Environment.NewLine))
            {
                return Environment.NewLine + new string('_', _word.Length - Environment.NewLine.Length);
            }
            return new string('_', _word.Length);
        }

        return _word;
    }
}