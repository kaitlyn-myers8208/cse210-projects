public class ListingActivity : Activity
{
    public string _userResponse { get; set; }
    private List<string> _prompts = new List<string>()
    {
        " -- Who are people that you appreciate? -- ",
        " -- What are personal strengths of yours? -- ",
        " -- Who are people that you have helped this week? -- ",
        " -- When have you felt the Holy Ghost this month? -- ",
        " -- Who are some of your personal heros? -- "
    };
    private List<string> _listingResponses = new List<string>();
    public ListingActivity(string nameActivity) : base(nameActivity)
    {
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DisplayListingActivity()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        DateTime currentTime = DateTime.Now;
        
        Random rnd = new Random();
        int rndNum = rnd.Next(0,4);

        Console.WriteLine("Get ready...");
        DisplayShortTimer();
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"\n{_prompts[rndNum]}\n");
        Console.WriteLine("You may begin in: ");

        while(currentTime < futureTime)
        {
            Console.Write(" > ");
            _listingResponses.Add(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine($"You listed {_listingResponses.Count} items!\n");

        // give countdown
        // prompt to keep listing items
        // list for duration
        // displays number of items entered


        Console.Write("When you have something in mind, press enter to continue. ");
        string userResponse = Console.ReadLine();
        if(userResponse.Length > 0)
        {
            System.Environment.Exit(1);
        }
    }

}