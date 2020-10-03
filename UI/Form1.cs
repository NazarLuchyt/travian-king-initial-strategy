using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using InitialStrategy;
using InitialStrategy.Village.Additional;
using Timer = System.Windows.Forms.Timer;

namespace UI {
    public partial class Form1 : Form {
        private const string _averageValueChartLabel = "AverageValue";
        private const string _bestValueChartLabel = "BestValue";
        private Timer _updateChartTimer;
        public ConcurrentQueue<int[]> AverageValuations = new ConcurrentQueue<int[]>();
        public ConcurrentQueue<ResultItem> BestChromosome = new ConcurrentQueue<ResultItem>();

        public Form1() {
            InitializeComponent();
            label1.Text = "test";
        }

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
            chart1.Series[_averageValueChartLabel].Points.Clear();
            chart2.Series[_bestValueChartLabel].Points.Clear();


            foreach (var averageValuation in AverageValuations) {
                chart1.Series[_averageValueChartLabel].Points.AddXY(averageValuation[0], averageValuation[1]);
                chart2.Series[_bestValueChartLabel].Points.AddXY(averageValuation[0], averageValuation[2]);
            }


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
                _updateChartTimer.Stop();
            }
        }

        public void InitChars() {
            chart1.Series.Clear();
            chart2.Series.Clear();

            chart1.Series.Add(_averageValueChartLabel);
            chart1.Series[_averageValueChartLabel].ChartType = SeriesChartType.Line;

            chart2.Series.Add(_bestValueChartLabel);
            chart2.Series[_bestValueChartLabel].ChartType = SeriesChartType.Line;
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
