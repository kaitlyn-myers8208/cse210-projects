using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pick a number for what you want to do\n 1) Write\n 2) Display\n 3) Save\n 4) Load\n 5) Quit");
        string num = Console.ReadLine();
        int userOption = int.Parse(num);

        Journal myJournal = new Journal();

        while (userOption != 5)
        {
            if (userOption == 1)
            {
                Console.WriteLine("Do you want to write a past entry? (Y/N)");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "Y")
                {
                    Entry oldEntry = new Entry();
                    oldEntry.NewEntry();
                    Console.WriteLine("What is the date of this entry? (MM/DD/YYYY)");
                    oldEntry.Date = Console.ReadLine();
                    myJournal.JournalEntries.Add(oldEntry);
                }
                else if (userAnswer == "N")
                {
                Entry entry = new Entry();
                entry.NewEntry();
                myJournal.JournalEntries.Add(entry);
                }
                else
                {
                    Console.WriteLine("That isn't a valid response.");
                }
            }
            else if (userOption == 2) 
            {
                myJournal.ListEntries();
            }
            else if (userOption == 3)
            {
                myJournal.SaveJournal();
            }
            else if (userOption == 4)
            {
                myJournal.LoadJournal();
            }
            else
            {
                Console.WriteLine("That is not a valid response");
            }

            Console.WriteLine("Pick a number for what you want to do\n 1) Write\n 2) Display\n 3) Save\n 4) Load\n 5) Quit");
            num = Console.ReadLine();
            userOption = int.Parse(num);
        }
    }

}