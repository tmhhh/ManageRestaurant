using ResManage.DAO;
using ResManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms.ReportStat
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<double> sWorkingTime = new List<double>();
            List<double> rWorkingTime = new List<double>();
            List<double> totalSalary = new List<double>();

            DataTable dt = workingDB.standardWorkingTime(dtFrom.Value, dtTo.Value);
            foreach (DataRow dr in dt.Rows)
            {
                sWorkingTime.Add(Convert.ToDouble(dr["sWorkingTime"]));
            }
            dt = workingDB.workingTime(dtFrom.Value, dtTo.Value);
            foreach (DataRow dr in dt.Rows)
            {
                rWorkingTime.Add(Convert.ToDouble(dr["TotalTime"]));
            }
            for (int i = 0; i < rWorkingTime.Count; i++)
            {
                double tmp = rWorkingTime.ElementAt(i) - sWorkingTime.ElementAt(i);
                if (tmp < 0)
                {
                    totalSalary.Add(rWorkingTime.ElementAt(i) * 50 - 100 * Math.Abs(tmp));
                }
                else
                {
                    totalSalary.Add(sWorkingTime.ElementAt(i) * 50 + 100 * Math.Abs(tmp));
                }
            }
            DataTable ttSalary = new DataTable();
            ttSalary.Columns.Add("User ID");
            ttSalary.Columns.Add("Total Salary");
            for (int i = 0; i < totalSalary.Count; i++)
            {
                ttSalary.Rows.Add(new object[] { i + 1, totalSalary.ElementAt(i) });
            }

            gvSalary.DataSource = ttSalary;
        }

        private void btnDailySalary_Click(object sender, EventArgs e)
        {
            DateTime t = DateTime.Parse("21:30:00");
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToLongTimeString());
            if (DateTime.Compare(currentTime, t) >= 0 && globalUser.currentUser.UserType == 1)
            {
                gvDailyWave.DataSource = dailyWaveDB.waveCalculate();
            }
            else
            {
                MessageBox.Show("This action is not available now !!!");
            }

        }
    }
}
