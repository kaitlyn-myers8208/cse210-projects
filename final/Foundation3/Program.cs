using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1164 Morning Glory Circle", "Westport", "CT", "06064");
        Address address2 = new Address("525 S 1st W", "Rexburg", "ID", "83460");
        Address address3 = new Address("1245 E 9400 S", "Sandy", "UT", "84094");

        Lecture lecture = new Lecture("Moral Reasoning", "This is a lecture on human moral reasoning", "April 12, 2024", "2pm", address1, "Michael Sandel", 100);
        Console.WriteLine(lecture.DisplayStandardDetails());
        Console.WriteLine(lecture.DisplayExtraDetails());
        Console.WriteLine(lecture.DisplayShortDescription());
        Console.WriteLine();

        Reception reception = new Reception("Inaguration of President Meredith", "Come celebrate the inaguration of President Meredith", "October 10, 2023", "11:30am", address2);
        Console.WriteLine(reception.DisplayStandardDetails());
        Console.WriteLine(reception.DisplayRSVPEmail());
        Console.WriteLine(reception.DisplayShortDescription());
        Console.WriteLine();

        OutdoorGathering outdoorGathering = new OutdoorGathering("Ben Rector Concert", "Ben Rector's \"Old Friends\" tour", "October 5, 2023", "8pm", address3, "clear");
        Console.WriteLine(outdoorGathering.DisplayStandardDetails());
        Console.WriteLine(outdoorGathering.DisplayExtraDetails());
        Console.WriteLine(outdoorGathering.DisplayShortDescription());
        Console.WriteLine();
    }
}