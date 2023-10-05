public class Entry
{
    public string UserResponse;
    public string Prompt;
    public string Date;
    public Random rnd = new Random(); 
    public DateTime theCurrentTime = DateTime.Now;
    public List<string> promptOptions = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What tender mercies did I see today?",
            "What can I do to prepare myself for tomorrow?",
            "How am I doing on my goals?"
        };

    public Entry()
    {
        Prompt = promptOptions[rnd.Next(0,7)];
        Date = theCurrentTime.ToShortDateString();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Prompt}\n{UserResponse}\n");
    }

    public void GivePrompt()
    {
        Console.WriteLine($"Prompt: {Prompt}");
    }
    public void NewEntry()
    {
        GivePrompt();
        UserResponse = Console.ReadLine();
        // Console.WriteLine(UserResponse);
    }


    
}

