public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public Entry entryFromFileString(string fileString)
    {
        string[] parts = fileString.Split('|');
        Entry entry = new Entry();
        entry._date = parts[0];
        entry._promptText = parts[1];
        entry._entryText = parts[2];
        return entry;
    }
}