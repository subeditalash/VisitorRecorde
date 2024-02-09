using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicationDevelopmentCW1
{
    public partial class weeklyReport : Form
    {
        public weeklyReport()
        {
            InitializeComponent();
        }
        private Customer _customer = new Customer();

        private List<Customer> customerList = new List<Customer>();
        private void FillChart()
        {
            //get all data, loop and add them in the grid view
            foreach (var cos in customerList)
            {
                var a = cos.day.DayOfWeek.ToString();
                var b = cos.duration.ToString();
                var c = cos.count.ToString();
                var d = cos.Cost.ToString();
                this.WeeklyDataGridView.Rows.Add(a, c,b,d);
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            //sort the data
            this.WeeklyDataGridView.Sort(this.WeeklyDataGridView.Columns["Customer"], ListSortDirection.Ascending);
        }

        private void WeeklyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void weeklyReport_Load(object sender, EventArgs e)
        {
            customerList = _customer.GetWeeksData();
            FillChart();
        }
    }
}
