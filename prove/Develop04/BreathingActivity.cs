public class BreathingActivity : Activity
{
    public BreathingActivity(string nameActivity) : base(nameActivity)
    {
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DisplayBreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayShortTimer();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("Breath in...4");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.WriteLine("");

            Thread.Sleep(500);
            Console.Write("Now breath out...4");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("1");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }

        Console.WriteLine("Do you want to go for a little longer? (Y/N)");
        string userResponse = Console.ReadLine();

        if(userResponse == "Y")
        {
            TotalDuration += 15;
            Duration = 15;
            DisplayBreathingActivity();
        }
        else
        {
            return;
        }
    }
}