using ResManage.DAO;
using ResManage.Forms.Manager;

using ResManage.Model;
using RestaurantManagement.DAO;
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
    public partial class frmSchedule : Form
    {


        public frmSchedule()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int totalEmploy = UsersDB.TotalUser();
            txbTotalEmp.Text = totalEmploy.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int temp = 0;
            DataTable dt = UsersDB.getListUser();
            int[] listEmpID = new int[dt.Rows.Count];
            int empPerShift = Convert.ToInt32(txbNumber.Text);
            foreach (DataRow dr in dt.Rows)
            {
                listEmpID[temp] = (Convert.ToInt32(dr["userID"]));
                temp++;
            }
            if (empPerShift > listEmpID.Length)
            {
                MessageBox.Show("Quantity Error !!!");
                return;
            }
            List<Working> listWorking = new List<Working>();
            int shift = 1;
            TimeSpan span = dtTo.Value.Subtract(dtFrom.Value);
            //int timeSpan = dtTo.Value.Day - dtFrom.Value.Day;
            double totalTime = Convert.ToInt32(span.TotalDays * 24);
            double workingHourPerDay = 8;
            double numberShiftPerWeek = (totalTime / listEmpID.Length / workingHourPerDay) * empPerShift;
            txbTotalTime.Text = numberShiftPerWeek.ToString() + "h";
            for (int i = 1; i <= Convert.ToInt32(span.TotalDays); i++)
            {
                while (shift <= 3)
                {
                    for (int j = 0; j < empPerShift; j++)
                    {
                        Working w = new Working() { Shift = shift, WorkingDate = dtFrom.Value.AddDays(i) };

                        listWorking.Add(w);
                    }
                    shift++;
                }

                shift = 1;
            }
            if (scheduleDB.insertWorking(ScheduleArrange(listWorking, listEmpID)))
            {
                MessageBox.Show("Suuccess");
                //DrawBoard(listWorking, 1);
            }
            else
                MessageBox.Show("aiill");

        }
        //public bool checkExist(List<Working> listWorking, int empID ,Working current)
        //{
        //    if (Convert.ToInt32(txbNumber.Text) == 1) return false;
        //    foreach(Working w in listWorking)
        //    {
        //        if (w.WorkingDate == current.WorkingDate && w.Shift==current.Shift)
        //        {
        //            if(w.UserID== empID)
        //            {
        //               z
        //            }
        //        }
        //    }
        //    return false;
        //}
        public List<Working> ScheduleArrange(List<Working> listWorking, int[] listUserID)
        {
            //int max = listUserID.Count;
            //Random rd = new Random();
            //List<int> restrict = new List<int>() {-1};
            //for(int i=0;i<listWorking.Count;i++)
            //{

            //    int no = rd.Next(0, max);  
            //    if(!restrict.Contains(no) && !checkExist(listWorking, listUserID.ElementAt(no).UserID, listWorking.ElementAt(i)))
            //    {
            //        if (listUserID.ElementAt(no).ChoosenTime < numberShiftPerWeek)
            //        {
            //            listWorking.ElementAt(i).UserID = listUserID.ElementAt(no).UserID;
            //            listUserID.ElementAt(no).ChoosenTime++;
            //        }
            //        else
            //        {
            //            restrict.Add(no);
            //            i--;
            //        }
            //    }
            //    else
            //    {
            //        i--;
            //    }



            //}
            int temp = 0;
            Shuffle(listUserID);
            for (int i = 0; i < listWorking.Count; i++)
            {
                if (listWorking.ElementAt(i).UserID == 0)
                {
                    if (temp < listUserID.Length)
                    {
                        listWorking.ElementAt(i).UserID = listUserID.ElementAt(temp);
                        if (i + Convert.ToInt32(txbNumber.Text) < listWorking.Count)
                            listWorking.ElementAt(i + Convert.ToInt32(txbNumber.Text)).UserID = listUserID.ElementAt(temp);
                        temp++;
                    }
                    else
                    {
                        temp = 0;
                        i--;
                    }
                }


            }

            return listWorking;
        }
        public void Shuffle(int[] listUserID)
        {
            Random rd = new Random();
            for (var i = listUserID.Length; i > 0; i--)
                Swap(listUserID, 0, rd.Next(0, i));
        }
        public void Swap(int[] listUserID, int i, int j)
        {
            int temp = listUserID.ElementAt(i);
            listUserID[i] = listUserID.ElementAt(j);
            listUserID[j] = temp;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            frmSheduleDrawing frm = new frmSheduleDrawing();
            frm.Show();
        }

        private void btnFullSchedule_Click(object sender, EventArgs e)
        {
            gvSchedule.DataSource = scheduleDB.getListSchedule();
        }

        
    }
}
