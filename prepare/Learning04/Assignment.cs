public class Assignment
{
    // The member variables of the Assignment class
    private string  _studentName;
    private string _topic;

    // The constructor of the class
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Below are the getters or accessors for this class' attributes
    // This method helps get and return the student's name
    public string GetStudentName()
    {
        return _studentName;
    }

    // This method helps get and return the topic of the assignment 
    public string GetTopic()
    {
        return _topic;
    }

    // This method returns the student's name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}