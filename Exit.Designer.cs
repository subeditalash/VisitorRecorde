
namespace applicationDevelopmentCW1
{
    partial class Exit
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
            this.button1 = new System.Windows.Forms.Button();
            this.leftTimeInd = new System.Windows.Forms.Label();
            this.txtIdGrp = new System.Windows.Forms.TextBox();
            this.dateTimePickerExitTimeInd = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.idtTypeComb = new System.Windows.Forms.ComboBox();
            this.categoryExit = new System.Windows.Forms.Label();
            this.dayInd = new System.Windows.Forms.Label();
            this.entryTimeInd = new System.Windows.Forms.Label();
            this.txtExitWeekday = new System.Windows.Forms.TextBox();
            this.txtExitEntryTimeInd = new System.Windows.Forms.TextBox();
            this.txtExitDayInd = new System.Windows.Forms.TextBox();
            this.txtExitTypeInd = new System.Windows.Forms.TextBox();
            this.adultGrp = new System.Windows.Forms.Label();
            this.childGrp = new System.Windows.Forms.Label();
            this.txtExitAdultGrp = new System.Windows.Forms.TextBox();
            this.txtExitChildGrp = new System.Windows.Forms.TextBox();
            this.dateTimePickerExitTimeGrp = new System.Windows.Forms.DateTimePicker();
            this.exitTimeGrp = new System.Windows.Forms.Label();
            this.txtExitDuration = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.Label();
            this.txtEntryTimeGrp = new System.Windows.Forms.TextBox();
            this.entryTimeGrp = new System.Windows.Forms.Label();
            this.txtExitDayGrp = new System.Windows.Forms.TextBox();
            this.dayGrp = new System.Windows.Forms.Label();
            this.txtExitPrice = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.Label();
            this.lableIdGrp = new System.Windows.Forms.Label();
            this.labelIdInd = new System.Windows.Forms.Label();
            this.txtIdInd = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(321, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftTimeInd
            // 
            this.leftTimeInd.AutoSize = true;
            this.leftTimeInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTimeInd.ForeColor = System.Drawing.SystemColors.Info;
            this.leftTimeInd.Location = new System.Drawing.Point(23, 149);
            this.leftTimeInd.Name = "leftTimeInd";
            this.leftTimeInd.Size = new System.Drawing.Size(89, 20);
            this.leftTimeInd.TabIndex = 26;
            this.leftTimeInd.Text = "Left Time";
            this.leftTimeInd.Visible = false;
            // 
            // txtIdGrp
            // 
            this.txtIdGrp.Location = new System.Drawing.Point(210, 113);
            this.txtIdGrp.Name = "txtIdGrp";
            this.txtIdGrp.Size = new System.Drawing.Size(100, 22);
            this.txtIdGrp.TabIndex = 33;
            // 
            // dateTimePickerExitTimeInd
            // 
            this.dateTimePickerExitTimeInd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerExitTimeInd.Location = new System.Drawing.Point(147, 149);
            this.dateTimePickerExitTimeInd.Name = "dateTimePickerExitTimeInd";
            this.dateTimePickerExitTimeInd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExitTimeInd.TabIndex = 52;
            this.dateTimePickerExitTimeInd.Value = new System.DateTime(2021, 12, 21, 9, 40, 9, 0);
            this.dateTimePickerExitTimeInd.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(416, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 44);
            this.searchBtn.TabIndex = 54;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.search_Click);
            // 
            // idtTypeComb
            // 
            this.idtTypeComb.FormattingEnabled = true;
            this.idtTypeComb.Items.AddRange(new object[] {
            "group",
            "individual"});
            this.idtTypeComb.Location = new System.Drawing.Point(69, 24);
            this.idtTypeComb.Name = "idtTypeComb";
            this.idtTypeComb.Size = new System.Drawing.Size(121, 24);
            this.idtTypeComb.TabIndex = 55;
            this.idtTypeComb.Text = "choose";
            // 
            // categoryExit
            // 
            this.categoryExit.AutoSize = true;
            this.categoryExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryExit.ForeColor = System.Drawing.SystemColors.Info;
            this.categoryExit.Location = new System.Drawing.Point(416, 261);
            this.categoryExit.Name = "categoryExit";
            this.categoryExit.Size = new System.Drawing.Size(122, 20);
            this.categoryExit.TabIndex = 57;
            this.categoryExit.Text = "category type";
            this.categoryExit.Visible = false;
            // 
            // dayInd
            // 
            this.dayInd.AutoSize = true;
            this.dayInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayInd.ForeColor = System.Drawing.SystemColors.Info;
            this.dayInd.Location = new System.Drawing.Point(475, 189);
            this.dayInd.Name = "dayInd";
            this.dayInd.Size = new System.Drawing.Size(38, 20);
            this.dayInd.TabIndex = 58;
            this.dayInd.Text = "day";
            this.dayInd.Visible = false;
            // 
            // entryTimeInd
            // 
            this.entryTimeInd.AutoSize = true;
            this.entryTimeInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTimeInd.ForeColor = System.Drawing.SystemColors.Info;
            this.entryTimeInd.Location = new System.Drawing.Point(459, 115);
            this.entryTimeInd.Name = "entryTimeInd";
            this.entryTimeInd.Size = new System.Drawing.Size(93, 20);
            this.entryTimeInd.TabIndex = 59;
            this.entryTimeInd.Text = "entry time";
            this.entryTimeInd.Visible = false;
            // 
            // txtExitWeekday
            // 
            this.txtExitWeekday.Location = new System.Drawing.Point(147, 321);
            this.txtExitWeekday.Name = "txtExitWeekday";
            this.txtExitWeekday.Size = new System.Drawing.Size(100, 22);
            this.txtExitWeekday.TabIndex = 61;
            this.txtExitWeekday.Visible = false;
            // 
            // txtExitEntryTimeInd
            // 
            this.txtExitEntryTimeInd.Location = new System.Drawing.Point(602, 115);
            this.txtExitEntryTimeInd.Name = "txtExitEntryTimeInd";
            this.txtExitEntryTimeInd.Size = new System.Drawing.Size(100, 22);
            this.txtExitEntryTimeInd.TabIndex = 62;
            this.txtExitEntryTimeInd.Visible = false;
            this.txtExitEntryTimeInd.TextChanged += new System.EventHandler(this.exitEntryTime_TextChanged);
            // 
            // txtExitDayInd
            // 
            this.txtExitDayInd.Location = new System.Drawing.Point(602, 189);
            this.txtExitDayInd.Name = "txtExitDayInd";
            this.txtExitDayInd.Size = new System.Drawing.Size(100, 22);
            this.txtExitDayInd.TabIndex = 63;
            this.txtExitDayInd.Visible = false;
            // 
            // txtExitTypeInd
            // 
            this.txtExitTypeInd.Location = new System.Drawing.Point(602, 259);
            this.txtExitTypeInd.Name = "txtExitTypeInd";
            this.txtExitTypeInd.Size = new System.Drawing.Size(100, 22);
            this.txtExitTypeInd.TabIndex = 64;
            this.txtExitTypeInd.Visible = false;
            // 
            // adultGrp
            // 
            this.adultGrp.AutoSize = true;
            this.adultGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.adultGrp.Location = new System.Drawing.Point(475, 303);
            this.adultGrp.Name = "adultGrp";
            this.adultGrp.Size = new System.Drawing.Size(52, 20);
            this.adultGrp.TabIndex = 65;
            this.adultGrp.Text = "Adult";
            this.adultGrp.Visible = false;
            // 
            // childGrp
            // 
            this.childGrp.AutoSize = true;
            this.childGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.childGrp.Location = new System.Drawing.Point(475, 333);
            this.childGrp.Name = "childGrp";
            this.childGrp.Size = new System.Drawing.Size(52, 20);
            this.childGrp.TabIndex = 66;
            this.childGrp.Text = "Child";
            this.childGrp.Visible = false;
            // 
            // txtExitAdultGrp
            // 
            this.txtExitAdultGrp.Location = new System.Drawing.Point(602, 303);
            this.txtExitAdultGrp.Name = "txtExitAdultGrp";
            this.txtExitAdultGrp.Size = new System.Drawing.Size(50, 22);
            this.txtExitAdultGrp.TabIndex = 67;
            this.txtExitAdultGrp.Visible = false;
            // 
            // txtExitChildGrp
            // 
            this.txtExitChildGrp.Location = new System.Drawing.Point(602, 342);
            this.txtExitChildGrp.Name = "txtExitChildGrp";
            this.txtExitChildGrp.Size = new System.Drawing.Size(50, 22);
            this.txtExitChildGrp.TabIndex = 68;
            this.txtExitChildGrp.Visible = false;
            // 
            // dateTimePickerExitTimeGrp
            // 
            this.dateTimePickerExitTimeGrp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerExitTimeGrp.Location = new System.Drawing.Point(147, 192);
            this.dateTimePickerExitTimeGrp.Name = "dateTimePickerExitTimeGrp";
            this.dateTimePickerExitTimeGrp.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExitTimeGrp.TabIndex = 70;
            this.dateTimePickerExitTimeGrp.Value = new System.DateTime(2021, 12, 21, 9, 40, 9, 0);
            this.dateTimePickerExitTimeGrp.Visible = false;
            // 
            // exitTimeGrp
            // 
            this.exitTimeGrp.AutoSize = true;
            this.exitTimeGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitTimeGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.exitTimeGrp.Location = new System.Drawing.Point(23, 192);
            this.exitTimeGrp.Name = "exitTimeGrp";
            this.exitTimeGrp.Size = new System.Drawing.Size(89, 20);
            this.exitTimeGrp.TabIndex = 69;
            this.exitTimeGrp.Text = "Left Time";
            this.exitTimeGrp.Visible = false;
            // 
            // txtExitDuration
            // 
            this.txtExitDuration.Location = new System.Drawing.Point(147, 273);
            this.txtExitDuration.Name = "txtExitDuration";
            this.txtExitDuration.Size = new System.Drawing.Size(100, 22);
            this.txtExitDuration.TabIndex = 72;
            this.txtExitDuration.Visible = false;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.SystemColors.Info;
            this.duration.Location = new System.Drawing.Point(31, 275);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(81, 20);
            this.duration.TabIndex = 71;
            this.duration.Text = "Duration";
            this.duration.Visible = false;
            // 
            // txtEntryTimeGrp
            // 
            this.txtEntryTimeGrp.Location = new System.Drawing.Point(602, 147);
            this.txtEntryTimeGrp.Name = "txtEntryTimeGrp";
            this.txtEntryTimeGrp.Size = new System.Drawing.Size(100, 22);
            this.txtEntryTimeGrp.TabIndex = 74;
            this.txtEntryTimeGrp.Visible = false;
            // 
            // entryTimeGrp
            // 
            this.entryTimeGrp.AutoSize = true;
            this.entryTimeGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTimeGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.entryTimeGrp.Location = new System.Drawing.Point(459, 147);
            this.entryTimeGrp.Name = "entryTimeGrp";
            this.entryTimeGrp.Size = new System.Drawing.Size(93, 20);
            this.entryTimeGrp.TabIndex = 73;
            this.entryTimeGrp.Text = "entry time";
            this.entryTimeGrp.Visible = false;
            // 
            // txtExitDayGrp
            // 
            this.txtExitDayGrp.Location = new System.Drawing.Point(602, 219);
            this.txtExitDayGrp.Name = "txtExitDayGrp";
            this.txtExitDayGrp.Size = new System.Drawing.Size(100, 22);
            this.txtExitDayGrp.TabIndex = 76;
            this.txtExitDayGrp.Visible = false;
            // 
            // dayGrp
            // 
            this.dayGrp.AutoSize = true;
            this.dayGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.dayGrp.Location = new System.Drawing.Point(475, 219);
            this.dayGrp.Name = "dayGrp";
            this.dayGrp.Size = new System.Drawing.Size(38, 20);
            this.dayGrp.TabIndex = 75;
            this.dayGrp.Text = "day";
            this.dayGrp.Visible = false;
            // 
            // txtExitPrice
            // 
            this.txtExitPrice.Location = new System.Drawing.Point(147, 360);
            this.txtExitPrice.Name = "txtExitPrice";
            this.txtExitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtExitPrice.TabIndex = 78;
            this.txtExitPrice.Visible = false;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.SystemColors.Info;
            this.payment.Location = new System.Drawing.Point(23, 360);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(81, 20);
            this.payment.TabIndex = 77;
            this.payment.Text = "Payment";
            this.payment.Visible = false;
            // 
            // lableIdGrp
            // 
            this.lableIdGrp.AutoSize = true;
            this.lableIdGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdGrp.ForeColor = System.Drawing.SystemColors.Info;
            this.lableIdGrp.Location = new System.Drawing.Point(31, 105);
            this.lableIdGrp.Name = "lableIdGrp";
            this.lableIdGrp.Size = new System.Drawing.Size(85, 20);
            this.lableIdGrp.TabIndex = 79;
            this.lableIdGrp.Text = "Group ID";
            // 
            // labelIdInd
            // 
            this.labelIdInd.AutoSize = true;
            this.labelIdInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdInd.ForeColor = System.Drawing.SystemColors.Info;
            this.labelIdInd.Location = new System.Drawing.Point(31, 70);
            this.labelIdInd.Name = "labelIdInd";
            this.labelIdInd.Size = new System.Drawing.Size(109, 20);
            this.labelIdInd.TabIndex = 81;
            this.labelIdInd.Text = "Individual Id";
            // 
            // txtIdInd
            // 
            this.txtIdInd.Location = new System.Drawing.Point(210, 70);
            this.txtIdInd.Name = "txtIdInd";
            this.txtIdInd.Size = new System.Drawing.Size(100, 22);
            this.txtIdInd.TabIndex = 80;
            this.txtIdInd.TextChanged += new System.EventHandler(this.txtIdInd_TextChanged);
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.ForeColor = System.Drawing.SystemColors.Info;
            this.weekday.Location = new System.Drawing.Point(23, 323);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(80, 20);
            this.weekday.TabIndex = 30;
            this.weekday.Text = "weekday";
            this.weekday.Visible = false;
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIdInd);
            this.Controls.Add(this.txtIdInd);
            this.Controls.Add(this.lableIdGrp);
            this.Controls.Add(this.txtExitPrice);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.txtExitDayGrp);
            this.Controls.Add(this.dayGrp);
            this.Controls.Add(this.txtEntryTimeGrp);
            this.Controls.Add(this.entryTimeGrp);
            this.Controls.Add(this.txtExitDuration);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.dateTimePickerExitTimeGrp);
            this.Controls.Add(this.exitTimeGrp);
            this.Controls.Add(this.txtExitChildGrp);
            this.Controls.Add(this.txtExitAdultGrp);
            this.Controls.Add(this.childGrp);
            this.Controls.Add(this.adultGrp);
            this.Controls.Add(this.txtExitTypeInd);
            this.Controls.Add(this.txtExitDayInd);
            this.Controls.Add(this.txtExitEntryTimeInd);
            this.Controls.Add(this.txtExitWeekday);
            this.Controls.Add(this.entryTimeInd);
            this.Controls.Add(this.dayInd);
            this.Controls.Add(this.categoryExit);
            this.Controls.Add(this.idtTypeComb);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dateTimePickerExitTimeInd);
            this.Controls.Add(this.txtIdGrp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.leftTimeInd);
            this.Name = "Exit";
            this.Text = "Exit";
            this.Load += new System.EventHandler(this.Exit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label leftTimeInd;
        private System.Windows.Forms.TextBox txtIdGrp;
        private System.Windows.Forms.DateTimePicker dateTimePickerExitTimeInd;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox idtTypeComb;
        private System.Windows.Forms.Label categoryExit;
        private System.Windows.Forms.Label dayInd;
        private System.Windows.Forms.Label entryTimeInd;
        private System.Windows.Forms.TextBox txtExitWeekday;
        private System.Windows.Forms.TextBox txtExitEntryTimeInd;
        private System.Windows.Forms.TextBox txtExitDayInd;
        private System.Windows.Forms.TextBox txtExitTypeInd;
        private System.Windows.Forms.Label adultGrp;
        private System.Windows.Forms.Label childGrp;
        private System.Windows.Forms.TextBox txtExitAdultGrp;
        private System.Windows.Forms.TextBox txtExitChildGrp;
        private System.Windows.Forms.DateTimePicker dateTimePickerExitTimeGrp;
        private System.Windows.Forms.Label exitTimeGrp;
        private System.Windows.Forms.TextBox txtExitDuration;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.TextBox txtEntryTimeGrp;
        private System.Windows.Forms.Label entryTimeGrp;
        private System.Windows.Forms.TextBox txtExitDayGrp;
        private System.Windows.Forms.Label dayGrp;
        private System.Windows.Forms.TextBox txtExitPrice;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label lableIdGrp;
        private System.Windows.Forms.Label labelIdInd;
        private System.Windows.Forms.TextBox txtIdInd;
        private System.Windows.Forms.Label weekday;
    }
}