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
        }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(ListEntries);
        }
    }
}