using System.IO;
using System.Collections.Generic;

public class Journal
{
    // Declare the member variables of the Journal Class
    public List<Entry> _entries = new List<Entry>();

    // This method adds a new Entry in the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    // This method display every entry in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the journal yet!");
        }
        else
        {
            Console.WriteLine("\n===== Journal Entries =====");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

    }

    // This method saves the entries of the user to a file
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._location}|{entry._mood}");
                }
            }
            Console.WriteLine($"Journal saved to \"{file}\" successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to the file \"{file}\". {ex.Message}");
        }
    }

    // This method loads the saved entries of the user from a file
    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    string location = parts[3];
                    string mood = parts[4];
                    Entry loadedEntry = new Entry(date, promptText, entryText, location, mood);
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal loaded from \"{file}\" successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file \"{file}\". {ex.Message}.");
            Console.WriteLine("Check the filename again to make sure it's well-written. The file you requested doesn't exist.");
        }
    }
}