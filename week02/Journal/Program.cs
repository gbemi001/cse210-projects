// Simple journal entry input (no empty entries) validation added

using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        int UserChoice = 0;
        while (UserChoice != 5)
        {
            UserChoice = DisplayWelcomeMessage();

            if (UserChoice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.WriteLine("Please write your journal entry below:");
                string entryText = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(entryText))
                {
                    Console.Write("Entry cannot be empty. Please write something: ");
                    entryText = Console.ReadLine();
                }

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = prompt;
                entry._entryText = entryText;
                journal.AddEntry(entry);
            }

            else if (UserChoice == 2)
            {
                journal.DisplayAll();
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
            }

            else if (UserChoice == 3)
            {
                journal.LoadFromFile("");
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
            }

            else if (UserChoice == 4)
            {
                journal.SaveToFile("");
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
            }

            else if (UserChoice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        }

    }

    static int DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int UserNumber = int.Parse(Console.ReadLine());
            return UserNumber;

        }
}