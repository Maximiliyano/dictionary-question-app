using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp.Common.Forms;

public partial class About : Form
{
    public About()
    {
        InitializeComponent();
    }

    private void About_Load(object sender, EventArgs e)
    {
        label2.Text = AboutInfo.Title;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();

        var mainForm = new MainForm();

        mainForm.Show();
    }
}
