using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2032;

        // Console.WriteLine ($"{job1._company}");
        // job1.DisplayJobInfo();

        Job job2 = new Job();
        job2._jobTitle = "Ice Cream Tester";
        job2._company = "Ben and Jerry's";
        job2._startYear = 2030;
        job2._endYear = 2034;

        // Console.WriteLine ($"{job2._company}");
        // job2.DisplayJobInfo();

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine($"{resume1._jobs[0]._jobTitle}");

        resume1.DisplayResume();



    }
}