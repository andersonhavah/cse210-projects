using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // This method generates a random prompt from the prompts' list above
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}