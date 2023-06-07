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

        var answersList = dictionaryAnswers[questionIndex];

        Shuffle(answersList);

        return string.Format(AnswerStringFormat,
            answersList[0],
            answersList[1],
            answersList[2],
            answersList[3],
            answersList[4]);
    }

    static void Shuffle<T>(List<T> list)
    {
        Random random = new Random();
        int n = list.Count;

        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
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
