namespace DictionaryQuestionApp.Forms.QuestionForm;

partial class QuestionForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        label1 = new Label();
        question1 = new CheckBox();
        question2 = new CheckBox();
        question3 = new CheckBox();
        question4 = new CheckBox();
        question5 = new CheckBox();
        question6 = new CheckBox();
        question7 = new CheckBox();
        button1 = new Button();
        countAnswers = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(200, 41);
        label1.Name = "label1";
        label1.Size = new Size(499, 21);
        label1.TabIndex = 0;
        label1.Text = "Оберіть, будь ласка, питання, на які вихочете отримати відповіді";
        // 
        // question1
        // 
        question1.AutoSize = true;
        question1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question1.Location = new Point(33, 76);
        question1.Name = "question1";
        question1.Size = new Size(82, 19);
        question1.TabIndex = 1;
        question1.Text = "Питання 1";
        question1.UseVisualStyleBackColor = true;
        question1.CheckedChanged += Question1CheckedChanged;
        // 
        // question2
        // 
        question2.AutoSize = true;
        question2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question2.Location = new Point(33, 101);
        question2.Name = "question2";
        question2.Size = new Size(82, 19);
        question2.TabIndex = 2;
        question2.Text = "Питання 2";
        question2.UseVisualStyleBackColor = true;
        question2.CheckedChanged += Question2CheckedChanged;
        // 
        // question3
        // 
        question3.AutoSize = true;
        question3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question3.Location = new Point(33, 126);
        question3.Name = "question3";
        question3.Size = new Size(82, 19);
        question3.TabIndex = 3;
        question3.Text = "Питання 3";
        question3.UseVisualStyleBackColor = true;
        question3.CheckedChanged += Question3CheckedChanged;
        // 
        // question4
        // 
        question4.AutoSize = true;
        question4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question4.Location = new Point(33, 151);
        question4.Name = "question4";
        question4.Size = new Size(82, 19);
        question4.TabIndex = 4;
        question4.Text = "Питання 4";
        question4.UseVisualStyleBackColor = true;
        question4.CheckedChanged += Question4CheckedChanged;
        // 
        // question5
        // 
        question5.AutoSize = true;
        question5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question5.Location = new Point(33, 176);
        question5.Name = "question5";
        question5.Size = new Size(82, 19);
        question5.TabIndex = 5;
        question5.Text = "Питання 5";
        question5.UseVisualStyleBackColor = true;
        question5.CheckedChanged += Question5CheckedChanged;
        // 
        // question6
        // 
        question6.AutoSize = true;
        question6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question6.Location = new Point(33, 201);
        question6.Name = "question6";
        question6.Size = new Size(82, 19);
        question6.TabIndex = 6;
        question6.Text = "Питання 6";
        question6.UseVisualStyleBackColor = true;
        question6.CheckedChanged += Question6CheckedChanged;
        // 
        // question7
        // 
        question7.AutoSize = true;
        question7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        question7.Location = new Point(33, 226);
        question7.Name = "question7";
        question7.Size = new Size(82, 19);
        question7.TabIndex = 7;
        question7.Text = "Питання 7";
        question7.UseVisualStyleBackColor = true;
        question7.CheckedChanged += Question7CheckedChanged;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(236, 205, 180);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(370, 287);
        button1.Name = "button1";
        button1.Size = new Size(162, 26);
        button1.TabIndex = 8;
        button1.Text = "Отримати відповіді";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // countAnswers
        // 
        countAnswers.AutoSize = true;
        countAnswers.BackColor = SystemColors.Control;
        countAnswers.FlatStyle = FlatStyle.Popup;
        countAnswers.ForeColor = SystemColors.ControlDarkDark;
        countAnswers.Location = new Point(34, 271);
        countAnswers.Name = "countAnswers";
        countAnswers.Size = new Size(24, 15);
        countAnswers.TabIndex = 9;
        countAnswers.Text = "0/5";
        // 
        // QuestionForm
        // 
        BackColor = Color.FromArgb(251, 248, 241);
        ClientSize = new Size(923, 325);
        Controls.Add(question1);
        Controls.Add(question2);
        Controls.Add(question3);
        Controls.Add(question4);
        Controls.Add(question5);
        Controls.Add(question6);
        Controls.Add(question7);
        Controls.Add(button1);
        Controls.Add(countAnswers);
        Controls.Add(label1);
        Name = "QuestionForm";
        Load += Questions_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private CheckBox question1;
    private CheckBox question2;
    private CheckBox question3;
    private CheckBox question4;
    private CheckBox question5;
    private CheckBox question6;
    private CheckBox question7;
    private Button button1;
    private Label countAnswers;
}