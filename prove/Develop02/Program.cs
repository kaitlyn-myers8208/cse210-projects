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
                Entry entry = new Entry();
                entry.NewEntry();
                myJournal.JournalEntries.Add(entry);
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