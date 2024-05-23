// Class representing the library of scriptures
public class ScriptureLibrary
{
    // This is the member variables of the ScriptureLibrary class
    private List<Scripture> _scriptures;
    private Random _random;

    // This is the constructor of the ScriptureLibrary class with no parameter
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();

        // Add scriptures to the library
        _scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        _scriptures.Add(new Scripture(new Reference("Matthew", 16, 26), "What good will it be for someone to gain the whole world, yet forfeit their soul? Or what can anyone give in exchange for their soul?"));
        _scriptures.Add(new Scripture(new Reference("Matthew", 6, 9, 13), "This, then, is how you should pray: Our Father in heaven, hallowed be your name, your kingdom come, your will be done, on earth as it is in heaven. Give us today our daily bread. Give us today our daily bread. And forgive us our debts, as we also have forgiven our debtors. And lead us not into temptation, but deliver us from the evil one."));
    }

    // This method returns a random scripture from the scriptures' library
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("Scripture library is empty.");
        }

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}