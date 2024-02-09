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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }
        string filePath1 = "individualLists.csv";
        string filePath2 = "GroupLists.csv";
        string filePath3 = "customerLists.csv";
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (idtTypeComb.SelectedItem.ToString() == "individual")
                {
                    // Visible if its individual
                    labelIdInd.Visible = true;
                    entryTimeInd.Visible = true;
                    dayInd.Visible = true;
                    entryTimeInd.Visible = true;
                    duration.Visible = true;
                    weekday.Visible = true;
                    categoryExit.Visible = true;
                    payment.Visible = true;
                    leftTimeInd.Visible = true;

                    txtExitDayInd.Visible = true;
                    txtExitEntryTimeInd.Visible = true;
                    txtExitWeekday.Visible = true;
                    txtExitDuration.Visible = true;
                    txtExitWeekday.Visible = true;
                    dateTimePickerExitTimeInd.Visible = true;
                    txtIdInd.Visible = true;
                    txtExitPrice.Visible = true;
                    txtExitTypeInd.Visible = true;
                    try
                    {
                        bool found = false;



                        string[] individual = File.ReadAllLines(filePath1);
                        foreach (string ind in individual)
                        {
                            string[] st = ind.Split(',');
                            if (txtIdInd.Text == st[0])
                            {
                                txtIdInd.Text = st[0];
                                txtExitEntryTimeInd.Text = st[1];
                                txtExitTypeInd.Text = st[3];
                                txtExitDayInd.Text = st[2];
                                dateTimePickerExitTimeInd.Value = (DateTime.Now);




                                var c = new Customer();

                                c.IndividualID = Convert.ToInt32(txtIdInd.Text);

                                c.entryTime = Convert.ToDateTime(txtExitEntryTimeInd.Text).TimeOfDay;
                                c.exitTime = dateTimePickerExitTimeInd.Value.TimeOfDay;

                                c.duration = c.CalculateDuration();
                                c.day = Convert.ToDateTime(txtExitDayInd.Text);


                                c.weekday = c.GetDay();
                                c.Cost = c.GetCost();

                                c.type = txtExitTypeInd.Text;
                                Customer.customerList.Add(c);
                                txtExitDuration.Text = Convert.ToString(c.CalculateDuration());
                                txtExitWeekday.Text = c.GetDay();
                                txtExitPrice.Text = Convert.ToString(c.GetCost());
                                AddCustomerToCsv(c.GroupID, c.IndividualID, c.entryTime, c.exitTime, c.duration, c.day, c.Adult, c.Child, c.weekday, c.Cost, c.count, c.type);

                                found = true;
                                break;


                            }

                        }
                        if (found == false)
                        {
                            MessageBox.Show("No Customer with this id");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("");
                    }

                }








                else if (idtTypeComb.SelectedItem.ToString() == "group")
                {
                    try
                    {
                        //visible if its group
                        lableIdGrp.Visible = true;
                        entryTimeGrp.Visible = true;
                        dayGrp.Visible = true;
                        entryTimeGrp.Visible = true;
                        duration.Visible = true;
                        payment.Visible = true;
                        childGrp.Visible = true;
                        adultGrp.Visible = true;
                        weekday.Visible = true;
                        exitTimeGrp.Visible = true;

                        txtExitDayGrp.Visible = true;
                        txtEntryTimeGrp.Visible = true;
                        txtExitPrice.Visible = true;
                        txtExitDuration.Visible = true;
                        txtExitAdultGrp.Visible = true;
                        dateTimePickerExitTimeGrp.Visible = true;
                        txtIdGrp.Visible = true;
                        txtExitWeekday.Visible = true;
                        txtExitChildGrp.Visible = true;




                        bool foundGroup = false;



                        string[] group = File.ReadAllLines(filePath2);
                        foreach (string grp in group)
                        {
                            string[] st = grp.Split(',');
                            if (txtIdGrp.Text == st[0])
                            {
                                txtEntryTimeGrp.Text = st[1];
                                txtExitDayGrp.Text = st[2];
                                txtExitAdultGrp.Text = st[3];
                                txtExitChildGrp.Text = st[4];
                                dateTimePickerExitTimeGrp.Value = (DateTime.Now);



                                //putting value on customer list
                                var c = new Customer();
                                c.GroupID = Convert.ToInt32(txtIdGrp.Text);
                                c.entryTime = Convert.ToDateTime(txtEntryTimeGrp.Text).TimeOfDay;
                                c.exitTime = dateTimePickerExitTimeGrp.Value.TimeOfDay;
                                c.day = Convert.ToDateTime(txtExitDayGrp.Text);
                                c.Adult = Convert.ToInt32(txtExitAdultGrp.Text);
                                c.Child = Convert.ToInt32(txtExitChildGrp.Text);
                                c.count = c.GetCount();
                                c.duration = c.CalculateDuration();
                                c.day = Convert.ToDateTime(txtExitDayGrp.Text);

                                c.weekday = c.GetDay();
                                c.Cost = c.GetCost();
                                Customer.customerList.Add(c);
                                ///show value in textbox of duration and weekday and price
                                txtExitDuration.Text = Convert.ToString(c.CalculateDuration());
                                txtExitWeekday.Text = c.GetDay();
                                txtExitPrice.Text = Convert.ToString(c.GetCost());
                                AddCustomerToCsv(c.GroupID, c.IndividualID, c.entryTime, c.exitTime, c.duration, c.day, c.Adult, c.Child, c.weekday, c.Cost, c.count, c.type);

                                foundGroup = true;
                                break;
                            }
                        }
                        if (foundGroup == false)
                        {
                            MessageBox.Show("No Customer with this id");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("check the data");
                    }






                }
                else
                {
                    MessageBox.Show("Please select items!!!", "select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("enter the id");
            }





        }


        private void AddCustomerToCsv(int GroupID, int IndividualID, TimeSpan entryTime, TimeSpan exitTime, double duration, DateTime day, int adult, int child, string weekday, int cost, int count, string type)
        {
            string newC = "\n" + IndividualID + "," + GroupID + ", " + entryTime + "," + day + "," + type + "," + exitTime + "," + duration + "," + weekday + "," + cost + "," + child + "," + adult + "," + count;
            File.AppendAllText(filePath3, newC);
        }

        private void exitEntryTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();



        }

        private void txtIdInd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

