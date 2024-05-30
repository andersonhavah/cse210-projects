public class WritingAssignment : Assignment
{
    // Declaring the class' attributes
    private string _title;

    // The constructor of the class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // This method helps get the writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}