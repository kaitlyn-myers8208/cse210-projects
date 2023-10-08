using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.Company = "Microsoft";
        job1.StartYear = 2024;
        job1.EndYear = 2032;

        //Job job1 = new Job
        //{
        //  JobTitle = "Software Engineer",
        //  Compnay = "Microsoft",
        //}


        // Console.WriteLine ($"{job1.Company}");
        // job1.DisplayJobInfo();

        Job job2 = new Job();
        job2.JobTitle = "Ice Cream Tester";
        job2.Company = "Ben and Jerry's";
        job2.StartYear = 2030;
        job2.EndYear = 2034;

        // Console.WriteLine ($"{job2.Company}");
        // job2.DisplayJobInfo();

        Resume resume1 = new Resume();
        resume1.Name = "Allison Rose";
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);

        // Console.WriteLine($"{resume1._jobs[0].JobTitle}");

        resume1.DisplayResume();



    }
}