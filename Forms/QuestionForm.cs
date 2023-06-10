using DictionaryQuestionApp.Common.Libraries;
using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms;

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

        countAnswers.Text = $@"{_result}/5";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_result <= 0)
        {
            MessageBox.Show("No question selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Hide();

        var answers = new AnswerForm();

        foreach (Control control in Controls)
        {
            if (control is CheckBox { Checked: true } checkBox)
            {
                answers.Questions.Add(new Question
                {
                    Id = checkBox.TabIndex,
                    Description = checkBox.Text
                });
            }
        }

        foreach (var question in answers.Questions)
        {
            var fgd = BlockObjective.Questions.FirstOrDefault(x => x.Description == question.Description);

            if (fgd is not null)
            {
                question.Answers = fgd.Answers;
            }
        }

        answers.Show();
    }

    private void Questions_Load(object sender, EventArgs e)
    {
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
            checkboxes[i].Text = themeQuestions[i].Description;
        }
    }
}