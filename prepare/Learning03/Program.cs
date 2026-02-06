using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetValue());

        Random random = new Random();
        Fraction fraction5 = new Fraction();
        
        for (int i = 0; i < 20; i++)
        {
            int numerator = random.Next(1, 11);
            int denominator = random.Next(1, 11);
            fraction5.SetTop(numerator);
            fraction5.SetBottom(denominator);
            Console.WriteLine($"Fraction {i + 1}: string: {fraction5.GetFractionString()} Number: {fraction5.GetValue()}");
        }
    }


    
}
