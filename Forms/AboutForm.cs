﻿namespace DictionaryQuestionApp.Forms;

public partial class AboutForm : Form
{
    public AboutForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();

        var mainForm = new MainForm();

        mainForm.Show();
    }
}
