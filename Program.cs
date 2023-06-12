using DictionaryQuestionApp.Forms;
using DictionaryQuestionApp.Forms.AboutForm;

namespace DictionaryQuestionApp;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new AboutForm());
    }
}