using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp.Common.Forms;

public partial class Answers : Form
{
    public IList<CheckBox> SelectedControlQuestions { get; }

    public Answers()
    {
        SelectedControlQuestions = new List<CheckBox>();

        InitializeComponent();
    }

    private void Answers_Load(object sender, EventArgs e)
    {
        // Question 1
        label2.Text = SelectedControlQuestions[0].Text;
        label10.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[0].TabIndex);

        // Question 2
        label5.Text = SelectedControlQuestions[1].Text;
        label11.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[1].TabIndex);

        // Question 3
        label7.Text = SelectedControlQuestions[2].Text;
        label12.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[2].TabIndex);

        // Question 4
        label9.Text = SelectedControlQuestions[3].Text;
        label13.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[3].TabIndex);

        // Question 5
        label21.Text = SelectedControlQuestions[4].Text;
        label14.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[4].TabIndex);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();

        var analysisForm = new Analysis();

        analysisForm.Show();
    }
}