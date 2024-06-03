// This is the breathing activity class
public class BreathingActivity : Activity
{

    // This is the constructor of the class
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing Activity";
    }

    // This function helps run the breathing activity
    public void Run()
    {

        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(3);

        // Implement breathing in/out logic
        for (int i = 0; i < _duration * 1000; i += 6000) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine("");
        }

        ShowSpinner(3);
        DisplayEndingMessage();
    }
}