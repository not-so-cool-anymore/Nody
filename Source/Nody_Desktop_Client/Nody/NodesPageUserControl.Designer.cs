namespace Nody
{
    partial class NodesPageUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nodesList = new System.Windows.Forms.ListBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.seekDataBtn = new System.Windows.Forms.Button();
            this.tempDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.humidityDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.soundDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comparingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // nodesList
            // 
            this.nodesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nodesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nodesList.FormattingEnabled = true;
            this.nodesList.ItemHeight = 20;
            this.nodesList.Location = new System.Drawing.Point(35, 43);
            this.nodesList.Name = "nodesList";
            this.nodesList.Size = new System.Drawing.Size(240, 304);
            this.nodesList.TabIndex = 0;
            this.nodesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NodesList_MouseDoubleClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(37, 16);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 23);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Nodes: ";
            // 
            // seekDataBtn
            // 
            this.seekDataBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seekDataBtn.Location = new System.Drawing.Point(35, 356);
            this.seekDataBtn.Name = "seekDataBtn";
            this.seekDataBtn.Size = new System.Drawing.Size(240, 51);
            this.seekDataBtn.TabIndex = 6;
            this.seekDataBtn.Text = "Seek Node Data";
            this.seekDataBtn.UseVisualStyleBackColor = true;
            this.seekDataBtn.Click += new System.EventHandler(this.SeekDataBtn_Click);
            // 
            // tempDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.tempDataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempDataChart.Legends.Add(legend1);
            this.tempDataChart.Location = new System.Drawing.Point(281, 43);
            this.tempDataChart.Name = "tempDataChart";
            this.tempDataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.tempDataChart.Series.Add(series1);
            this.tempDataChart.Size = new System.Drawing.Size(316, 138);
            this.tempDataChart.TabIndex = 7;
            this.tempDataChart.Text = "Temperature Data";
            // 
            // humidityDataChart
            // 
            chartArea2.Name = "ChartArea1";
            this.humidityDataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.humidityDataChart.Legends.Add(legend2);
            this.humidityDataChart.Location = new System.Drawing.Point(281, 209);
            this.humidityDataChart.Name = "humidityDataChart";
            this.humidityDataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.humidityDataChart.Series.Add(series2);
            this.humidityDataChart.Size = new System.Drawing.Size(316, 138);
            this.humidityDataChart.TabIndex = 8;
            this.humidityDataChart.Text = "Humidity Data";
            // 
            // soundDataChart
            // 
            chartArea3.Name = "ChartArea1";
            this.soundDataChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.soundDataChart.Legends.Add(legend3);
            this.soundDataChart.Location = new System.Drawing.Point(603, 43);
            this.soundDataChart.Name = "soundDataChart";
            this.soundDataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Sound";
            this.soundDataChart.Series.Add(series3);
            this.soundDataChart.Size = new System.Drawing.Size(316, 138);
            this.soundDataChart.TabIndex = 9;
            this.soundDataChart.Text = "Sound Data";
            // 
            // comparingChart
            // 
            chartArea4.Name = "ChartArea1";
            this.comparingChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.comparingChart.Legends.Add(legend4);
            this.comparingChart.Location = new System.Drawing.Point(603, 209);
            this.comparingChart.Name = "comparingChart";
            this.comparingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series4.Legend = "Legend1";
            series4.Name = "Humidity";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series5.Legend = "Legend1";
            series5.Name = "Temperature";
            this.comparingChart.Series.Add(series4);
            this.comparingChart.Series.Add(series5);
            this.comparingChart.Size = new System.Drawing.Size(316, 138);
            this.comparingChart.TabIndex = 10;
            this.comparingChart.Text = "Compare Data";
            // 
            // NodesPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.comparingChart);
            this.Controls.Add(this.soundDataChart);
            this.Controls.Add(this.humidityDataChart);
            this.Controls.Add(this.tempDataChart);
            this.Controls.Add(this.seekDataBtn);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nodesList);
            this.Name = "NodesPageUserControl";
            this.Size = new System.Drawing.Size(1090, 413);
            ((System.ComponentModel.ISupportInitialize)(this.tempDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nodesList;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button seekDataBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempDataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityDataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart soundDataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart comparingChart;
    }
}
