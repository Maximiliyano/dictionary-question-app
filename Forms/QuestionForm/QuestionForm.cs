using DictionaryQuestionApp.Common.Libraries;
using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms.QuestionForm;

public partial class QuestionForm : Form
{
    public BlockObjective BlockObjective { get; set; }

    private int _result;

    public QuestionForm()
    {
        InitializeComponent();
    }

    private void Question1CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question1.Checked);
    }

    private void Question2CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question2.Checked);
    }

    private void Question3CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question3.Checked);
    }

    private void Question4CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question4.Checked);
    }

    private void Question5CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question5.Checked);
    }

    private void Question6CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question6.Checked);
    }

    private void Question7CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxCountCalculation(question7.Checked);
    }

    private void CheckBoxCountCalculation(bool check)
    {
        switch (check)
        {
            case true:
                _result++;

                if (_result >= 5)
                {
                    foreach (Control control in Controls)
                    {
                        if (control is CheckBox { Checked: false } checkBox)
                        {
                            checkBox.Enabled = false;
                        }
                    }

                    button1.Enabled = true;
                }
                break;
            default:
                _result--;

                foreach (Control control in Controls)
                {
                    if (control is CheckBox)
                    {
                        control.Enabled = true;
                    }
                }
                break;
        }

        if (_result < 5)
            button1.Enabled = false;

        countAnswers.Text = $@"{_result}/5";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();

        var answers = new AnswerForm.AnswerForm();

        foreach (Control control in Controls)
        {
            if (control is CheckBox { Checked: true } checkBox)
            {
                answers.Questions.Add(
                    BuildQuestionModel(
                        checkBox.TabIndex,
                        checkBox.Text.Remove(0, 3)));
            }
        }

        foreach (var question in answers.Questions)
        {
            var filledQuestion = BlockObjective.Questions.FirstOrDefault(x => x.Id == question.Id);

            if (filledQuestion is not null)
            {
                question.Answers = filledQuestion.Answers;
            }
        }

        answers.Show();
    }

    private void Questions_Load(object sender, EventArgs e)
    {
        button1.Enabled = false;

        var themeQuestions = QuestionsLibrary.ThemeSelectionQuestions(BlockObjective.Theme.Id);

        CheckBox[] checkboxes = {
            question1,
            question2,
            question3,
            question4,
            question5,
            question6,
            question7
        };

        for (var i = 0; i < checkboxes.Length; i++)
        {
            checkboxes[i].Text = string.Format(QuestionsLibrary.QuestionStringEndpointFormat, i + 1, themeQuestions[i].Description);
        }
    }

    private static Question BuildQuestionModel(int questionId, string description) =>
        new()
        {
            Id = questionId,
            Description = description
        };
}