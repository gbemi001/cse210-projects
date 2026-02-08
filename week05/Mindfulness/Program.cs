// Added a session summary to display counts of each activity completed.

using System;

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

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    reflectingCount++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;
                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }
            
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