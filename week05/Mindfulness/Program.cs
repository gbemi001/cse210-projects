// Added a session summary to display counts of each activity completed.

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.Run();
                    breathingCount++;
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    activity.Run();
                    reflectingCount++;
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.Run();
                    listingCount++;
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }
             activity.Run();
        }
        Console.Clear();
        Console.WriteLine("Session Summary:");
        Console.WriteLine($"Breathing Activities Completed: {breathingCount}");
        Console.WriteLine($"Reflecting Activities Completed: {reflectingCount}");
        Console.WriteLine($"Listing Activities Completed: {listingCount}");
        Console.WriteLine();
        Console.WriteLine("Thank you for taking time to be mindful today. Goodbye!");
    }
}