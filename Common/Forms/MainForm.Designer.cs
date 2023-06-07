namespace DictionaryQuestionApp.Common.Forms;

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
        components = new System.ComponentModel.Container();
        label1 = new Label();
        button1 = new Button();
        comboBox1 = new ComboBox();
        menuStrip1 = new MenuStrip();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(237, 44);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(88, 30);
        label1.TabIndex = 0;
        label1.Text = "Themes";
        // 
        // button1
        // 
        button1.Location = new Point(237, 149);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(88, 28);
        button1.TabIndex = 2;
        button1.Text = "Submit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox1
        // 
        comboBox1.BackColor = Color.White;
        comboBox1.ForeColor = SystemColors.WindowText;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(111, 101);
        comboBox1.Margin = new Padding(4, 3, 4, 3);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(352, 22);
        comboBox1.TabIndex = 3;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(575, 24);
        menuStrip1.TabIndex = 5;
        menuStrip1.Text = "menuStrip1";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(52, 20);
        aboutToolStripMenuItem.Text = "About";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(575, 259);
        Controls.Add(menuStrip1);
        Controls.Add(comboBox1);
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
    public ComboBox comboBox1;

    private MenuStrip menuStrip1;
    private ToolStripMenuItem aboutToolStripMenuItem;
}