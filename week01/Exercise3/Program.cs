using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);
        string response;
        do
        {
            Console.WriteLine("What is your guess? ");
            string GuessInput = Console.ReadLine();
            int GuessNumber = int.Parse(GuessInput);

            if (GuessNumber < MagicNumber)
            {
                Console.WriteLine($"Higher");
                response = "no";
            }
            else if (GuessNumber > MagicNumber)
            {
                Console.WriteLine($"Lower");
                response = "no";
            }
            else
            {
                Console.WriteLine($"You guessed it!");
                response = "yes";
            }
                
            } while (response == "no");

    }
}