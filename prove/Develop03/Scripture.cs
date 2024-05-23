// Class representing a scripture passage
public class Scripture
{
    // This is the member variables of the Scripture class
    private Reference _reference;
    private List<Word> _words;

    // This is the constructor with two parameters of the Scripture class
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // This method hides random words from the selected scripture
    public void HideRandomWords(int numberToHide)
    {
        List<Word> nonHiddenWords = _words.Where(word => !word.IsHidden()).ToList(); // Filter non-hidden words
        if (nonHiddenWords.Count < numberToHide)
        {
            // Handle case where there are less non-hidden words than desired to hide
            numberToHide = nonHiddenWords.Count;
        }

        // Implement logic to hide a random number of words from the filtered list
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = new Random().Next(nonHiddenWords.Count);
            nonHiddenWords[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayReferenceText()}  ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayWord() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}