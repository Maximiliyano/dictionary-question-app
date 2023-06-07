using DictionaryQuestionApp.Common.Forms;

namespace DictionaryQuestionApp;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}