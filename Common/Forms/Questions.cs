﻿using DictionaryQuestionApp.Common.Libraries;

namespace DictionaryQuestionApp
{
    public partial class Questions : Form
    {
        private int _result = 0;

        private List<int> _selectedQuestionsIndex = new List<int>();

        public int SelectedIndexTheme { get; set; }

        public Questions()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox4.Checked);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox5.Checked);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox6.Checked);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCountCalculation(checkBox7.Checked);
        }

        private void CheckBoxCountCalculation(bool check)
        {
            switch (check)
            {
                case true:
                    _result++;

                    if (_result >= 5)
                    {
                        foreach (Control control in Controls)
                        {
                            if (control is CheckBox && !((CheckBox)control).Checked)
                            {
                                control.Enabled = false;
                            }
                        }
                    }
                    break;
                default:
                    _result--;

                    foreach (Control control in Controls)
                    {
                        if (control is CheckBox)
                        {
                            control.Enabled = true;
                        }
                    }
                    break;
            }

            countAnswers.Text = $"{_result}/5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_result <= 0)
            {
                MessageBox.Show("No question selected!");
                return;
            }

            this.Hide();

            var answers = new Answers();

            foreach (Control control in Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    answers.SelectedControlQuestions.Add((CheckBox)control);
                }
            }

            answers.Show();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            var themeQuestions = QuestionsLibrary.ThemeSelectionQuestions(SelectedIndexTheme);

            CheckBox[] checkboxes = {
                checkBox1,
                checkBox2,
                checkBox3,
                checkBox4,
                checkBox5,
                checkBox6,
                checkBox7
            };

            for (int i = 0; i < checkboxes.Length; i++)
            {
                checkboxes[i].Text = themeQuestions[i];
            }
        }
    }
}