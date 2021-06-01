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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rdByDay.Checked)
            {
                gvResult.DataSource=billInfoDB.getFavoriteDishInDay(dtDate.Value);
            }
            else if (rdByMonth.Checked)
            {
                gvResult.DataSource = billInfoDB.getFavoriteDishInMonth(dtDate.Value);

            }
            else
            {
                MessageBox.Show("Please choose your option !!!");
            }
        }
    }
}
