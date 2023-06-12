namespace DictionaryQuestionApp.Common.Models;

public class User
{
    public Guid Uid { get; set; }
    public IList<Question> Questions { get; set; }
}