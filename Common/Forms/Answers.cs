using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp
{
    public partial class Answers : Form
    {
        public IList<CheckBox> SelectedControlQuestions { get; set; }

        public Answers()
        {
            SelectedControlQuestions = new List<CheckBox>();
            InitializeComponent();
        }

        private void Answers_Load(object sender, EventArgs e)
        {
            label2.Text = SelectedControlQuestions[0].Text;
            label10.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[0].TabIndex);

            label5.Text = SelectedControlQuestions[1].Text;
            label11.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[1].TabIndex);

            label7.Text = SelectedControlQuestions[2].Text;
            label12.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[2].TabIndex);

            label9.Text = SelectedControlQuestions[3].Text;
            label13.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[3].TabIndex);

            label21.Text = SelectedControlQuestions[4].Text;
            label14.Text = AnswersLibrary.SelectionAnswersToQuestions(SelectedControlQuestions[4].TabIndex);

            /*
        var selectedTheme = answers[comboBox1.SelectedIndex];

        var random = new Random();
        var randomIndex = random.Next(0, selectedTheme.Count);
        */

            //MessageBox.Show(selectedTheme[randomIndex]);
        }
    }
}
