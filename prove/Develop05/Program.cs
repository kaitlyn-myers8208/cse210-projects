using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Goal> Goals = new List<Goal>();
        SimpleGoal goal = new SimpleGoal();
        int totalPoints = 0;

        Console.WriteLine($"You have {totalPoints} points.\n");

        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInt = Console.ReadLine();
        int userResponse = int.Parse(userInt);
        
        while (userResponse != 6)
        {
            if (userResponse == 1)
            {
                // CreateGoal()
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n ");
                Console.Write("Which type of goal would you like to create? ");
                string goalInt = Console.ReadLine();
                int goalType = int.Parse(goalInt);

                if (goalType == 1)
                {
                    
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal(simpleGoal);
                    Goals.Add(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal(eternalGoal);
                    Goals.Add(eternalGoal);
                }
                else if (goalType == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal(checklistGoal);
                    Goals.Add(checklistGoal);
                }
            }
            else if (userResponse == 2)
            {
                // ListGoals()
                if (Goals.Count() == 0)
                {
                    Console.WriteLine("You don't have any goals yet");
                }
                else
                {
                    Console.WriteLine("Listing goals: ");
                    int i = 1;

                    foreach (Goal g in Goals)
                    {
                        g.ListGoals(g, i);
                        i++;
                    }
                }
                        // ? If I'm having to create a blank object to use the
                        // method inside a class, should that be a method inside
                        // the class ?

            }
            else if (userResponse == 3)
            {
                // SaveGoal()
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Saving file...");

                using (StreamWriter outputFile = new StreamWriter(fileName, false))
                {
                    outputFile.WriteLine(totalPoints);
                    foreach (Goal g in Goals)
                    {
                        outputFile.WriteLine(g.SaveGoal());
                    }
                }
                Console.WriteLine("File saved.");
            }
            else if (userResponse == 4)
            {
                // LoadGoal()
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Loading file...");

                string[] lines = System.IO.File.ReadAllLines(fileName);
                string totalPointsString = lines[0];
                totalPoints = int.Parse(totalPointsString);
                foreach (string line in lines)
                {
                    if (line == lines[0])
                    {
                        continue;
                    }
                    string[] parts = line.Split(":");
                    string goalType = parts[0];
                    string details = parts[1];

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.RecreateGoal(simpleGoal, details);
                        Goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.RecreateGoal(eternalGoal, details);
                        Goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.RecreateGoal(checklistGoal, details);
                        Goals.Add(checklistGoal);
                    }         
                }
            }
            else if (userResponse == 5)
            {
                // RecordGoal()
                int i = 1;
                Console.WriteLine($"The goals are: ");
                foreach (Goal g in Goals)
                {
                    Console.WriteLine($"{i}. {g.Name}");
                    i++;
                }
                Console.Write("Which goal did you accomplish? ");
                string userString = Console.ReadLine();
                int selectedGoal = int.Parse(userString) - 1;

                Goals[selectedGoal].RecordGoal();
                totalPoints += Goals[selectedGoal].DisplayPoints();                
            }
            else
            {
                Console.WriteLine("That's not a valid response. Please try again");
            }

            Console.WriteLine($"\nYou have {totalPoints} points");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
        
            userInt = Console.ReadLine();
            userResponse = int.Parse(userInt);
        }
    }
}