using System.Security.Cryptography.X509Certificates;

public class Activity
{
    public string NameActivity { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public int TotalDuration { get; set; }
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
        TotalDuration = Duration;

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        DisplayShortTimer();
        Console.WriteLine($"You completed a {NameActivity} for {TotalDuration} seconds");
        DisplayShortTimer();
        return;
    }
    public void DisplayShortTimer()
    {
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
        };

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
    }
    public void DisplayTimer()
    {
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        };

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }

        // POTENTIAL TIMERS
        
        // Thread.Sleep(800);
        // for(int i = 3; i > 0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     // Console.Write("\b \b");
        // }
        // Console.WriteLine();

        // for(int i = 0; i < Duration; i++)
        // {
        //     // Console.Write("*");
            
        //     // Thread.Sleep(800);
        //     // Console.Write("\b\b");
        //     // Console.Write(" *");

        //     // Thread.Sleep(800);
        //     // Console.Write("\b\b\b");
        //     // Console.Write("  *");

        //     // Thread.Sleep(800);
        //     // Console.Write("\b\b\b\b");
        //     // Console.Write("   *");

        //     // Thread.Sleep(800);
        //     // Console.Write("\b\b\b\b\b");
        //     // Console.Write("    *");

        //     // Console.Write("\b \b \b \b \b");
        //     // Console.Write("->");
            
        //     // Thread.Sleep(500);
        //     // Console.Write("\b\b\b");
        //     // Console.Write("-->");

        //     // Thread.Sleep(500);
        //     // Console.Write("\b\b\b\b");
        //     // Console.Write("--->");

        //     // // Thread.Sleep(500);
        //     // // Console.Write("\b\b\b");
        //     // // Console.Write(":)");

        //     // Console.Write("\b\b\b\b\b");
        // }

    }
    // public DateTime KeepTime()
    // {
    //     DateTime startTime = DateTime.Now;
    //     DateTime futureTime = startTime.AddSeconds(Duration);

    //     return futureTime;
    // }
}