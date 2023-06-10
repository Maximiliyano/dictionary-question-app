using DictionaryQuestionApp.Common.Libraries;
using DictionaryQuestionApp.Common.Models;

namespace DictionaryQuestionApp.Forms;

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

        var nextPageForm = new QuestionForm();

        Hide();
        
        nextPageForm.BlockObjective = new BlockObjective
        {
            Theme = new Theme
            {
                Id = themes.SelectedIndex,
                Title = _themesCollection[themes.SelectedIndex]
            }, 
            Questions = QuestionsLibrary.ThemeSelectionQuestions(themes.SelectedIndex)
        };

        nextPageForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        themes.Items.AddRange(_themesCollection.ToArray());
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aboutForm = new AboutForm();

        Hide();

        aboutForm.ShowDialog();
    }
}