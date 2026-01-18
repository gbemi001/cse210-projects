using System;
using System.Collections.Generic;   
public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>()
        {
            "What made you smile today?",
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What is a goal you have for tomorrow?",
            "Describe a challenge you faced today and how you overcame it.",
            "What is something new you learned today?",
            "Write about a person who had a positive impact on your day.",
            "If you had one thing you could do over today, what would it be?",
            "What was the strongest emotion you felt today?",
            "Describe a place you visited today and what made it special."
        };
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(prompts.Count);
        return prompts[index];
    }
}