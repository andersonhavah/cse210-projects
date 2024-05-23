// Class representing a scripture reference
public class Reference
{
    // This is the member variables for the Reference class
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // This is the constructor with three parameters of the Reference class
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // This is the constructor with four parameters of the Reference class
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // This method displays the reference text
    public string GetDisplayReferenceText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}