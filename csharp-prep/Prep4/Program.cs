using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
    
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        int userNum = int.Parse(num);

        while (userNum != 0)
        {
        numbers.Add(userNum);
        Console.Write("Enter number: ");
        num = Console.ReadLine();
        userNum = int.Parse(num);
        }

        int smallestPositive = numbers.Max();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < smallestPositive && numbers[i] > 0)
            {
                smallestPositive = numbers[i];
            }
        }

        // Console.WriteLine(numbers.Count);
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}