using ResManage.Forms.ReportStat;
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

namespace ResManage.Forms.UserInfo
{
    public partial class frmUserOption : Form
    {
        public frmUserOption()
        {
            InitializeComponent();
        }

        private void frmUserOption_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frm = new frmCheckIn();
            this.Hide();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personalpage frm = new personalpage();
            this.Hide();
            frm.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
 
            if ( globalUser.currentUser.UserType==1)
            {
                frmSalary frm = new frmSalary();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not allow to use this action !!!");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard frm = new dashboard();
            frm.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
