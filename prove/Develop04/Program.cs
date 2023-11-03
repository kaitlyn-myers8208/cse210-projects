using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit ");
        Console.Write("Select a choice from the menu: ");
    
        string num = Console.ReadLine();
        int userChoice = int.Parse(num);
        int numBreathingActivities = 0;
        int numReflectionActivities = 0;
        int numListingActivities = 0;

        while(userChoice != 4)
        {
            if(userChoice == 1)
            {
                numBreathingActivities++;
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");
                breathingActivity.DisplayStartingMessage();
                breathingActivity.DisplayBreathingActivity();
                breathingActivity.DisplayEndingMessage();
            }
            else if(userChoice == 2)
            {
                numReflectionActivities++;
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity");
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.DisplayReflectionActivity();
                reflectionActivity.DisplayEndingMessage();
            }
            else if(userChoice == 3)
            {
                numListingActivities++;
                ListingActivity listingActivity = new ListingActivity("Listing Activity");
                listingActivity.DisplayStartingMessage();
                listingActivity.DisplayListingActivity();
                listingActivity.DisplayEndingMessage();
            }
            else if(userChoice == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("That's not a valid response, please try again. ");
            }
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit ");
            Console.Write("Select a choice from the menu: ");
        
            num = Console.ReadLine();
            userChoice = int.Parse(num);
        }

        if(numBreathingActivities > 0)
        {
            Console.WriteLine($"You did {numBreathingActivities} Breathing Activitie(s).");
        }
        if(numReflectionActivities > 0)
        {
            Console.WriteLine($"You did {numReflectionActivities} Reflection Activitie(s).");
        }
        if(numListingActivities > 0)
        {
            Console.WriteLine($"You did {numListingActivities} Listing Activitie(s).");
        }
    }
}