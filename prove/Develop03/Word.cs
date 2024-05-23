// Class representing a single word in the scripture
class Word
{
    // Below are the member variables of the Word class
    private string _text;
    private bool _isHidden;

    // This is the constructor of the Word class with one parameter
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // This Hide() method is called when a word is to be hidden
    public void Hide()
    {
        _isHidden = true;
    }

    // This Show() method is called when a word is to be showed
    public void Show()
    {
        _isHidden = false;
    }

    // This method returns the value of the member variable _isHidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // This method replaces and returns the selected word into "_" 
    // when the word is set to be hidden
    public string GetDisplayWord()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}