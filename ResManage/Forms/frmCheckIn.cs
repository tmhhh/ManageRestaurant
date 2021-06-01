using ResManage.DAO;
using ResManage.Forms.UserInfo;
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
        int shift = 0;
        public frmCheckIn()
        {
            InitializeComponent();
           
            lbName.Text = "Welcome "+ globalUser.currentUser.UserName;
            pbImage.Image = Image.FromStream(globalUser.currentUser.UserAvatar);
        }
       

        private void btnCheckIn_Click_1(object sender, EventArgs e)
        {
            checkinTime = DateTime.Now;
            
            if (workingDB.checkIn(globalUser.currentUser.UserID, checkinTime,shift))
            {
                MessageBox.Show("CheckIn Successfully !!!");
            }
            else
            {
                MessageBox.Show("Something wrong !!!");

            }
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
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

        private void btnWaveCalculate_Click_1(object sender, EventArgs e)
        {
        
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserOption frm = new frmUserOption();
            frm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
