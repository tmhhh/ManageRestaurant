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
    class dailyWageDB
    {
        public static DataTable wageCalculate()
        {
            //MyDB.openConnection();
            SqlCommand sql = new SqlCommand("Exec USP_WageCalculate", MyDB.getConnection());
            MyDB.openConnection();
            sql.ExecuteNonQuery();
            sql = new SqlCommand("Select * from DailyWage", MyDB.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyDB.closeConnection();
            return dt;
        }
    }
}
