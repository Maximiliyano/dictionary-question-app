using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms;

public partial class AnswerForm : Form
{
    public IList<Question> Questions { get; set; }

    public AnswerForm()
    {
        Questions = new List<Question>();

        InitializeComponent();
    }

    private void Answers_Load(object sender, EventArgs e)
    {
        for (var i = 0; i < Questions.Count; i++)
        {
            var questionLabel = GetQuestionLabel(i);
            var idLabel = GetIdLabel(i);

            if (questionLabel != null)
                questionLabel.Text = Questions[i].Description;

            if (idLabel != null)
                idLabel.Text = ConvertToString(Questions[i].Id);
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

    private Label? GetIdLabel(int index)
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

    private string ConvertToString(int questionId)
    {
        var str = string.Empty;

        foreach (var question in Questions.Where(x => x.Id == questionId))
        {
            for (var i = 0; i < question.Answers.Count; i++)
            {
                str += $"{i + 1}. {question.Answers[i].Description}\n";
            }
        }
        return str;
    }

    private void analysisButton_Click(object sender, EventArgs e)
    {
        var values = new List<double>();

        for (int i = 0; i < Questions.Count; i++)
        {
            foreach (var ranking in Questions[i].Answers)
            {
                values.Add(ranking.Rank);
            }

            var kemenyMedian = CalculateKemenyMedian(values);
            var spearmanCorrelation = CalculateSpearmanCorrelation(values);

            var result = $"Коефіцієнт рангової кореляції Спірмена: {spearmanCorrelation}\n" +
                            $"Медіана Кемені: {kemenyMedian}";

            MessageBox.Show(result, $"Результати аналізу питання: {Questions[i].Id}");
        }
    }

    private double CalculateKemenyMedian(List<double> values)
    {
        values.Sort();

        int n = values.Count;
        double median;
        if (n % 2 == 0)
        {
            median = (values[n / 2 - 1] + values[n / 2]) / 2;
        }
        else
        {
            median = values[n / 2];
        }

        return median;
    }

    private double CalculateSpearmanCorrelation(List<double> values)
    {
        int n = values.Count;

        List<double> ranks = values.Select((x, i) => new KeyValuePair<double, int>(x, i))
            .OrderBy(x => x.Key)
            .Select((x, i) => new KeyValuePair<int, int>(x.Value, i + 1))
            .OrderBy(x => x.Key)
            .Select(x => (double)x.Value)
            .ToList();

        double sumOfSquaredDifferences = values.Select((x, i) => Math.Pow(x - ranks[i], 2)).Sum();
        double spearmanCorrelation = 1 - (6 * sumOfSquaredDifferences) / (n * (n * n - 1));

        return spearmanCorrelation;
    }

}