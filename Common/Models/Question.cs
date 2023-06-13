namespace DictionaryQuestionApp.Common.Models;

public class Question
{
    public int Id { get; set; }
    
    public string Description { get; set; }

    public IList<Answer> Answers { get; set; }
}
