public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        " -- Think of a time when you stood up for someone else. -- ",
        " -- Think of a time when you did something really difficult. -- ",
        " -- Think of a time when you helped somone in need. -- ",
        " -- Think of a time when you did something truly selfless. -- "
    };
    private List<string> _reflectQuestions = new List<string>()
    {
        " > Why was this experience meaningful to you?  ",
        " > Have you ever done anything like this before?  ",
        " > How did you get started?  ",
        " > How did you feel when it was complete?  ",
        " > What made this time different than other times when you were not as successful?  ",
        " > What is your favorite thing about this experience?  ",
        " > What could you learn from this experience that applies to other situations?  ",
        " > What did you learn about yourself through this experience?  ",
        " > How can you keep this experience in your mind in the future?  "
    };
        
    public ReflectionActivity(string nameActivity) : base(nameActivity)
    {
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DisplayReflectionActivity()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        DateTime currentTime = DateTime.Now;
        
        Random rnd = new Random();
        int rndNum = rnd.Next(0,4);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n{_prompts[rndNum]}\n");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        string userResponse = Console.ReadLine();
        if(userResponse.Length > 0)
        {
            System.Environment.Exit(1);
        }

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. \n");
        // DisplayTimer();
        // Console.WriteLine();

        while(currentTime < futureTime)
        {
            // Console.WriteLine($"{currentTime}, {futureTime}");
            Console.WriteLine(_reflectQuestions[rndNum]);
            if(rndNum == 9)
            {
                rndNum = 0;
            }
            // Thread.Sleep(4000);
            DisplayTimer();
            rndNum++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
    }
}