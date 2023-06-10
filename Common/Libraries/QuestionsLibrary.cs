using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Common.Libraries;

public abstract class QuestionsLibrary
{
    public static List<Question> ThemeSelectionQuestions(int themeId)
    {
        if (themeId > ThemeLibrary.SelectionAllTheme().Count || themeId < 0)
            throw new Exception("Index theme is not valid!");

        var dictionaryQuestions = new Dictionary<int, List<Question>>
        {
            { 1, FirstThemeQuestions(themeId) },
            { 2, SecondThemeQuestions(themeId) },
            { 3, ThreeThemeQuestions(themeId) }
        };

        return dictionaryQuestions[themeId + 1];
    }

    private static List<Question> FirstThemeQuestions(int themeId) =>
        new()
        {
            new Question(
                "1) Розташуйте, будь ласка, торти від найсмачнішого до менш улюбленого.", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 1)),
            new Question(
                "2) Визначте, будь ласка, які смаколики Ви взяли би до кави найщасливішого Вашого ранку від найбільш віргідного варіанту до найменш.", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 2)),
            new Question(
                "3) Проранжуйте, будь ласка,  шоколад у порядку зменшення Вашої любові до його смаку:", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 3)),
            new Question(
                "4) Розташуйте, будь ласка, в порядку зменшення вашої симпатії пироги з яким смаком Ви би хотіли з’їсти з сім’єю ввечері за чаєм та приємно розмовою.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 4)),
            new Question(
                "5) Визначте, будь ласка, який десерт Ви би хотіли навчитися готувати вдома від найбільш бажаного варіанту до найменш.", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 5)),
            new Question(
                "6) Розташуйте, будь ласка, в порядку зменшення Вашої симпатії смаколики різних країн світу.", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 6)),
            new Question(
                "7) Вкажіть, будь ласка, у порядку зменшення вірогідності десерти, які Ви подарували би незнайомій людині.", 
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 7)),
        };

    private static List<Question> SecondThemeQuestions(int themeId) =>
        new()
        {
            new Question(
                "1) Визначте, будь ласка, зі зменшенням вірогідності, види кави, які би підняли Вам настрій у поганий день.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 1)),
            new Question(
                "2) Вкажіть, будь ласка, каву, яку би випили з найкращим другом за розмовою, від найбільш вірогідного варіанту до найменш можливого.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 2)),
            new Question(
                "3) Розташуйте, будь ласка, прохолодні кавові напої в порядку зменшення Вашої симпатії до них.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 3)),
            new Question(
                "4) Визначте, будь ласка, додатки до кави від найбільш улюбленого до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 4)),
            new Question(
                "5) Вкажіть, будь ласка, каву, яку би хотіли скуштувати, від найбільш бажаного варіанту до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 5)),
            new Question(
                "6) Розташуйте, будь ласка, способи заварювання кави в порядку зменшення Вашого вподобання.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 6)),
            new Question(
                "7) Визначте, будь-ласка, на якому альтернативному молоці Ви хотіли би спробувати капучіно від найбільш бажаного варіанту до найменш вірогідного.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 7)),
        };

    private static List<Question> ThreeThemeQuestions(int themeId) =>
        new()
        {
            new Question(
                "1) Розташуйте, будь ласка, види відпочину від найбільш улюбленого до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 1)),
            new Question(
                "2) Визначте, будь ласка, види відпочинку, який би Ви хотіли провести зі сім’єю, від найбільш бажаного до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 2)),
            new Question(
                "3) Вкажіть, будь ласка, види відпочинку, характерні Вашій мамі, від найбільш звичного до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 3)),
            new Question(
                "4) Визначте, будь ласка, види відпочинку, який би хотіли спробувати з друзями від найбільш бажаного до найменш. ",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 4)),
            new Question(
                "5) Визначте, будь ласка, відпочинок який Ви не любите в порядку зменшення негативних емоцій.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 5)),
            new Question(
                "6) Визначте, будь ласка, незвичні види відпочинку, які би хотіли спробувати.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 6)),
            new Question(
                "7) Розташуйте, будь ласка, події або процедури, які допомагають розслабитися, від найбільш улюбленої до найменш.",
                AnswersLibrary.SelectionAnswersToQuestions(themeId, 7)),
        };
}