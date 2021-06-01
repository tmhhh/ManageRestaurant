using ResManage.Model;
using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.DAO
{
    static class workingDB
    {
        public static DataTable getListWorking()
        {

            string query = "Select w.userID,userName,w.workingShift,w.workingDate from Working w,Users u where w.userID=u.userID order by 1";
            return MyDB.ExecuteQuery(query);
        }
        public static DataTable standardWorkingTime(DateTime from, DateTime to)
        {
            string sql = "select count(*)*8 as sWorkingTime,userID from Working where workingDate BETWEEN '" + from + "' AND '" + to + "' group by userID";
            return MyDB.ExecuteQuery(sql);


        }
        public static DataTable workingTime(DateTime from, DateTime to)
        {
            string sql = "select sum(totalWorkingTime) as TotalTime ,userID from DailyWage where wageDate BETWEEN '" + from + "' AND '" + to + "' group by userID";
            return MyDB.ExecuteQuery(sql);


        }
        public static List<Working> getListWorkingByUserID(int userID)
        {
            List<Working> listWorking = new List<Working>();
            string query = "Select * from Working where userID=" + userID.ToString();
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
        public static bool insertWorking(List<Working> listWorking)
        {


            foreach (Working w in listWorking)
            {
                string query = "Insert into Working values(" + w.UserID + ",default,default,default,'" + w.WorkingDate + "','" + w.Shift + "')";
                //try
                //{
                //    
                MyDB.ExecuteNonQuery(query);
                //}
                //catch 
                //{
                //    return false;
                //}
            }
            return true;

        }
        public static bool checkIn(int userID, DateTime CheckIn, int shift)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Working values(@userID,@CheckIn,default,default,default,@shift) ", MyDB.getConnection());
            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
            cmd.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;
            cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

            MyDB.openConnection();
            if (cmd.ExecuteNonQuery() != 0)
            {
                MyDB.closeConnection();
                return true;
            }
            else
            {
                MyDB.closeConnection();
                return false;
            }
        }



        public static bool checkOut(int userID, DateTime CheckIn, DateTime CheckOut)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Working set workingCheckOut = @CheckOut where workingCheckIn = @CheckIn and userID = @userID", MyDB.getConnection());
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                cmd.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = CheckOut;
                cmd.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = CheckIn;

                MyDB.openConnection();
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MyDB.closeConnection();
                    return true;
                }
                else
                {
                    MyDB.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                MyDB.closeConnection();
                return false;
            }

        }

    }
}
