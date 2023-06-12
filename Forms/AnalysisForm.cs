namespace DictionaryQuestionApp.Forms
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart5_Click(object sender, EventArgs e)
        {
            var fds = new List<List<int>>
            {
                new() { 3, 4, 1, 2 }
            };
            chart.Series[0].Points.Clear();
            
            for (var i = 0; i < fds.Count; i++)
            {
                var difference = CalculateDifference(fds[i]); // Функція для обчислення розбіжності між рангами питання
                chart.Series[0].Points.AddXY("Question " + (i + 1), difference);
            }

        }
        
        private static int CalculateDifference(IReadOnlyCollection<int> ranking)
        {
            var maxRank = ranking.Max();
            var minRank = ranking.Min();

            var difference = maxRank - minRank;

            return difference;
        }
    }
}
