using DictionaryQuestionApp.Common.Libraries;
using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms.MainForm;

public partial class MainForm : Form
{

    private readonly IList<string> _themesCollection;

    public MainForm()
    {
        InitializeComponent();

        _themesCollection = ThemeLibrary.SelectionAllTheme();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (themes.SelectedIndex < 0)
        {
            MessageBox.Show("No theme selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var nextPageForm = new QuestionForm.QuestionForm();

        Hide();

        nextPageForm.BlockObjective = BuildBlockObjectiveModel(
            BuildThemeModel(themes.SelectedIndex, _themesCollection[themes.SelectedIndex]),
            QuestionsLibrary.ThemeSelectionQuestions(themes.SelectedIndex));

        nextPageForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        themes.Items.AddRange(_themesCollection.ToArray());
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aboutForm = new AboutForm.AboutForm();

        Hide();

        aboutForm.ShowDialog();
    }

    private static BlockObjective BuildBlockObjectiveModel(Theme themeModel, IList<Question> questions) =>
        new()
        {
            Theme = themeModel,
            Questions = questions
        };

    private static Theme BuildThemeModel(int themeId, string title) =>
        new()
        {
            Id = themeId,
            Title = title
        };
}