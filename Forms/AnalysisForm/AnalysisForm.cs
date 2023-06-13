using System.Globalization;

namespace DictionaryQuestionApp.Forms.AnalysisForm;

public partial class AnalysisForm : Form
{
    public IList<double> TotalCorrelation { get; set; }
    public IList<double> User1Median { get; set; }
    public IList<double> User2Median { get; set; }

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
                correlationLabel.Text = TotalCorrelation[i].ToString(CultureInfo.InvariantCulture);

            chart.Series[0].Points.AddXY("Питання " + (i + 1), TotalCorrelation[i]);
        }

        for (var i = 0; i < User1Median.Count; i++)
        {
            var medianLabel = GetMedianLabel(i);

            if (medianLabel != null)
                medianLabel.Text = ((User1Median[i] + User2Median[i]) / 2.0).ToString();
        }
    }

    private Label? GetMedianLabel(int index) =>
        index switch
        {
            0 => label1,
            1 => label11,
            2 => label13,
            3 => label24,
            4 => label26,
            _ => null
        };

    private Label? GetCorrelationLabel(int index) =>
        index switch
        {
            0 => label3,
            1 => label4,
            2 => label12,
            3 => label23,
            4 => label25,
            _ => null
        };
}