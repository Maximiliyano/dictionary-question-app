namespace DictionaryQuestionApp.Forms.MainForm;

partial class MainForm
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
        button1 = new Button();
        themes = new ComboBox();
        menuStrip1 = new MenuStrip();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        label2 = new Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(206, 60);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(139, 30);
        label1.TabIndex = 0;
        label1.Text = "Вітаємо Вас!";
        // 
        // button1
        // 
        button1.Location = new Point(228, 182);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(88, 28);
        button1.TabIndex = 2;
        button1.Text = "Вибрати";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // themes
        // 
        themes.BackColor = Color.White;
        themes.ForeColor = SystemColors.WindowText;
        themes.FormattingEnabled = true;
        themes.Location = new Point(98, 140);
        themes.Margin = new Padding(4, 3, 4, 3);
        themes.Name = "themes";
        themes.Size = new Size(352, 22);
        themes.TabIndex = 3;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(565, 24);
        menuStrip1.TabIndex = 5;
        menuStrip1.Text = "menuStrip1";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(88, 20);
        aboutToolStripMenuItem.Text = "Про додаток";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(60, 99);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(447, 21);
        label2.TabIndex = 6;
        label2.Text = "Оберіть, будь ласка, тему опитування з випадаючого списка:";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(565, 242);
        Controls.Add(label2);
        Controls.Add(menuStrip1);
        Controls.Add(themes);
        Controls.Add(button1);
        Controls.Add(label1);
        Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "Form1";
        Load += MainForm_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    public ComboBox themes;

    private MenuStrip menuStrip1;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private Label label2;
}