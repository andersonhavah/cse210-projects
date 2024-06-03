// This is the activity class which is the base class that other activities' classes inherit.

public class Activity
{
    // Declare the attributes off the Activity class
    protected string _name;
    protected string _description;
    protected int _duration;

    // This is the constructor of the class with no parameters
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 20;
    }

    // This function displays the welcome and starting message at the 
    // beginning of an activity to the user
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000); // Pause for 1 seconds
    }

    // This functions displays the ending message at the end of an activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}\n");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // This function shows the spinner
    public void ShowSpinner(int seconds)
    {
        int elapsedTime = 0;
        char[] spinnerChars = new char[] { '-', '\\', '|', '/' };
        int currentCharIndex = 0;

        while (elapsedTime < seconds * 1000) // Convert seconds to milliseconds
        {
            Console.Write(spinnerChars[currentCharIndex]);
            Thread.Sleep(500); // Adjust sleep time for desired animation speed

            Console.Write("\b \b"); // Erase previous character and space for spinner movement
            currentCharIndex = (currentCharIndex + 1) % spinnerChars.Length;
            elapsedTime += 500;
        }
    }

    // This function dislays the countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i <= seconds; i++)
        {
            Console.Write($"{seconds - i}");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }

   
}