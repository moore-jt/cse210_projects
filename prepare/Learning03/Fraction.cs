

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // initializes fraction to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);

    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public int GetTop()
    {
        return _top;
    }

    public string GetFractionString()
    {
        string fracText = $"{_top}/{_bottom}";
        return fracText;
    }

    public double GetValue()
    {
        return (double)_top / (double)_bottom;
    }
}