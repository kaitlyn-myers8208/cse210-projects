using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pick a number for what you want to do\n 1) Write\n 2) Write missed entry\n 3) Display\n 4) Save\n 5) Load\n 6) Quit");
        Console.Write("What would you like to do? ");
        string num = Console.ReadLine();
        int userOption = int.Parse(num);

        Journal myJournal = new Journal();

        while (userOption != 6)
        {
            if (userOption == 1)
            {
                Entry entry = new Entry();
                entry.NewEntry();
                myJournal.JournalEntries.Add(entry);
            }
            else if (userOption == 2)
            {
                Entry oldEntry = new Entry();
                oldEntry.NewEntry();
                Console.WriteLine("What is the date of this entry? (MM/DD/YYYY)");
                oldEntry.Date = Console.ReadLine();
                myJournal.JournalEntries.Add(oldEntry);
            }
            else if (userOption == 3) 
            {
                myJournal.ListEntries();
            }
            else if (userOption == 4)
            {
                myJournal.SaveJournal();
            }
            else if (userOption == 5)
            {
                myJournal.LoadJournal();
            }
            else
            {
                Console.WriteLine("That is not a valid response");
            }

            Console.WriteLine("Pick a number for what you want to do\n 1) Write\n 2) Write missed entry\n 3) Display\n 4) Save\n 5) Load\n 6) Quit");
            Console.Write("What would you like to do? ");
            num = Console.ReadLine();
            userOption = int.Parse(num);
        }
    }

}

// I added the ability to add a past entry and add your own date. This helps solve the problem of writing an entry
// that you may have missed or if you write it up past midnight, but still want it to count for that day.