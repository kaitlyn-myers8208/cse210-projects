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

        if(userChoice == 1)
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");
            breathingActivity.DisplayStartingMessage();
            breathingActivity.DisplayBreathingActivity();
            breathingActivity.DisplayEndingMessage();
        }
        else if(userChoice == 2)
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity");
            reflectionActivity.DisplayStartingMessage();
            reflectionActivity.DisplayReflectionActivity();
            reflectionActivity.DisplayEndingMessage();
        }
        else if(userChoice == 3)
        {
            ListingActivity listingActivity = new ListingActivity("Listing Activity");
            listingActivity.DisplayStartingMessage();

            listingActivity.DisplayEndingMessage();
        }
        else if(userChoice == 4)
        {
            return;
        }
    }
}