using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using InitialStrategy;
using InitialStrategy.Village;
using InitialStrategy.Village.Additional;
using Timer = System.Windows.Forms.Timer;

namespace UI {
    public partial class Form1 : Form {
        private const string AverageValueChartLabel = "AverageValue";
        private const string BestValueChartLabel = "BestValue";
        private const string DetailBestValueChartLabel = "DetailBestValue";
        private const string DetailAvgValueChartLabel = "DetailAvgValue";
        private Timer _updateChartTimer;
        public ConcurrentQueue<int[]> AverageValuations = new ConcurrentQueue<int[]>();
        public ConcurrentQueue<ResultItem> BestChromosome = new ConcurrentQueue<ResultItem>();

        public Form1() {
            InitializeComponent();
            label1.Text = "test";
        }

        public VillageInstance Village { get; set; } = new VillageInstance();

        private void label1_Click(object sender, EventArgs e) { }

        private void SetupGeneticAlgorithm() {
            new Thread(delegate() {
                var ga = new InitialStrategyDomain();
                ga.Run(UpdateStats, FinishStats);
            }).Start();
        }

        public void UpdateStats(int generationNumber, int averageValue, int bestValue) {
            AverageValuations.Enqueue(new[] {generationNumber, averageValue, bestValue});
        }

        public void FinishStats(ResultItem result) {
            BestChromosome.Enqueue(result);
        }

        public void InitTimer() {
            _updateChartTimer = new Timer();
            _updateChartTimer.Tick += UpdateCharts;
            _updateChartTimer.Interval = 300; // in miliseconds
            _updateChartTimer.Start();
        }

        public void UpdateCharts(object sender, EventArgs e) {
            generalAvgValueChart.Series[AverageValueChartLabel].Points.Clear();
            bestValueChart.Series[BestValueChartLabel].Points.Clear();
            detailAvgValueChart.Series[DetailAvgValueChartLabel].Points.Clear();
            detailBestValueChart.Series[DetailBestValueChartLabel].Points.Clear();

            var result = AverageValuations.ToList();

            result.ForEach(item => {
                generalAvgValueChart.Series[AverageValueChartLabel].Points
                    .AddXY(item[0], item[1]);
                bestValueChart.Series[BestValueChartLabel].Points.AddXY(item[0], item[2]);
            });

            var skipCount = result.Count - 50;
            var newResult = result.Skip(skipCount > 0 ? skipCount : 0);

            foreach (var item in result.Skip(skipCount > 0 ? skipCount : 0)) {
                detailAvgValueChart.Series[DetailAvgValueChartLabel].Points
                    .AddXY(item[0], item[1]);
                detailBestValueChart.Series[DetailBestValueChartLabel].Points
                    .AddXY(item[0], item[2]);
            }

            bestValueDynamicLabel.Text = newResult.Last()[2].ToString();


            if (!BestChromosome.IsEmpty) {
                var res = new ResultItem();
                BestChromosome.TryPeek(out res);
                label1.Text = res.ResultHours;
                label2.Text = "";
                var success = 0;
                res.Strategy.ForEach(item => {
                    if (item == 21) {
                        success++;
                    }

                    var te = success == 10 ? "Finish \n" : "";
                    label2.Text += "|" + item + te;
                });

                var humanResult = Village.GetDetailResult(res.Strategy.ToArray());
                humanGridView.Columns.Add("Number", "№");
                humanGridView.Columns.Add("Id", "Id");
                humanGridView.Columns.Add("Action", "Action");
                humanGridView.Columns.Add("Time", "Wait time");
                humanGridView.Columns.Add("Status", "Status");
                humanGridView.Rows.Add(humanResult.Count);

                for (var i = 0; i < humanResult.Count; i++) {
                    humanGridView.Rows[i].Cells[0].Value = i + 1;
                    humanGridView.Rows[i].Cells[1].Value = humanResult[i].Id;
                    humanGridView.Rows[i].Cells[2].Value = humanResult[i].Action;
                    humanGridView.Rows[i].Cells[3].Value = humanResult[i].WaitSeconds / 60;
                    humanGridView.Rows[i].Cells[4].Value = humanResult[i].IsGood;
                }

                _updateChartTimer.Stop();
            }
        }

        public void InitChars() {
            generalAvgValueChart.Series.Clear();
            bestValueChart.Series.Clear();
            detailAvgValueChart.Series.Clear();
            detailBestValueChart.Series.Clear();

            generalAvgValueChart.Series.Add(AverageValueChartLabel);
            detailAvgValueChart.Series.Add(DetailAvgValueChartLabel);
            bestValueChart.Series.Add(BestValueChartLabel);
            detailBestValueChart.Series.Add(DetailBestValueChartLabel);

            generalAvgValueChart.Series[AverageValueChartLabel].ChartType =
                bestValueChart.Series[BestValueChartLabel].ChartType =
                    detailAvgValueChart.Series[DetailAvgValueChartLabel].ChartType =
                        detailBestValueChart.Series[DetailBestValueChartLabel].ChartType =
                            SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e) {
            InitChars();
            InitTimer();

            SetupGeneticAlgorithm();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            _updateChartTimer.Stop();
        }
    }
}
