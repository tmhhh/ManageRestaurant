using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAO
{
    static class UsersDB
    {
        public static bool logIn(string userNameID, string userPassword)
        {
            try
            {
                MyDB.openConnection();
                SqlCommand sql = new SqlCommand("Select count(*) from Users where userNameID ='" + userNameID + "' AND userPassword='" + userPassword + "'", 
                    MyDB.getConnection());
                //SqlCommand sql = new SqlCommand("Select count(*) from Users where userNameID =@usernameID and userPassword=@userPassword", MyDB.getConnection());
                //sql.Parameters.Add("@userNameID", SqlDbType.VarChar).Value = userNameID;
                //sql.Parameters.Add("@userPassword", SqlDbType.VarChar).Value = userPassword;
                if (Convert.ToInt32(sql.ExecuteScalar()) != 0)
                {
                    //if (!checkManagerExist())
                    //{
                    //if (setStatusLogIn(userNameID))
                    //{
                    //    MyDB.closeConnection();
                    //    return true;
                    //}
                    //else
                    //    return false;
                    return true;
                    //}
                    //else
                    //    return false;


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
        private static bool checkManagerExist()
        {

            MyDB.openConnection();
            SqlCommand sql = new SqlCommand("Select count(*) from Users where userStatus=1", MyDB.getConnection());
            if (Convert.ToInt32(sql.ExecuteScalar()) != 0)
            {
                return true;
            }
            else
                return false;


        }

        public static bool setStatusLogIn(string userNameID)
        {
            try
            {
                SqlCommand sql = new SqlCommand("Update Users set userStatus=1 where userNameID=@userNameID", MyDB.getConnection());
                sql.Parameters.Add("@userNameID", SqlDbType.VarChar).Value = userNameID;
                if (sql.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Users findUserByUsernameID(string userNameID)
        {
            MyDB.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE userNameID = @userNameID", MyDB.getConnection());
            cmd.Parameters.Add("@userNameID", SqlDbType.VarChar).Value = userNameID;
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                int userID = Convert.ToInt32(dt.GetValue(0));
                string userName = dt.GetValue(1).ToString();
                string userNameId = dt.GetValue(2).ToString();
                string userPassword = dt.GetValue(3).ToString();
                int userType = Convert.ToInt32(dt.GetValue(4));
                int userStatus = Convert.ToInt32(dt.GetValue(5));

                MyDB.closeConnection();
                return new Users(userID, userName, userNameId, userPassword, userType, userStatus);
            }
            MyDB.closeConnection();
            return null;
        }
        public static int TotalUser()
        {
            string query = "Select count(*) from Users";
            return Convert.ToInt32(MyDB.ExecuteScalar(query));
        }
        public static DataTable getListUser()
        {
            string query = "Select * from Users";
            return MyDB.ExecuteQuery(query);
        }
        public static Users getUserByID(int id)
        {
            Users u = new Users();
            string query = "Select * from Users where userID=" + id;
            DataTable dt = MyDB.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                u.UserID = Convert.ToInt32(dr["userID"]);
                u.UserName = dr["userName"].ToString();
                u.UserNameID = dr["userNameID"].ToString();
                u.UserPassword = dr["userPassword"].ToString();
                u.UserType = Convert.ToInt32(dr["userID"]);
                u.UserStatus = Convert.ToInt32(dr["userID"]);
            }
            return u;
        }
    }
}
