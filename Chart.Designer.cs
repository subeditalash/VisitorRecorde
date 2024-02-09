
namespace applicationDevelopmentCW1
{
    partial class chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(78, 58);
            this.chartReport.Name = "chartReport";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Customer";
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(560, 315);
            this.chartReport.TabIndex = 0;
            this.chartReport.Text = "chart1";
            // 
            // chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartReport);
            this.Name = "chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
    }
}