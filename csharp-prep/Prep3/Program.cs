using System;

class Program
{
    static void Main(string[] args)
    {
    
        // Console.WriteLine("What is the magic number? ");
        // string num = Console.ReadLine();
        // int magicNum = int.Parse(num);

        string userResponse = "No";

        do
        {

            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,101);

            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);

            int numOfGuesses = 1;

            while (userGuess != magicNum)
            {
                if (userGuess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                Console.WriteLine("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);
                numOfGuesses++;
            }
            
            Console.WriteLine($"You guess it! It took you {numOfGuesses} guesses.");

            Console.WriteLine("Do you want to play again? ");
            userResponse = Console.ReadLine();

        } while (userResponse == "Yes");


    }
}