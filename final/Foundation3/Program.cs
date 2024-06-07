// This is the event planning program

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 St James Street", "Sacramento", "California", 25634, "USA");
        Address address2 = new Address("456 Sherley Road", "Springfield", "Illinois",  96843, "USA");
        Address address3 = new Address("789 Oak Street", "Atlanta", "Georgia", 85931, "USA");

        // Create the events
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2024-07-15", "10:00 AM", address1, "Jameson Roberts", 100);
        Reception reception = new Reception("Networking Event", "An event to network with industry professionals", "2024-07-20", "6:00 PM", address2, "johnsamuel@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic", "2024-08-01", "1:00 PM", address3, "Sunny with a chance of rain");

        // Print each event details
        PrintLectureDetails(lecture);
        PrintReceptionDetails(reception);
        PrintOutdoorGatheringDetails(outdoorGathering);
    }

    // This method prints the lecture event details
    public static void PrintLectureDetails(Lecture lecture)
    {
        Console.WriteLine("--------------------- Lecture Event ----------------------");
        Console.WriteLine($"{lecture.GetStandardDetails()}");
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine();

    }

    // This method prints the reception event details
    public static void PrintReceptionDetails(Reception reception)
    {
        Console.WriteLine("-------------------- Reception Event --------------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine();
    }

    // This method prints the outdoor gathering event details
    public static void PrintOutdoorGatheringDetails(OutdoorGathering outdoorGathering)
    {
        Console.WriteLine("----------------- Outdoor Gathering Event ------------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine();
    }
}