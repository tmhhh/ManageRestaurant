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
    public class billInfoDB
    {
        public static DataTable getFavoriteDishInDay(DateTime dt)
        {
            string query = "select sum(bi.billQuantity)  as TimeOrder ,Food.foodName,Bill.DateCheckOut as Date from BillInfo bi,Bill,Food "+
"where bi.billID = Bill.billID and bi.foodID = Food.foodID and bill.DateCheckOut = '"+ dt +"'"+" group by Food.foodName,Bill.DateCheckOut ORDER BY sum(bi.billQuantity) DESC" ;
            return MyDB.ExecuteQuery(query);
        }
        public static DataTable getFavoriteDishInMonth(DateTime dt)
        {
            DateTime fDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime lDate = fDate.AddMonths(1).AddDays(-1);

            string query = "select sum(bi.billQuantity)  as TimeOrder ,Food.foodName,Bill.DateCheckOut as Date from BillInfo bi,Bill,Food " +
"where bi.billID = Bill.billID and bi.foodID = Food.foodID and bill.DateCheckOut between '" + fDate + "'" + " and '"+ lDate +"' group by Food.foodName,Bill.DateCheckOut ORDER BY sum(bi.billQuantity) DESC";
            return MyDB.ExecuteQuery(query);
        }
        public static List<BillInfo> getListBillInfo(int id)
        {
            List<BillInfo> listDataBillInfo = new List<BillInfo>();
            string query = "SELECT * FROM dbo.billInfo WHERE billID="+id;
            DataTable data = MyDB.ExecuteQuery(query); 
            foreach(DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                listDataBillInfo.Add(billInfo);
            }
            return listDataBillInfo;

        }
        public static void insertBillInfo(int billID,int foodID,int quantity)
        {
            MyDB.ExecuteNonQuery("EXEC USP_InsertBillInfo @billID , @foodID , @quantity", new object[] {billID,foodID,quantity});
        }
    }
}
