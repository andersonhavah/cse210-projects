public class MathAssignment : Assignment
{
    // Declaring the attributes of the class
    private string _textbookSection;
    private string _problems;

    // The constructor of the class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // This method returns homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}