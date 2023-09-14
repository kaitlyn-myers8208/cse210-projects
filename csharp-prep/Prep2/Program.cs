using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float numPercentage = int.Parse(percentage);

        string letter = "q";
        string sign = "";

        if (numPercentage >= 90)
        {
            if (numPercentage % 10 < 3)
            {
                sign = "-";
            }
            letter = "A";
        }
        else if (numPercentage >= 80 && numPercentage < 90)
        {
            if (numPercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numPercentage % 10 < 3)
            {
                sign = "-";
            }
            letter = "B";
        }
        else if (numPercentage >= 70 && numPercentage < 80)
        {
            if (numPercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numPercentage % 10 < 3)
            {
                sign = "-";
            }
            letter = "C";
        }
        else if (numPercentage >= 60 && numPercentage < 70)
        {
            if (numPercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numPercentage % 10 < 3)
            {
                sign = "-";
            }
            letter = "D";
        }
        else if (numPercentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("That isn't a correct input");
            Environment.Exit(0);
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"Your grade is an {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"Your grade is a {letter}{sign}");
        }

        if (numPercentage >= 70)
        {
            if (numPercentage == 70)
            {
                Console.WriteLine("C's get degrees");
            }

            Console.WriteLine("Congrats! You passed the class!");
        }
        else if (numPercentage < 70)
        {
            Console.WriteLine("Whelp, there's always next semester...");
        }


    }
}