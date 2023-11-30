using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Console.WriteLine(running.DisplaySummary());
        Console.WriteLine();
        
        Cycling cycling = new Cycling("03 Nov 2022", 30, 6.3);
        Console.WriteLine(cycling.DisplaySummary());
        Console.WriteLine();

        Swimming swimming = new Swimming("03 Nov 2022", 30, 5);
        Console.WriteLine(swimming.DisplaySummary());
        Console.WriteLine();
    }
}