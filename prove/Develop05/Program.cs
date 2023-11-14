using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.WriteLine("You have 0 points.\n");

        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInt = Console.ReadLine();
        int userResponse = int.Parse(userInt);

        while (userResponse != 6)
        {
            if (userResponse == 1)
            {

            }
            else if (userResponse == 2)
            {

            }
            else if (userResponse == 3)
            {

            }
            else if (userResponse == 4)
            {

            }
            else if (userResponse == 5)
            {

            }
            else
            {
                Console.WriteLine("That's not a valid response. Please try again");
            }

            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
        
            userInt = Console.ReadLine();
            userResponse = int.Parse(userInt);
        }
    }
}