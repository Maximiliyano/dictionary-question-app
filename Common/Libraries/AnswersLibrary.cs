using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Common.Libraries;

public abstract class AnswersLibrary
{
    public static List<Answer> SelectionAnswersToQuestions(int themeId, int questionId)
    {
        themeId++;

        var dictionaryAnswers = new Dictionary<int, List<string>>
        {
            { 1, FirstQuestionAnswers(themeId) },
            { 2, SecondQuestionAnswers(themeId) },
            { 3, ThirdQuestionAnswers(themeId) },
            { 4, FourQuestionAnswers(themeId) },
            { 5, FiveQuestionAnswers(themeId) },
            { 6, SixQuestionAnswers(themeId) },
            { 7, SevenQuestionAnswers(themeId) }
        };

        var answersList = dictionaryAnswers[questionId]
            .ToList();

        return answersList.Select((t, i) => BuildAnswer(i + 1, t)).ToList();
    }

    private static List<string> FirstQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "Празький",
                "Пташине молоко",
                "Графські руїни",
                "Наполеон",
                "Захер"
            },
            2 => new()
            {
                "міцне еспресо",
                "солоденький раф",
                "флет-вайт",
                "капучіно",
                "американо"
            },
            3 => new()
            {
                "перегляд фільмів",
                "прогулянка на свіжому повітрі",
                "читання книжок",
                "активний відпочинок",
                "сон"
            },
            _ => new(),
        };

    private static List<string> SecondQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "шматочок торту",
                "цукерка",
                "печиво",
                "шматочок шоколадки",
                "бутерброд"
            },
            2 => new()
            {
                "американо з молоком",
                "лате",
                "матча-лате",
                "глясе",
                "еспресо"
            },
            3 => new()
            {
                "туристичний похід",
                "поїздка на море",
                "спільна вечеря",
                "настільні ігри",
                "спільний перегляд фільмів"
            },
            _ => new(),
        };

    private static List<string> ThirdQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "темний",
                "молочний",
                "білий",
                "молочний з подрібненими  горішками",
                "темний зі сухою вишнею"
            },
            2 => new()
            {
                "айс-лате",
                "фрапе",
                "бамбл-кава",
                "афогато",
                "еспресо-тонік"
            },
            3 => new()
            {
                "похід в театр чи на концерт",
                "вивчення іноземних мов",
                "читання книжок",
                "перегляд телебачення",
                "догляд за рослинами"
            },
            _ => new(),
        };

    private static List<string> FourQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "вишневий пиріг",
                "яблучний пиріг",
                "абрикосовий пиріг",
                "ягідний пиріг",
                "творожна запіканка"
            },
            2 => new()
            {
                "кориця",
                "цукор",
                "шоколад",
                "кардамон",
                "нічого"
            },
            3 => new()
            {
                "піднятися в гори",
                "сплавитися по річці",
                "стрибки з парашутом",
                "подорож по Європі",
                "поїздка на море",
                "туристичний похід"
            },
            _ => new(),
        };

    private static List<string> FiveQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "тірамісу",
                "чізкейк",
                "лимонне печиво",
                "торт «Медовик»",
                "мафіни"
            },
            2 => new()
            {
                "ірладська кава",
                "кава по-французьки (з коньяком та вершками)",
                "мокко (з какао)",
                "карамелачіно (зі справжньою карамеллю)",
                "кава по-туринськи"
            },
            3 => new()
            {
                "читання книжок",
                "робота на городі",
                "комп’ютерні ігри",
                "поїздки куди-небуть",
                "кулінарія"
            },
            _ => new(),
        };

    private static List<string> SixQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "еклер (Франція)",
                "печиво кантучіні (Італія)",
                "моті (Японія)",
                "налисники (Україна)",
                "чурчхела (Грузія)"
            },
            2 => new()
            {
                "еспресо-машина",
                "в турочці",
                "в гейзерній кавоварці",
                "фільтр-кава",
                "френч-прес"
            },
            3 => new()
            {
                "проживання на безлюдному острові протягом місяця",
                "мотоподорож",
                "гастрономічна подорож країнами Європи",
                "банджі-джампінг",
                "дайвінг"
            },
            _ => new(),
        };

    private static List<string> SevenQuestionAnswers(int themeId) =>
        themeId switch
        {
            1 => new()
            {
                "макарун",
                "торт «Київський»",
                "круасан з шоколадом",
                "желе «Мозаїка»",
                "десерт «Три шоколади»"
            },
            2 => new()
            {
                "мигдалеве",
                "рисове",
                "вівсяне",
                "кокосове",
                "безлактозне"
            },
            3 => new()
            {
                "масаж",
                "аромотерапія",
                "приємна музика",
                "контрастний душ",
                "зустріч з друзями"
            },
            _ => new(),
        };

    private static Answer BuildAnswer(int rank, string description) =>
        new()
        {
            Description = description,
            Rank = rank
        };

}