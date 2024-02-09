
namespace applicationDevelopmentCW1
{
    partial class dailyReport
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
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.visitors,
            this.time,
            this.Cost});
            this.DailyDataGrid.Location = new System.Drawing.Point(86, 159);
            this.DailyDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.ReadOnly = true;
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(489, 271);
            this.DailyDataGrid.TabIndex = 15;
            this.DailyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyDataGrid_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date :";
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Location = new System.Drawing.Point(167, 110);
            this.dateToday.Name = "dateToday";
            this.dateToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateToday.Size = new System.Drawing.Size(38, 17);
            this.dateToday.TabIndex = 17;
            this.dateToday.Text = "Date";
            this.dateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // visitors
            // 
            this.visitors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.visitors.HeaderText = "Total No. of Customer";
            this.visitors.MinimumWidth = 6;
            this.visitors.Name = "visitors";
            this.visitors.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "Total Duration (Minutes)";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // dailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DailyDataGrid);
            this.Name = "dailyReport";
            this.Text = "dailyReport";
            this.Load += new System.EventHandler(this.dailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}