using ResManage.DAO;
using ResManage.Model;
using RestaurantManagement.Model;
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
    public partial class frmCheckIn : Form
    {
        DateTime checkinTime = new DateTime();

        public frmCheckIn()
        {
            InitializeComponent();
           
            lbName.Text = globalUser.currentUser.UserName;
        }
       

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            checkinTime = DateTime.Now;
            if (workingDB.checkIn(globalUser.currentUser.UserID, checkinTime))
            {
                MessageBox.Show("CheckIn Successfully !!!");
            }
            else
            {
                MessageBox.Show("Something wrong !!!");

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime checkoutTime = DateTime.Now;
            if (workingDB.checkOut(globalUser.currentUser.UserID, checkinTime, checkoutTime))
            {
                MessageBox.Show("CheckOut Successfully !!!");

            }
            else
            {
                MessageBox.Show("Something wrong !!!");

            }
        }

        private void btnWaveCalculate_Click(object sender, EventArgs e)
        {
            if (true)
            {
                gvDailyWave.DataSource = dailyWaveDB.waveCalculate();
            }
        }
    }
}
