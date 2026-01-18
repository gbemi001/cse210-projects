// Implemented input validation and confirm overwrite in saving file names

using System.IO; 
using System.Collections.Generic;
using System;

public class Journal
{
    public List<Entry> _entries;

public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine("Adding entry to journal.");
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        while (true)
        {
            Console.Write("Saving journal to file... Enter a file name: ");
            file = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(file))
            {
                Console.WriteLine("Filename cannot be empty.");
                continue;
            }

            // Confirm overwrite if file exists
            if (File.Exists(file))
            {
                Console.Write("File already exists. Overwrite? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    Console.WriteLine("Save cancelled.");
                    return;
                }
            }

            break;
        }

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {file} successfully.");
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading journal from file... Enter a file name: ");
        file = Console.ReadLine();
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            entry = entry.entryFromFileString(line);
            _entries.Add(entry);
        }
        Console.WriteLine($"Journal loaded from {file} successfully.");
    }
}