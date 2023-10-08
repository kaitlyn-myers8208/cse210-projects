public class Journal
{
    public List<Entry> JournalEntries = new List<Entry>();
    public string FileName;
    public string UserOption;

    public Journal()
    {
    }

    public void ListEntries()
    {
        foreach (Entry e in JournalEntries)
        {
            e.DisplayEntry();
            // make it so the list is sorted by date
        }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in JournalEntries)
            {
                outputFile.WriteLine($"Date: {e.Date} - Prompt: {e.Prompt}\n{e.UserResponse}\n");
            }
        }
        Console.WriteLine("File saved.");
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Loading file...");

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);            
        }
    }
}