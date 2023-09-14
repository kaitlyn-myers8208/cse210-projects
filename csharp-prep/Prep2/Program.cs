using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float numPercentage = int.Parse(percentage);

        if (numPercentage >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (numPercentage >= 80 && numPercentage < 90)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (numPercentage >= 70 && numPercentage < 80)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (numPercentage >= 60 && numPercentage < 70)
        {
            Console.WriteLine("Your grade is a D");
        }
        else if (numPercentage < 60)
        {
            Console.WriteLine("Your grade is an F");
        }

    }
}