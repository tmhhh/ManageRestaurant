using ResManage.Model;
using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.DAO
{
    class scheduleDB
    {
        public static DataTable getListSchedule()
        {

            string query = "Select w.userID,userName,w.workingShift,w.workingDate from Schedule w,Users u where w.userID=u.userID order by 1";
            return MyDB.ExecuteQuery(query);
        }
        public static bool insertWorking(List<Working> listWorking)
        {


            foreach (Working w in listWorking)
            {
                string query = "Insert into Schedule values(" + w.UserID + ",'" + w.WorkingDate + "'," + w.Shift + ")";
            
                MyDB.ExecuteNonQuery(query);
                //}
                //catch 
                //{
                //    return false;
                //}
            }
            return true;

        }
        public static List<Working> getListSheduleByUserID(int userID)
        {
            List<Working> listWorking = new List<Working>();
            string query = "Select * from Schedule where userID=" + userID.ToString();
            DataTable dt = MyDB.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Working w = new Working();
                w.Shift = Convert.ToInt32(dr["workingShift"]);
                w.UserID = Convert.ToInt32(dr["userID"]);
                w.WorkingDate = Convert.ToDateTime(dr["workingDate"]);
                listWorking.Add(w);
            }
            return listWorking;
        }
    }
}
