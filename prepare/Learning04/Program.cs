using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Billy Smith", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Margaret Johnson", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}