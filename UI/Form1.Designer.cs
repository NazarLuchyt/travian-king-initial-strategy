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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BestDynaValueLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lastGenerationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generalAvgValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAvgValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBestValueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generalAvgValueChart
            // 
            chartArea9.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea9.AxisX.Title = "Generation";
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.Title = "AVG Evaluate";
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.Name = "ChartArea1";
            this.generalAvgValueChart.ChartAreas.Add(chartArea9);
            this.generalAvgValueChart.Location = new System.Drawing.Point(14, 44);
            this.generalAvgValueChart.Name = "generalAvgValueChart";
            this.generalAvgValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Name = "AverageValue";
            this.generalAvgValueChart.Series.Add(series9);
            this.generalAvgValueChart.Size = new System.Drawing.Size(498, 287);
            this.generalAvgValueChart.TabIndex = 1;
            this.generalAvgValueChart.Text = "chart1";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.ForeColor = System.Drawing.Color.Blue;
            title9.Name = "Title1";
            title9.Text = "Average Evaluate";
            this.generalAvgValueChart.Titles.Add(title9);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1127, 23);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bestValueChart
            // 
            chartArea10.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea10.AxisX.Title = "Generation";
            chartArea10.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.AxisY.Title = "Evaluate";
            chartArea10.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.Name = "ChartArea1";
            this.bestValueChart.ChartAreas.Add(chartArea10);
            this.bestValueChart.Location = new System.Drawing.Point(6, 344);
            this.bestValueChart.Name = "bestValueChart";
            this.bestValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "AverageValue";
            this.bestValueChart.Series.Add(series10);
            this.bestValueChart.Size = new System.Drawing.Size(506, 259);
            this.bestValueChart.TabIndex = 3;
            this.bestValueChart.Text = "chart2";
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.ForeColor = System.Drawing.Color.DarkRed;
            title10.Name = "Title1";
            title10.Text = "Best Evaluate";
            title10.ToolTip = "zzzz";
            this.bestValueChart.Titles.Add(title10);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(990, 23);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopBtn.Size = new System.Drawing.Size(110, 45);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(900, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tes";
            this.label2.Visible = false;
            // 
            // detailAvgValueChart
            // 
            this.detailAvgValueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea11.AxisX.Title = "Generation";
            chartArea11.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.AxisY.Title = "AVG Evaluate";
            chartArea11.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea11.Name = "ChartArea1";
            this.detailAvgValueChart.ChartAreas.Add(chartArea11);
            this.detailAvgValueChart.Location = new System.Drawing.Point(545, 44);
            this.detailAvgValueChart.Name = "detailAvgValueChart";
            this.detailAvgValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "AverageValue";
            this.detailAvgValueChart.Series.Add(series11);
            this.detailAvgValueChart.Size = new System.Drawing.Size(642, 287);
            this.detailAvgValueChart.TabIndex = 6;
            this.detailAvgValueChart.Text = "chart3";
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.ForeColor = System.Drawing.Color.Blue;
            title11.Name = "Title1";
            title11.Text = "Avarage Evaluate (last 50)";
            this.detailAvgValueChart.Titles.Add(title11);
            // 
            // detailBestValueChart
            // 
            this.detailBestValueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea12.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea12.AxisX.Title = "Generation";
            chartArea12.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea12.AxisY.Title = "Evaluate";
            chartArea12.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea12.Name = "ChartArea1";
            this.detailBestValueChart.ChartAreas.Add(chartArea12);
            this.detailBestValueChart.Location = new System.Drawing.Point(545, 344);
            this.detailBestValueChart.Name = "detailBestValueChart";
            this.detailBestValueChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Name = "AverageValue";
            this.detailBestValueChart.Series.Add(series12);
            this.detailBestValueChart.Size = new System.Drawing.Size(642, 259);
            this.detailBestValueChart.TabIndex = 7;
            this.detailBestValueChart.Text = "chart2";
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title12.ForeColor = System.Drawing.Color.DarkRed;
            title12.Name = "Title1";
            title12.Text = "Best Evaluate (last 50)";
            this.detailBestValueChart.Titles.Add(title12);
            // 
            // bestValueDynamicLabel
            // 
            this.bestValueDynamicLabel.AutoSize = true;
            this.bestValueDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestValueDynamicLabel.ForeColor = System.Drawing.Color.Red;
            this.bestValueDynamicLabel.Location = new System.Drawing.Point(540, 3);
            this.bestValueDynamicLabel.Name = "bestValueDynamicLabel";
            this.bestValueDynamicLabel.Size = new System.Drawing.Size(58, 25);
            this.bestValueDynamicLabel.TabIndex = 8;
            this.bestValueDynamicLabel.Text = "Test";
            // 
            // humanGridView
            // 
            this.humanGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.humanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.humanGridView.Location = new System.Drawing.Point(3, 32);
            this.humanGridView.Name = "humanGridView";
            this.humanGridView.RowHeadersVisible = false;
            this.humanGridView.Size = new System.Drawing.Size(825, 561);
            this.humanGridView.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 57);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutation";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "RSM";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Twors";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 650);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BestDynaValueLabel);
            this.tabPage1.Controls.Add(this.generalAvgValueChart);
            this.tabPage1.Controls.Add(this.bestValueChart);
            this.tabPage1.Controls.Add(this.bestValueDynamicLabel);
            this.tabPage1.Controls.Add(this.detailAvgValueChart);
            this.tabPage1.Controls.Add(this.detailBestValueChart);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1206, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Charts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BestDynaValueLabel
            // 
            this.BestDynaValueLabel.AutoSize = true;
            this.BestDynaValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestDynaValueLabel.ForeColor = System.Drawing.Color.Red;
            this.BestDynaValueLabel.Location = new System.Drawing.Point(371, 3);
            this.BestDynaValueLabel.Name = "BestDynaValueLabel";
            this.BestDynaValueLabel.Size = new System.Drawing.Size(163, 25);
            this.BestDynaValueLabel.TabIndex = 9;
            this.BestDynaValueLabel.Text = "Best evaluate:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.humanGridView);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1206, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finish result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(337, 89);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(54, 24);
            this.timerLabel.TabIndex = 12;
            this.timerLabel.Text = "1203";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Work time:";
            // 
            // lastGenerationTextBox
            // 
            this.lastGenerationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGenerationTextBox.Location = new System.Drawing.Point(459, 33);
            this.lastGenerationTextBox.Name = "lastGenerationTextBox";
            this.lastGenerationTextBox.Size = new System.Drawing.Size(59, 29);
            this.lastGenerationTextBox.TabIndex = 14;
            this.lastGenerationTextBox.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last generation count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastGenerationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Luchyt Nazar";
            ((System.ComponentModel.ISupportInitialize)(this.generalAvgValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAvgValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBestValueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label BestDynaValueLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastGenerationTextBox;
        private System.Windows.Forms.Label label4;
    }
}

