namespace DictionaryQuestionApp.Common.Models;

public class Question
{
    public Question(string description, IList<string> answers)
    {
        Description = description;
        Answers = answers;
    }

    public Question() { }

    public int Id { get; set; }
    
    public string Description { get; set; }

    public IList<string> Answers { get; set; }
}
