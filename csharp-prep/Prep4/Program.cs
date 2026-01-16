using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        int entry = -1;

        while (entry != 0)
        {
            entry = int.Parse(Console.ReadLine());

            if (entry != 0)
            {
                numberList.Add(entry);
            }
            else
            {
                break;
            }
        }

        int listTotal = 0;
        int listIndex = 0;
        int max = numberList[0];
        int min = numberList [0];

        foreach (int number in numberList)
        {
            listTotal += number;
            listIndex++;
            if (number > max) max = number;
            if (number < min) min = number;
        }
        
        int listAvg = listTotal / listIndex;


        Console.WriteLine($"The sum of the numbers is {listTotal}.");
        Console.WriteLine($"The average number is {listAvg}.");
        Console.WriteLine($"There are {listIndex} numbers in the list.");
        Console.WriteLine($"The highest number in the list is {max}");
        Console.WriteLine($"The lowest number in the list is {min}");
        Console.WriteLine("The sorted list is:");

        numberList.Sort();
        foreach (int number in numberList)
        {
            Console.Write($"{number} ");
        }





    }
}
