using ResManage.DAO;
using ResManage.Forms.Foods;
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
    public partial class frmMain : Form
    {
        public int TableWidth = 80;
        public int TableHeight = 80;
 
        public frmMain()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<Table> tableList = tableDB.getListTable();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableHeight };
                btn.Text = "Table "+item.TableID.ToString()+ "\n" ;

                switch (item.TableStatus)
                {
                    case 0:
                        btn.BackColor = Color.Aqua;
                        btn.Text += "Empty";
                        break;
                    default:
                        btn.BackColor = Color.DarkRed;
                        btn.Text += "Exits";
                        break;
                }

                flpnMain.Controls.Add(btn);
            }
        }

        private void staffCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckIn frm = new frmCheckIn();
            frm.Show();
        }

        private void arrangeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchedule frm = new frmSchedule();
            frm.Show();
        }
    }
}
