namespace DictionaryQuestionApp.Common.Libraries;

public class AnswersLibrary
{
    public const string AnswerStringFormat = "1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}";

    public static string SelectionAnswersToQuestions(int questionIndex)
    {
        var dictionaryAnswers = new Dictionary<int, List<string>>() { 
            { 1, FirstQuestionAnswers() }, 
            { 2, SecondQuestionAnswers() },
            { 3, ThirdQuestionAnswers() },
            { 4, FourQuestionAnswers() },
            { 5, FiveQuestionAnswers() }, 
            { 6, SixQuestionAnswers() }, 
            { 7, SevenQuestionAnswers() }
        };

        return string.Format(AnswerStringFormat, 
            dictionaryAnswers[questionIndex][0],
            dictionaryAnswers[questionIndex][1],
            dictionaryAnswers[questionIndex][2],
            dictionaryAnswers[questionIndex][3],
            dictionaryAnswers[questionIndex][4]);
    }

    private static List<string> FirstQuestionAnswers()
    {
        return new()
        {
            "Answers 1",
            "An1swers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> SecondQuestionAnswers()
    {
        return new()
        {
            "An2swers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> ThirdQuestionAnswers()
    {
        return new()
        {
            "An3swers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> FourQuestionAnswers()
    {
        return new()
        {
            "A4nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> FiveQuestionAnswers()
    {
        return new()
        {
            "A5nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> SixQuestionAnswers()
    {
        return new()
        {
            "A6nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }

    private static List<string> SevenQuestionAnswers()
    {
        return new()
        {
            "A7nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
    }
}
