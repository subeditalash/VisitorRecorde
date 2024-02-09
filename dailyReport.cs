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
    public partial class dailyReport : Form
    {
        public dailyReport()
        {
            InitializeComponent();
        }
        private Customer _customer = new Customer();

        private List<Customer> customerList = new List<Customer>();
        private void DailyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dailyReport_Load(object sender, EventArgs e)
        {
            customerList = _customer.GetReportData();
            FillChart();
            dateToday.Text = DateTime.Now.ToLongDateString();
        }
        private void FillChart()
        {
            foreach (var cus in customerList)
            {
                var a = cus.day.DayOfWeek.ToString();
                var b = cus.duration.ToString();
                var c = cus.count.ToString();
                var d = cus.Cost.ToString();

                this.DailyDataGrid.Rows.Add(a, c, b,d);
            }
        }

    }
}
