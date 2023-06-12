using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Common.Libraries;

public abstract class QuestionsLibrary
{
    public const string QuestionStringEndpointFormat = "{0}) {1}";
    
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
            BuildQuestionModel(
                1, themeId,
                "Розташуйте, будь ласка, торти від найсмачнішого до менш улюбленого."),
            BuildQuestionModel(
                2, themeId,
                "Визначте, будь ласка, які смаколики Ви взяли би до кави найщасливішого Вашого ранку від найбільш вірогідного варіанту до найменш."),
            BuildQuestionModel(
                3, themeId,
                "Проранжуйте, будь ласка,  шоколад у порядку зменшення Вашої любові до його смаку:"),
            BuildQuestionModel(
                4, themeId,
                "Розташуйте, будь ласка, в порядку зменшення вашої симпатії пироги з яким смаком Ви би хотіли з’їсти з сім’єю ввечері за чаєм та приємно розмовою."),
            BuildQuestionModel(
                5, themeId,
                "Визначте, будь ласка, який десерт Ви би хотіли навчитися готувати вдома від найбільш бажаного варіанту до найменш."),
            BuildQuestionModel(
                6, themeId,
                "Розташуйте, будь ласка, в порядку зменшення Вашої симпатії смаколики різних країн світу."),
            BuildQuestionModel(
                7, themeId,
                "Вкажіть, будь ласка, у порядку зменшення вірогідності десерти, які Ви подарували би незнайомій людині."),
        };

    private static List<Question> SecondThemeQuestions(int themeId) =>
        new()
        {
            BuildQuestionModel(
                1, themeId,
                "Визначте, будь ласка, зі зменшенням вірогідності, види кави, які би підняли Вам настрій у поганий день."),
            BuildQuestionModel(
                2, themeId,
                "Вкажіть, будь ласка, каву, яку би випили з найкращим другом за розмовою, від найбільш вірогідного варіанту до найменш можливого."),
            BuildQuestionModel(
                3, themeId,
                "Розташуйте, будь ласка, прохолодні кавові напої в порядку зменшення Вашої симпатії до них."),
            BuildQuestionModel(
                4, themeId,
                "Визначте, будь ласка, додатки до кави від найбільш улюбленого до найменш."),
            BuildQuestionModel(
                5, themeId,
                "Вкажіть, будь ласка, каву, яку би хотіли скуштувати, від найбільш бажаного варіанту до найменш."),
            BuildQuestionModel(
                6, themeId,
                "Розташуйте, будь ласка, способи заварювання кави в порядку зменшення Вашого вподобання."),
            BuildQuestionModel(
                7, themeId,
                "Визначте, будь-ласка, на якому альтернативному молоці Ви хотіли би спробувати капучіно від найбільш бажаного варіанту до найменш вірогідного."),
        };

    private static List<Question> ThreeThemeQuestions(int themeId) =>
        new()
        {
            BuildQuestionModel(
                1, themeId,
                "Розташуйте, будь ласка, види відпочину від найбільш улюбленого до найменш."),
            BuildQuestionModel(
                2, themeId,
                "Визначте, будь ласка, види відпочинку, який би Ви хотіли провести зі сім’єю, від найбільш бажаного до найменш."),
            BuildQuestionModel(
                3, themeId,
                "Вкажіть, будь ласка, види відпочинку, характерні Вашій мамі, від найбільш звичного до найменш."),
            BuildQuestionModel(
                4, themeId,
                "Визначте, будь ласка, види відпочинку, який би хотіли спробувати з друзями від найбільш бажаного до найменш. "),
            BuildQuestionModel(
                5, themeId,
                "Визначте, будь ласка, відпочинок який Ви не любите в порядку зменшення негативних емоцій."),
            BuildQuestionModel(
                6, themeId,
                "Визначте, будь ласка, незвичні види відпочинку, які би хотіли спробувати."),
            BuildQuestionModel(
                7, themeId,
                "Розташуйте, будь ласка, події або процедури, які допомагають розслабитися, від найбільш улюбленої до найменш."),
        };

    private static Question BuildQuestionModel(int questionId, int themeId, string description) =>
        new()
        {
            Id = questionId,
            Description = description,
            Answers = AnswersLibrary.SelectionAnswersToQuestions(themeId, questionId)
        };
}