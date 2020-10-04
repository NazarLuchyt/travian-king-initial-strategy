namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.generalAvgValueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.bestValueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detailAvgValueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.detailBestValueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bestValueDynamicLabel = new System.Windows.Forms.Label();
            this.humanGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.generalAvgValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAvgValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBestValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generalAvgValueChart
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.generalAvgValueChart.ChartAreas.Add(chartArea1);
            this.generalAvgValueChart.Location = new System.Drawing.Point(526, 97);
            this.generalAvgValueChart.Name = "generalAvgValueChart";
            this.generalAvgValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "AverageValue";
            this.generalAvgValueChart.Series.Add(series1);
            this.generalAvgValueChart.Size = new System.Drawing.Size(468, 257);
            this.generalAvgValueChart.TabIndex = 1;
            this.generalAvgValueChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1011, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bestValueChart
            // 
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.Name = "ChartArea1";
            this.bestValueChart.ChartAreas.Add(chartArea2);
            this.bestValueChart.Location = new System.Drawing.Point(526, 404);
            this.bestValueChart.Name = "bestValueChart";
            this.bestValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "AverageValue";
            this.bestValueChart.Series.Add(series2);
            this.bestValueChart.Size = new System.Drawing.Size(468, 257);
            this.bestValueChart.TabIndex = 3;
            this.bestValueChart.Text = "chart2";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(1092, 23);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tes";
            // 
            // detailAvgValueChart
            // 
            this.detailAvgValueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.Name = "ChartArea1";
            this.detailAvgValueChart.ChartAreas.Add(chartArea3);
            this.detailAvgValueChart.Location = new System.Drawing.Point(1011, 97);
            this.detailAvgValueChart.Name = "detailAvgValueChart";
            this.detailAvgValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "AverageValue";
            this.detailAvgValueChart.Series.Add(series3);
            this.detailAvgValueChart.Size = new System.Drawing.Size(720, 257);
            this.detailAvgValueChart.TabIndex = 6;
            this.detailAvgValueChart.Text = "chart3";
            // 
            // detailBestValueChart
            // 
            this.detailBestValueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.Name = "ChartArea1";
            this.detailBestValueChart.ChartAreas.Add(chartArea4);
            this.detailBestValueChart.Location = new System.Drawing.Point(1011, 404);
            this.detailBestValueChart.Name = "detailBestValueChart";
            this.detailBestValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "AverageValue";
            this.detailBestValueChart.Series.Add(series4);
            this.detailBestValueChart.Size = new System.Drawing.Size(720, 257);
            this.detailBestValueChart.TabIndex = 7;
            this.detailBestValueChart.Text = "chart2";
            // 
            // bestValueDynamicLabel
            // 
            this.bestValueDynamicLabel.AutoSize = true;
            this.bestValueDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestValueDynamicLabel.Location = new System.Drawing.Point(1491, 366);
            this.bestValueDynamicLabel.Name = "bestValueDynamicLabel";
            this.bestValueDynamicLabel.Size = new System.Drawing.Size(58, 25);
            this.bestValueDynamicLabel.TabIndex = 8;
            this.bestValueDynamicLabel.Text = "Test";
            // 
            // humanGridView
            // 
            this.humanGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.humanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.humanGridView.ColumnHeadersVisible = false;
            this.humanGridView.Location = new System.Drawing.Point(12, 97);
            this.humanGridView.Name = "humanGridView";
            this.humanGridView.RowHeadersVisible = false;
            this.humanGridView.Size = new System.Drawing.Size(490, 564);
            this.humanGridView.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 673);
            this.Controls.Add(this.humanGridView);
            this.Controls.Add(this.bestValueDynamicLabel);
            this.Controls.Add(this.detailBestValueChart);
            this.Controls.Add(this.detailAvgValueChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.bestValueChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generalAvgValueChart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.generalAvgValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAvgValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBestValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart generalAvgValueChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart bestValueChart;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart detailAvgValueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart detailBestValueChart;
        private System.Windows.Forms.Label bestValueDynamicLabel;
        private System.Windows.Forms.DataGridView humanGridView;
    }
}

