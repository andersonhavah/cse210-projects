// This is the reflecting activity class
public class ReflectingActivity : Activity
{
    // Below are the class' attributes or member variables
    private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

    // This is the constructor of the reflecting class with no parameters.
    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }

    // This is the function that runs the reflecting activity when called
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    // This function helps get a random prompt from the list of prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string randomPrompt = $"{_prompts[index]}";
        return randomPrompt;
    }

    // This function helps get a random question from the list of questionl
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string randomQuestion = $"{_questions[index]}";
        return randomQuestion;
    }

    // This function displays the prompt to the user
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Thread.Sleep(1000); // Pause for 1 seconds after each prompt
        Console.WriteLine("\nWhen you have something in your mind, press enter to continue.");
        Console.ReadKey();

    }

    // This function displays the question to the user
    public void DisplayQuestions()
    {
        int time = 0;
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        while (time < _duration * 1000 && _questions.Count != 0)
        {
            Console.Write($"\n> {GetRandomQuestion()}");
            ShowSpinner(3);
            Thread.Sleep(2000); // Pause for 3 seconds after each question
            time += 5000;
        }
        Console.WriteLine("");
    }

}
