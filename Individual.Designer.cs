
namespace applicationDevelopmentCW1
{
    partial class Individual
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
            this.label1 = new System.Windows.Forms.Label();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSelectType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEntryDay = new System.Windows.Forms.DateTimePicker();
            this.IndID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(21, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Day ";
            // 
            // addEntryButton
            // 
            this.addEntryButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.addEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntryButton.ForeColor = System.Drawing.Color.Bisque;
            this.addEntryButton.Location = new System.Drawing.Point(95, 364);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(115, 35);
            this.addEntryButton.TabIndex = 35;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = false;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.SystemColors.Info;
            this.Type.Location = new System.Drawing.Point(21, 204);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(49, 20);
            this.Type.TabIndex = 33;
            this.Type.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 388);
            this.dataGridView1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Entry Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Individual Id";
            // 
            // comboBoxSelectType
            // 
            this.comboBoxSelectType.FormattingEnabled = true;
            this.comboBoxSelectType.Items.AddRange(new object[] {
            "Child",
            "Adult"});
            this.comboBoxSelectType.Location = new System.Drawing.Point(147, 191);
            this.comboBoxSelectType.Name = "comboBoxSelectType";
            this.comboBoxSelectType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelectType.TabIndex = 46;
            this.comboBoxSelectType.Text = "Select";
            // 
            // dateTimePickerEntryTime
            // 
            this.dateTimePickerEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEntryTime.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerEntryTime.Name = "dateTimePickerEntryTime";
            this.dateTimePickerEntryTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEntryTime.TabIndex = 48;
            this.dateTimePickerEntryTime.Value = new System.DateTime(2021, 12, 23, 13, 46, 4, 0);
            this.dateTimePickerEntryTime.ValueChanged += new System.EventHandler(this.dateTimePickerEntryTime_ValueChanged);
            // 
            // dateTimePickerEntryDay
            // 
            this.dateTimePickerEntryDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntryDay.Location = new System.Drawing.Point(130, 268);
            this.dateTimePickerEntryDay.Name = "dateTimePickerEntryDay";
            this.dateTimePickerEntryDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEntryDay.TabIndex = 49;
            this.dateTimePickerEntryDay.Value = new System.DateTime(2021, 12, 23, 13, 46, 29, 0);
            // 
            // IndID
            // 
            this.IndID.Location = new System.Drawing.Point(172, 75);
            this.IndID.Name = "IndID";
            this.IndID.Size = new System.Drawing.Size(120, 22);
            this.IndID.TabIndex = 50;
            // 
            // Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndID);
            this.Controls.Add(this.dateTimePickerEntryDay);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Controls.Add(this.comboBoxSelectType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Individual";
            this.Text = "Individual";
            this.Load += new System.EventHandler(this.Individual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSelectType;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDay;
        private System.Windows.Forms.NumericUpDown IndID;
    }
}