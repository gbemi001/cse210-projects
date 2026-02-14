// Creativity requirement: Added a Leveling System in the GoalManager to track player progress and provide a sense of advancement. Players level up for every 1000 points earned, and their current level is displayed alongside their score. This adds an extra layer of motivation and engagement as players can see their growth as Eternal Warriors in the quest.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}