public class ListingActivity : Activity
{
    // This is the class' attributes
    private int _count;
    private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    // This is the constructor of the class
    public ListingActivity()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name = "Listing Activity";
    }

    public void Run()
    {
        
        DisplayStartingMessage();
        ShowSpinner(3);
        GetRandomPrompt();

        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"\nYou listed {_count} items");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        Console.WriteLine("\nEnter your list items (type 'done' to finish):");
        Console.Write("> ");
        string input = Console.ReadLine();
        listFromUser.Add(input);

        while (input.ToLower() != "done")
        {
            Console.Write("> ");
            listFromUser.Add(input);
            input = Console.ReadLine();
        }
        return listFromUser;
    }

}