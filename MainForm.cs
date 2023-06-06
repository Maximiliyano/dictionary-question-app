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
        /*
        var selectedTheme = answers[comboBox1.SelectedIndex];

        var random = new Random();
        var randomIndex = random.Next(0, selectedTheme.Count);
        */

        //MessageBox.Show(selectedTheme[randomIndex]);

        var nextPageForm = new Questions();

        this.Hide();

        nextPageForm.Show();
    }
}