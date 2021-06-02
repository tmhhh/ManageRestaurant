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
    class cateDB
    {
        public static DataTable getListCate()
        {
            string query = "Select * from Category";
          return MyDB.ExecuteQuery(query);
        }
        public static bool addCat(string catName)
        {
            SqlCommand command = new SqlCommand("insert into Category values(@catname)", MyDB.getConnection());
            command.Parameters.Add("@catname", SqlDbType.VarChar).Value = catName;
            MyDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public static bool editCat(int catID,string catName)
        {
            SqlCommand command = new SqlCommand("update Category set catName=@catname where catID=@catID)", MyDB.getConnection());
            command.Parameters.Add("@catID", SqlDbType.VarChar).Value = catID;
            command.Parameters.Add("@catname", SqlDbType.VarChar).Value = catName;
            MyDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public static bool deleteCat(int catID)
        {
            SqlCommand command = new SqlCommand("Delete Category where catID=@catID)", MyDB.getConnection());
            command.Parameters.Add("@catID", SqlDbType.VarChar).Value = catID;
            MyDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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

    }
}
