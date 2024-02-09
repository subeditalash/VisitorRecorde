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
    public partial class Individual : Form
    {
        

        public Individual()
        {
            InitializeComponent();
        }
        string filePath = "individualLists.csv";
        private void Individual_Load(object sender, EventArgs e)
        {
            dateTimePickerEntryTime.Value = (DateTime.Now);
            dateTimePickerEntryDay.Value = (DateTime.Now);
            var lines = File.ReadAllLines(filePath);
            var count = lines.Length;
            IndID.Value=count++;

            string[] individual = File.ReadAllLines(filePath);
            foreach (string ind in individual)
            {
                string[] st = ind.Split(',');
                if (st.Length == 4)
                {
                    IndividualCustomer ic = new IndividualCustomer();
                    ic.IndividualID = Convert.ToInt32(st[0]);
                    ic.entryTime = Convert.ToDateTime(st[1]).TimeOfDay;
                    ic.day = Convert.ToDateTime(st[2]);
                    ic.type = st[3];
                   
                    IndividualCustomer.IndividualCustomerList.Add(ic);
                   

                }
                
            }
          
            


        }

      

       
        public  void AddIndCustomerToCsv(int IndividualID, TimeSpan entryTime, DateTime day, string type)
        {
            string newInd = "\n" + IndividualID + "," + entryTime + "," + day + "," + type;
            File.AppendAllText(filePath, newInd);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Ind = new IndividualCustomer();
                Ind.IndividualID = Ind.GetIndividualID();
                Ind.entryTime = dateTimePickerEntryTime.Value.TimeOfDay;
                Ind.day = dateTimePickerEntryDay.Value.Date;

                Ind.type = comboBoxSelectType.SelectedItem.ToString();
                IndividualCustomer.IndividualCustomerList.Add(Ind);

                MessageBox.Show("Saved Success!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = IndividualCustomer.IndividualCustomerList;
                AddIndCustomerToCsv(Ind.IndividualID, Ind.entryTime, Ind.day, Ind.type);
            }
            catch
            {
                MessageBox.Show("invalid input");
            }

        }
        //its open from 10:00 am to 6:00 pm
        private void dateTimePickerEntryTime_ValueChanged(object sender, EventArgs e)
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


        //its open from 10:00 am to 6:00 pm

    }
}
