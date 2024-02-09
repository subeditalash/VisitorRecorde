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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            GloabalValues.RateList = new List<RateList>();
            string filepath = "C:\\CSV\\RateLists.csv";
            string[] records = File.ReadAllLines(filepath);
            foreach (string r in records)
            {
                string[] st = r.Split(',');
                if (st.Length == 5)
                {

                    RateList rl = new RateList();
                    rl.TicketRate = st[0];
                    rl.Child = st[1];
                    rl.Adult = st[2];
                    rl.GroupOfFive = st[3];
                    rl.GroupOfTen = st[4];
                    GloabalValues.RateList.Add(rl);
                }
            }
            ticketGridView.DataSource = GloabalValues.RateList;
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Show individual form
            Individual sView = new Individual();
            sView.Show();

        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show group form
            Group sView = new Group();
            sView.Show();
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            weeklyReport sView = new weeklyReport();
            sView.Show();
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dailyReport sView = new dailyReport();
            sView.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit sView = new Exit();
            sView.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart sView = new chart();
            sView.Show();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails sView = new CustomerDetails();
            sView.Show();
        }

        private void ticketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
