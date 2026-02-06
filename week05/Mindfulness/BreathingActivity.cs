using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            elapsedTime += 4;

            if (elapsedTime >= _duration)
            {
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Now breathe out...");
            ShowCountdown(6);
            elapsedTime += 6;
        }
        DisplayEndMessage();
    }
}