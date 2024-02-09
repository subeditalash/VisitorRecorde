
namespace applicationDevelopmentCW1
{
    partial class Group
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
            this.AdultCount = new System.Windows.Forms.Label();
            this.CountAdult = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountChild = new System.Windows.Forms.NumericUpDown();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerEntryTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerEntryDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.GrpID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpID)).BeginInit();
            this.SuspendLayout();
            // 
            // AdultCount
            // 
            this.AdultCount.AutoSize = true;
            this.AdultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultCount.ForeColor = System.Drawing.SystemColors.Info;
            this.AdultCount.Location = new System.Drawing.Point(19, 131);
            this.AdultCount.Name = "AdultCount";
            this.AdultCount.Size = new System.Drawing.Size(52, 20);
            this.AdultCount.TabIndex = 19;
            this.AdultCount.Text = "Adult";
            // 
            // CountAdult
            // 
            this.CountAdult.Location = new System.Drawing.Point(124, 129);
            this.CountAdult.Name = "CountAdult";
            this.CountAdult.Size = new System.Drawing.Size(120, 22);
            this.CountAdult.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(371, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(411, 447);
            this.dataGridView2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Group Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(19, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Child";
            // 
            // CountChild
            // 
            this.CountChild.Location = new System.Drawing.Point(124, 184);
            this.CountChild.Name = "CountChild";
            this.CountChild.Size = new System.Drawing.Size(120, 22);
            this.CountChild.TabIndex = 20;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            // 
            // dateTimePickerEntryTime
            // 
            this.dateTimePickerEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEntryTime.Location = new System.Drawing.Point(143, 76);
            this.dateTimePickerEntryTime.Name = "dateTimePickerEntryTime";
            this.dateTimePickerEntryTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEntryTime.TabIndex = 50;
            this.dateTimePickerEntryTime.Value = new System.DateTime(2021, 12, 21, 9, 40, 9, 0);
            this.dateTimePickerEntryTime.ValueChanged += new System.EventHandler(this.dateTimePickerEntryTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Entry Time";
            // 
            // dateTimePickerEntryDay
            // 
            this.dateTimePickerEntryDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntryDay.Location = new System.Drawing.Point(113, 266);
            this.dateTimePickerEntryDay.Name = "dateTimePickerEntryDay";
            this.dateTimePickerEntryDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEntryDay.TabIndex = 52;
            this.dateTimePickerEntryDay.Value = new System.DateTime(2021, 12, 21, 9, 40, 9, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(19, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Day ";
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(134, 347);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addGroupButton.TabIndex = 53;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // GrpID
            // 
            this.GrpID.Location = new System.Drawing.Point(143, 32);
            this.GrpID.Name = "GrpID";
            this.GrpID.Size = new System.Drawing.Size(120, 22);
            this.GrpID.TabIndex = 54;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpID);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.dateTimePickerEntryDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountChild);
            this.Controls.Add(this.AdultCount);
            this.Controls.Add(this.CountAdult);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdultCount;
        private System.Windows.Forms.NumericUpDown CountAdult;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CountChild;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.NumericUpDown GrpID;
    }
}