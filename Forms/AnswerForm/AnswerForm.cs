using MathNet.Numerics.Statistics;
using DictionaryQuestionApp.Common.Libraries;
using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms.AnswerForm;

public partial class AnswerForm : Form
{
    public IList<Question> Questions { get; set; }

    private readonly IList<User> _usersBlanks;

    private readonly IList<Question> _generalQuestions;

    private static IList<double> _totalCorrelation;
    private static IEnumerable<double> _user1Mediana;
    private static IEnumerable<double> _user2Mediana;

    public AnswerForm()
    {
        _usersBlanks = new List<User>();
        _generalQuestions = new List<Question>();

        _totalCorrelation = new List<double>();
        Questions = new List<Question>();

        InitializeComponent();
    }

    private void Answers_Load(object sender, EventArgs e)
    {
        for (var i = 0; i < Questions.Count; i++)
        {
            var questionLabel = GetQuestionLabel(i);
            var answersLabelUser1 = GetAnswersLabelUser1(i);
            var answersLabelUser2 = GetAnswersLabelUser2(i);

            if (questionLabel != null)
                questionLabel.Text = string.Format(QuestionsLibrary.QuestionStringEndpointFormat, i + 1, Questions[i].Description);

            if (answersLabelUser1 != null)
                answersLabelUser1.Text = ConvertToString(Questions[i].Id);

            if (answersLabelUser2 != null)
                answersLabelUser2.Text = ConvertToString(Questions[i].Id);
        }
    }

    private Label? GetQuestionLabel(int index)
    {
        return index switch
        {
            0 => label2,
            1 => label5,
            2 => label7,
            3 => label9,
            4 => label21,
            _ => null
        };
    }

    private Label? GetAnswersLabelUser1(int index)
    {
        return index switch
        {
            0 => label10,
            1 => label11,
            2 => label12,
            3 => label13,
            4 => label14,
            _ => null
        };
    }

    private Label? GetAnswersLabelUser2(int index)
    {
        return index switch
        {
            0 => label23,
            1 => label18,
            2 => label17,
            3 => label16,
            4 => label15,
            _ => null
        };
    }

    private string ConvertToString(int questionId)
    {
        var str = string.Empty;

        foreach (var question in Questions.Where(x => x.Id == questionId))
        {
            RandomMix(question.Answers);
            _generalQuestions.Add(question);
            for (var i = 0; i < question.Answers.Count; i++)
            {
                str += $"{i + 1}. {question.Answers[i].Description}\n";
            }
        }

        return str;
    }

    private static void RandomMix(IList<Answer> items)
    {
        var random = new Random();
        var n = items.Count;

        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            (items[n], items[k]) = (items[k], items[n]);
        }
    }

    private void analysisButton_Click(object sender, EventArgs e)
    {
        #region userSetUp

        var firstUserQuestions = _generalQuestions.Take(5).ToList();
        var secondUserQuestions = _generalQuestions.Skip(_generalQuestions.Count - 5).ToList();

        var first = BuildUserModel(firstUserQuestions);
        var second = BuildUserModel(secondUserQuestions);

        _usersBlanks.Add(first);
        _usersBlanks.Add(second);

        var generalRankings = new List<List<int>>();

        foreach (var user in _usersBlanks)
        {
            generalRankings.AddRange(
                user.Questions
                    .Select(question => 
                        question.Answers
                            .Select(answer => answer.Rank)
                            .ToList()));
        }
        
        #endregion

        var user1Rankings = generalRankings.Take(5).ToList();
        var user2Rankings = generalRankings.Skip(generalRankings.Count - 5).ToList();
        
        CalculateCorrelation(user1Rankings, user2Rankings);
        CalculateMedianScores(user1Rankings, user2Rankings);
        
        var analysisForm = new AnalysisForm.AnalysisForm();

        Hide();

        analysisForm.TotalCorrelation = _totalCorrelation;
        analysisForm.User1Mediana = _user1Mediana;
        analysisForm.User2Mediana = _user2Mediana;
        
        analysisForm.ShowDialog();
    }
    
    private static void CalculateCorrelation(IReadOnlyList<List<int>> user1Rankings, IReadOnlyList<List<int>> user2Rankings)
    {
        for (var i = 0; i < user1Rankings.Count; i++)
        {
            var user1Scores = GetColumn(user1Rankings, i);
            var user2Scores = GetColumn(user2Rankings, i);

            var correlation = Correlation.Pearson(user1Scores, user2Scores);
            correlation = Math.Max(Math.Min(correlation, 1), -1);
            var roundedCorrelation = Math.Round(correlation, 2);

            _totalCorrelation.Add(roundedCorrelation);
            MessageBox.Show($"Correlation for question {i + 1}: {roundedCorrelation}");
        }
    }

    private static void CalculateMedianScores(IReadOnlyList<List<int>> user1Rankings, IReadOnlyList<List<int>> user2Rankings)
    {
        var user1Medians = GetMedianScores(user1Rankings);
        var user2Medians = GetMedianScores(user2Rankings);

        _user1Mediana = user1Medians;
        _user2Mediana = user2Medians;
        MessageBox.Show("Median scores for User 1:\n" + string.Join("\n", user1Medians));
        MessageBox.Show("Median scores for User 2:\n" + string.Join("\n", user2Medians));
    }

    private static IEnumerable<double> GetColumn(IReadOnlyList<List<int>> array, int columnIndex)
    {
        var column = new double[array.Count];
        for (var i = 0; i < array.Count; i++)
        {
            column[i] = array[i][columnIndex];
        }
        return column;
    }

    private static IEnumerable<double> GetMedianScores(IReadOnlyList<List<int>> user)
    {
        var medians = new double[user.Count];
        for (var i = 0; i < user.Count; i++)
        {
            medians[i] = GetColumn(user, i).Median();
        }
        return medians;
    }

    private static User BuildUserModel(IList<Question> questions) =>
        new()
        {
            Uid = Guid.NewGuid(),
            Questions = questions
        };
}