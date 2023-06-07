namespace DictionaryQuestionApp.Common.Libraries;

public abstract class QuestionsLibrary
{
    public static List<string> ThemeSelectionQuestions(int index)
    {
        if (index > ThemeLibrary.SelectionAllTheme().Count)
            throw new Exception("Index theme is not valid!");

        var dictionaryQuestions = new Dictionary<int, List<string>>()
        {
            { 1, FirstThemeQuestions() },
            { 2, SecondThemeQuestions() },
            { 3, ThreeThemeQuestions() },
            { 4, FourThemeQuestions() }
        };

        return dictionaryQuestions[index + 1];
    }

    private static List<string> FirstThemeQuestions() =>
        new()
        {
            "Q1uestion 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
        };

    private static List<string> SecondThemeQuestions() =>
        new()
        {
            "Q2uestion 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
        };

    private static List<string> ThreeThemeQuestions() =>
        new()
        {
            "Q3uestion 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
        };

    private static List<string> FourThemeQuestions() =>
        new()
        {
            "Q4uestion 1",
            "Question 2",
            "Question 3",
            "Q4uestion 4",
            "Question 5",
            "Question 6",
            "Question 7",
        };
}