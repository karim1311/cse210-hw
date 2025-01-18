using System.IO;
using System.Collections.Generic;

public class Journal
{
    // We create an empty list called _entries with the characteristics of the Entry class
    // Make sure to initialize your list to a new List before you use it
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
        Console.WriteLine("Entry added succesfully.");
    }

    public void DisplayAll()
    {
        Console.WriteLine("Displaying every entry...");
        //Display every entry
        // Notice the use of the custom data type "Entry" in this loop
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} - {entry._entryText}");
            }
        }


    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading list from file...");
        // Make sure to initialize your list to a new List before you use it
        // List<Entry> _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string [] parts = line.Split("-");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);

        }


    }
}