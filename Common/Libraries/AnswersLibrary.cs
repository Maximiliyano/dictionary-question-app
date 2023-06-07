namespace DictionaryQuestionApp.Common.Libraries;

public abstract class AnswersLibrary
{
    private const string AnswerStringFormat = "1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}";

    public static string SelectionAnswersToQuestions(int questionIndex)
    {
        var dictionaryAnswers = new Dictionary<int, List<string>> { 
            { 1, FirstQuestionAnswers() }, 
            { 2, SecondQuestionAnswers() },
            { 3, ThirdQuestionAnswers() },
            { 4, FourQuestionAnswers() },
            { 5, FiveQuestionAnswers() }, 
            { 6, SixQuestionAnswers() }, 
            { 7, SevenQuestionAnswers() }
        };

        var answersList = dictionaryAnswers[questionIndex];

        Shuffle(answersList);

        return string.Format(AnswerStringFormat,
            answersList[0],
            answersList[1],
            answersList[2],
            answersList[3],
            answersList[4]);
    }

    private static void Shuffle<T>(IList<T> list)
    {
        var random = new Random();
        var n = list.Count;

        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }

    private static List<string> FirstQuestionAnswers() =>
        new()
        {
            "Answers 1",
            "An1swers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> SecondQuestionAnswers() =>
        new()
        {
            "An2swers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> ThirdQuestionAnswers() =>
        new()
        {
            "An3swers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> FourQuestionAnswers() =>
        new()
        {
            "A4nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> FiveQuestionAnswers() =>
        new()
        {
            "A5nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> SixQuestionAnswers() =>
        new()
        {
            "A6nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };

    private static List<string> SevenQuestionAnswers() =>
        new()
        {
            "A7nswers 1",
            "Answers 2",
            "Answers 3",
            "Answers 4",
            "Answers 5"
        };
}