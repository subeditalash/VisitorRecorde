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
    public partial class chart : Form
    {
        public chart()
        {
            InitializeComponent();
        }
        private Customer _customer = new Customer();

        private List<Customer> customerList = new List<Customer>();

        private void chart_Load(object sender, EventArgs e)
        {
            LoadVisit();
            FillChart();
        }
        private void LoadVisit()
        {
            customerList = _customer.GetWeeksData();
        }
        private void FillChart()
        {
            foreach (var cus in customerList)
            {
                //show the chart on x and y as week and cost
                chartReport.Series["Customer"].Points.AddXY(cus.day.DayOfWeek.ToString(),cus.Cost.ToString());
            }
            chartReport.Titles.Add("Total Customer in Minutes and cost");
        }
    }
}
