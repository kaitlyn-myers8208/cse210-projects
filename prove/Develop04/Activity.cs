using System.Security.Cryptography.X509Certificates;

public class Activity
{
    public string NameActivity { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public string DurationString { get; set; }
    // private DateTime StartTime;

    public Activity(string nameActivity)
    {
        NameActivity = nameActivity;
        Duration = 0;
    }
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {NameActivity}.\n");
        Console.WriteLine($"{Description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        DurationString = Console.ReadLine();
        Duration = int.Parse(DurationString);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Thread.Sleep(1000);
        Console.WriteLine($"You completed a {NameActivity} for {Duration} seconds");
        Thread.Sleep(2000);
        return;
    }
    public void DisplayTimer()
    {
        for(int i = 0; i < Duration; i++)
        {
            // Console.Write("*");
            
            // Thread.Sleep(800);
            // Console.Write("\b\b");
            // Console.Write(" *");

            // Thread.Sleep(800);
            // Console.Write("\b\b\b");
            // Console.Write("  *");

            // Thread.Sleep(800);
            // Console.Write("\b\b\b\b");
            // Console.Write("   *");

            // Thread.Sleep(800);
            // Console.Write("\b\b\b\b\b");
            // Console.Write("    *");

            Console.Write("\b \b \b \b \b");
            Console.Write("->");
            
            Thread.Sleep(500);
            Console.Write("\b\b\b");
            Console.Write("-->");

            Thread.Sleep(500);
            Console.Write("\b\b\b\b");
            Console.Write("--->");

            // Thread.Sleep(500);
            // Console.Write("\b\b\b");
            // Console.Write(":)");

            Console.Write("\b\b\b\b\b");
        }
    }
    // public DateTime KeepTime()
    // {
    //     DateTime startTime = DateTime.Now;
    //     DateTime futureTime = startTime.AddSeconds(Duration);

    //     return futureTime;
    // }
}