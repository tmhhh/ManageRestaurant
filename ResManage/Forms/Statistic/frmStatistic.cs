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

namespace ResManage.Forms.Statistic
{
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }
        string pickedTime = "";
        string foodName = "";
        void drawChart(int n)
        {
            for (int i = 0; i < n; i++)
            {
                pickedTime = gvResult.Rows[i].Cells[0].Value?.ToString();
                foodName = gvResult.Rows[i].Cells[1].Value?.ToString();
                chartFavorite.Series["favorite"].Points.AddXY(foodName + " " + pickedTime, pickedTime);
            }
        }
        void resetChart()
        {
            foreach(var serie in chartFavorite.Series)
            {
                serie.Points.Clear();
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rdByDay.Checked)
            {
                gvResult.DataSource=billInfoDB.getFavoriteDishInDay(dtDate.Value);
                resetChart();
                drawChart(gvResult.RowCount);
            }
            else if (rdByMonth.Checked)
            {
                gvResult.DataSource = billInfoDB.getFavoriteDishInMonth(dtDate.Value);
                resetChart();
                drawChart(gvResult.RowCount);
            }
            else
            {
                MessageBox.Show("Please choose your option !!!");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard frm = new dashboard();
            frm.Show();
        }
    }
}
