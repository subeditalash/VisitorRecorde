using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace applicationDevelopmentCW1
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        string filePath = "GroupLists.csv";
        
        public void AddGrpCustomerToCsv(int GroupID, TimeSpan entryTime, DateTime day, int Adult,int Child)
        {
            string newInd = "\n" + GroupID + "," + entryTime + "," + day + "," + Adult+","+Child;
            File.AppendAllText(filePath, newInd);
        }


       

        private void Group_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(filePath);
            var count = lines.Length;
            GrpID.Value = count++;
            dateTimePickerEntryTime.Value = (DateTime.Now);
            dateTimePickerEntryDay.Value = (DateTime.Now);

            string[] group = File.ReadAllLines(filePath);
            foreach (string Grp in group)
            {
                string[] st = Grp.Split(',');
                if (st.Length == 5)
                {
                    GroupCustomer gc = new GroupCustomer();
                    gc.GroupID = Convert.ToInt32(st[0]);
                    gc.entryTime = TimeSpan.Parse(st[1]);
                    gc.day = Convert.ToDateTime(st[2]);
                    gc.Adult = Convert.ToInt32(st[3]);
                    gc.Child = Convert.ToInt32(st[4]);
                    

                    GroupCustomer.GroupCustomerList.Add(gc);


                }
            }
            dataGridView2.DataSource = GroupCustomer.GroupCustomerList;


        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            var Grp = new GroupCustomer();
            Grp.GroupID = Grp.GetGroupId();
            Grp.entryTime = dateTimePickerEntryTime.Value.TimeOfDay;
            Grp.day = dateTimePickerEntryDay.Value.Date;

            Grp.Adult = ((int)CountAdult.Value);
            Grp.Child = ((int)CountChild.Value);

            GroupCustomer.GroupCustomerList.Add(Grp);

            MessageBox.Show("Saved Success!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView2.DataSource = GroupCustomer.GroupCustomerList;
            AddGrpCustomerToCsv(Grp.GroupID, Grp.entryTime, Grp.day, Grp.Adult, Grp.Child);
            if ((Grp.Adult + Grp.Child) < 5)
            {
                MessageBox.Show("Not enough number!!!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        private void dateTimePickerEntryTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var i = dateTimePickerEntryTime.Value.Hour;
                if ((i < 10) || (i > 16))
                {
                    MessageBox.Show("Sorry, can't select the time recreation centre is closed..");

                    if (i < 10)
                    {
                        this.dateTimePickerEntryTime.Value = DateTime.Parse("10:00:00");

                    }
                    else if (i > 18)
                    {
                        this.dateTimePickerEntryTime.Value = DateTime.Parse("17:59:00");
                    }
                    else
                    {
                        this.dateTimePickerEntryTime.Value = DateTime.Now;
                    }
                    return;
                }
            }
            catch
            {
                
            }
        }

    }
}
