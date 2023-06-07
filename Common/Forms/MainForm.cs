using DictionaryQuestionApp.Common.Forms;
using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp;

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
            MessageBox.Show("Error, no theme selected");
            return;
        }

        var nextPageForm = new Questions();

        var selectedIndex = comboBox1.SelectedIndex;

        nextPageForm.SelectedIndexTheme = selectedIndex;

        this.Hide();

        nextPageForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var stringCollection = ThemeLibrary.SelectionAllTheme();

        comboBox1.Items.AddRange(stringCollection.Cast<string>().ToArray());
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        var aboutForm = new About();

        this.Hide();

        aboutForm.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var aboutForm = new About();

        this.Hide();

        aboutForm.ShowDialog();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aboutForm = new About();

        this.Hide();

        aboutForm.ShowDialog();
    }
}