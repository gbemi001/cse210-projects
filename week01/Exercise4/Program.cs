using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int UserNumber;
        do
        {
            Console.WriteLine("Enter number: ");
            string UserInput = Console.ReadLine();
            UserNumber = int.Parse(UserInput);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            } 
        } while (UserNumber != 0);

        int sum = numbers.Sum();
        float average = (float)sum / numbers.Count;
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}