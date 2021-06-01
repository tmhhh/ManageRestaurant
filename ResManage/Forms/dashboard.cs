using ResManage.Forms.Foods;
using ResManage.Forms.ReportStat;
using ResManage.Forms.Statistic;
using ResManage.Forms.UserInfo;
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

namespace ResManage.Forms
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            frmMain resFrm = new frmMain();
            this.Hide();
            resFrm.Show();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            frmUserOption ppfrm = new frmUserOption();
            this.Hide();
            ppfrm.Show();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoodMan_Click(object sender, EventArgs e)
        {
            frmAddFood afoodFrm = new frmAddFood();
            this.Hide();
            afoodFrm.Show();
        }

        private void btnFoodM_Click(object sender, EventArgs e)
        {
       
            frmStatistic frm = new frmStatistic();
            this.Hide();
            frm.Show();

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Revenue revenueFrm = new Revenue();
            this.Hide();
            revenueFrm.Show();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            if (globalUser.currentUser.UserType == 1)
            {
                this.Hide();
                frmSchedule scheduleFrm = new frmSchedule();
                scheduleFrm.Show();
            }
            else
            {
                MessageBox.Show("You are not allow to use this !!!");
            }
        }
    }
}
