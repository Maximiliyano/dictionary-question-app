namespace DictionaryQuestionApp.Forms.AnalysisForm;

public partial class AnalysisForm : Form
{
    public IList<double> TotalCorrelation { get; set; }
    public IEnumerable<double> User1Mediana { get; set; }
    public IEnumerable<double> User2Mediana { get; set; }

    public AnalysisForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void AnalysisForm_Load(object sender, EventArgs e)
    {
        chart.Series[0].Points.Clear();

        for (var i = 0; i < TotalCorrelation.Count; i++)
        {
            var correlationLabel = GetCorrelationLabel(i);

            if (correlationLabel != null)
                correlationLabel.Text = TotalCorrelation[i].ToString();

            chart.Series[0].Points.AddXY("Question " + (i + 1), TotalCorrelation[i]);
        }
    }

    private Label? GetCorrelationLabel(int index)
    {
        return index switch
        {
            0 => label3,
            1 => label4,
            2 => label12,
            3 => label23,
            4 => label25,
            _ => null
        };
    }
}