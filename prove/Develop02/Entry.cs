public class Entry
{
    // Declare the member variables of the Entry class 
    public string _date;
    public string _entryText;
    public string _promptText;
    public string _location;
    public string _mood;

    // Create an Entry constructor for the Entry class
    public Entry(string date, string promptText, string entryText, string location, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _location = location;
        _mood = mood;
    }

    // This method displays to the user what they typed as a reponse to the question including
    // the prompt, date, location, and mood during their entry.
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Location: {_location} - Mood: {_mood}");
        Console.WriteLine($"Your Response: {_entryText}");
        Console.WriteLine("-----------------------------");
    }

}