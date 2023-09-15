using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userResponse = Console.ReadLine();
        int userNum = int.Parse(userResponse);
        return userNum;
    }

    static int SquareNumber(int num)
    {
        int numSquared = num*num;
        return numSquared;
    }

    static void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SquareNumber(number);
        DisplayResult(name, squaredNum);

    }
}