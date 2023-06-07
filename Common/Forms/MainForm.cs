using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp.Common.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex < 0)
        {
            MessageBox.Show("No theme selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var nextPageForm = new Questions();

        nextPageForm.SelectedIndexTheme = comboBox1.SelectedIndex;

        Hide();

        nextPageForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var stringCollection = ThemeLibrary.SelectionAllTheme();

        comboBox1.Items.AddRange(stringCollection.Cast<string>().ToArray());
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aboutForm = new About();

        Hide();

        aboutForm.ShowDialog();
    }
}