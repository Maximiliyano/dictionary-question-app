namespace DictionaryQuestionApp.Common.Libraries;

public abstract class ThemeLibrary
{
    public static List<string> SelectionAllTheme() =>
        new()
        {
            "Theme 1",
            "Theme 2",
            "Theme 3",
            "Theme 4"
        };
}