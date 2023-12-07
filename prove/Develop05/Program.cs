using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Goal> Goals = new List<Goal>();
                // ? Would this be in main or in a class? Why?

        Console.WriteLine("You have 0 points.\n");

        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInt = Console.ReadLine();
        int userResponse = int.Parse(userInt);

        SimpleGoal goal = new SimpleGoal();
        
        while (userResponse != 6)
        {
            if (userResponse == 1)
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n ");
                Console.Write("Which type of goal would you like to create? ");
                string goalInt = Console.ReadLine();
                int goalType = int.Parse(goalInt);

                // Ask for the information then put that in 
                // the if statements for the constructor to make them

                if (goalType == 1)
                {
                    
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal(simpleGoal);
                    Goals.Add(simpleGoal);
                    // simpleGoal.Goals.Add(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal(eternalGoal);
                    Goals.Add(eternalGoal);
                    // eternalGoal.Goals.Add(eternalGoal);
                }
                else if (goalType == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal(checklistGoal);
                    Goals.Add(checklistGoal);
                    // checklistGoal.Goals.Add(checklistGoal);
                }
            }
            else if (userResponse == 2)
            {
                // make a list of Goals
                // add each goal to list
                // print out list with completed or not
                Console.WriteLine("Listing goals: ");
                goal.ListGoals(Goals);
                        // ? If I'm having to create a blank object to use the
                        // method inside a class, should that be a method inside
                        // the class?

                        // ? Is the only way to access anything from a class is
                        // to have an object made from that class and use that to
                        // call the methods?

            }
            else if (userResponse == 3)
            {
                // SaveGoal();
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Saving file...");

                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    outputFile.WriteLine(goal.TotalPoints);
                    foreach (Goal g in Goals) // added
                    {
                        outputFile.WriteLine($"SimpleGoal:{g.Name}|{g.Description}|{g.NumPoints}|{g.IsComplete}");
                    }
                }
                Console.WriteLine("File saved.");
            }
            else if (userResponse == 4)
            {
                // LoadGoal()
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Loading file...");

                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);            
                }

                // fix loading formatting
            }
            else if (userResponse == 5)
            {

            }
            else
            {
                Console.WriteLine("That's not a valid response. Please try again");
            }

            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
        
            userInt = Console.ReadLine();
            userResponse = int.Parse(userInt);
        }
    }
}