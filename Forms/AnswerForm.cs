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
        for (int i = 0; i < Questions.Count; i++)
        {
            Label questionLabel = GetQuestionLabel(i);
            Label idLabel = GetIdLabel(i);

            questionLabel.Text = Questions[i].Description;
            idLabel.Text = ConvertToString(Questions[i].Id);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();

        var analysisForm = new AnalysisForm();

        analysisForm.Show();
    }

    private Label GetQuestionLabel(int index)
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

    private Label GetIdLabel(int index)
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
                str += $"{i + 1}. {question.Answers[i]}\n";
            }
        }
        return str;
    }
}