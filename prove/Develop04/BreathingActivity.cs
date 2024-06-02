public class BreathingActivity : Activity
{

    // This is the constructor of the class
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing Activity";
    }

    public void Run()
    {
        DateTime futureTime =  GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(3);

        // Implement breathing in/out logic
        while (currentTime <= futureTime) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }

        ShowSpinner(3);
        DisplayEndingMessage();
    }
}