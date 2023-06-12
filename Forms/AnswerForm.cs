using DictionaryQuestionApp.Common.Libraries;
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
                questionLabel.Text = string.Format(QuestionsLibrary.QuestionStringEndpointFormat, i+1, Questions[i].Description);

            if (idLabel != null)
                idLabel.Text = ConvertToString(Questions[i].Id);
        }
    }

    private Label? GetQuestionLabel(int index) // TODO make desigh
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

    private void analysisButton_Click(object sender, EventArgs e) // TODO methods and list with list rank answers
    {
        double totalKemeny = 0, totalSpearman = 0;

        var values = new List<List<int>>();
        var result = string.Empty;

        for (int i = 0; i < Questions.Count; i++)
        {
            foreach (var ranking in Questions[i].Answers)
            {
                values.Add(new List<int> { ranking.Rank });
            }

            /*
            var kemenyMedian = CalculateKemenyMedian(values);
            var spearmanCorrelation = CalculateSpearmanCorrelation(values);

            totalKemeny += kemenyMedian;
            totalSpearman += spearmanCorrelation;

            result += $"Питання {Questions[i].Id}\n" +
                      $"Коефіцієнт рангової кореляції Спірмена: {spearmanCorrelation}\n" +
                      $"Медіана Кемені: {kemenyMedian}\n"; 
            */
        }

        result +=
            $"Total kemeny: {totalKemeny}\n" +
            $"Total spearman: {totalSpearman}";
        MessageBox.Show(result, "Результати аналізу питань: ");

        var analysisForm = new AnalysisForm();

        Hide();

        analysisForm.ShowDialog();
    }

    private List<int> CalculateKemenyMedian(List<List<int>> rankings)
    {
        int itemCount = rankings[0].Count;
        List<int> kemenyMedian = new List<int>();

        // Initialize the Kemeny median with the first ranking
        for (int i = 1; i <= itemCount; i++)
        {
            kemenyMedian.Add(i);
        }

        int minKendallTauDistance = int.MaxValue;

        // Calculate Kendall tau distance for each permutation of rankings
        foreach (var permutation in GetPermutations(itemCount))
        {
            int kendallTauDistance = 0;

            // Calculate Kendall tau distance for each pair of rankings
            foreach (var ranking in rankings)
            {
                kendallTauDistance += CalculateKendallTauDistance(ranking, permutation);
            }

            // Update the Kemeny median if the Kendall tau distance is smaller
            if (kendallTauDistance < minKendallTauDistance)
            {
                minKendallTauDistance = kendallTauDistance;
                kemenyMedian = new List<int>(permutation);
            }
        }

        return kemenyMedian;
    }
    
    private int CalculateKendallTauDistance(List<int> ranking1, List<int> ranking2)
    {
        int concordantPairs = 0;
        int discordantPairs = 0;

        for (int i = 0; i < ranking1.Count - 1; i++)
        {
            for (int j = i + 1; j < ranking1.Count; j++)
            {
                int comparison = ranking1[i].CompareTo(ranking1[j]);

                if (comparison != 0)
                {
                    int comparison2 = ranking2[i].CompareTo(ranking2[j]);

                    if (comparison2 != 0)
                    {
                        if (comparison == comparison2)
                        {
                            concordantPairs++;
                        }
                        else
                        {
                            discordantPairs++;
                        }
                    }
                }
            }
        }

        int kendallTauDistance = discordantPairs - concordantPairs;
        return kendallTauDistance;
    }

    private List<List<int>> GetPermutations(int itemCount)
    {
        List<List<int>> permutations = new List<List<int>>();
        List<int> currentPermutation = new List<int>();
        bool[] used = new bool[itemCount + 1]; // Track which items are already used

        GeneratePermutations(permutations, currentPermutation, used, itemCount);

        return permutations;
    }

    private void GeneratePermutations(List<List<int>> permutations, List<int> currentPermutation, bool[] used, int itemCount)
    {
        if (currentPermutation.Count == itemCount)
        {
            permutations.Add(new List<int>(currentPermutation));
            return;
        }

        for (int i = 1; i <= itemCount; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                currentPermutation.Add(i);

                GeneratePermutations(permutations, currentPermutation, used, itemCount);

                used[i] = false;
                currentPermutation.RemoveAt(currentPermutation.Count - 1);
            }
        }
    }

    private static double CalculateSpearmanCorrelation(ICollection<double> values) // TODO коефіцієнт збірної -1 до 1 округлити
    {
        var n = values.Count;

        var ranks = values.Select((x, i) => new KeyValuePair<double, int>(x, i))
            .OrderBy(x => x.Key)
            .Select((x, i) => new KeyValuePair<int, int>(x.Value, i + 1))
            .OrderBy(x => x.Key)
            .Select(x => (double)x.Value)
            .ToList();

        var sumOfSquaredDifferences = values.Select((x, i) => Math.Pow(x - ranks[i], 2)).Sum();
        var spearmanCorrelation = 1 - 6 * sumOfSquaredDifferences / (n * (n * n - 1));

        return Math.Round(spearmanCorrelation);
    }
}