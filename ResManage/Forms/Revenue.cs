using ResManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }
        void loadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvRevenue.DataSource = billDB.getBillByDate(checkIn, checkOut);
        }
        double calculateRevenue()
        {
            double total = 0;
            for (int i = 0; i < dgvRevenue.Rows.Count; i++)
            {

                total += (double)dgvRevenue.Rows[i].Cells[4].Value;
            }
            return total;
        }
        void drawChart()
        {
            string month = dateTimePickerTo.Value.Month.ToString();
            string monnthRevenue = calculateRevenue().ToString();
            chartRev.Series["revenue"].Points.AddXY(month + " " + monnthRevenue, monnthRevenue);
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            DateTime checkin = dateTimePickerFrom.Value;
            DateTime checkout = dateTimePickerTo.Value;
            loadListBillByDate(checkin,checkout);
            textBoxRevenue.Text = calculateRevenue().ToString("c");
            drawChart();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboardFrm = new dashboard();
            dashboardFrm.Show();
        }
    }
}
