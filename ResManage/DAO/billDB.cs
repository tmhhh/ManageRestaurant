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
    public class billDB
    {
        public static int getUncheckBillByTbID(int id)
        {
            string query = "SELECT * FROM dbo.BILL WHERE tableID=" + id + " and billStatus=0";
            DataTable data= MyDB.ExecuteQuery(query);
            if (data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillID;
            }
            return -1;
        }

        public static void checkOut(int id,int discount,double totalBill)
        {
            string query = "UPDATE Bill SET Bill.billStatus = 1, Bill.DateCheckOut=getdate(), "+ " Bill.billDiscount = " + discount +", totalBill= "+totalBill+"   WHERE Bill.billID = " + id;
            MyDB.ExecuteNonQuery(query);
        }
        public static void insertBill(int id)
        {
            MyDB.ExecuteNonQuery("EXEC USP_InsertBill @idTable",new object[] {id});

        }
        public static int getMaxBillID()
        {
            try
            {
               return (int)MyDB.ExecuteScalar("SELECT MAX(billID) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public static DataTable getBillByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            return MyDB.ExecuteQuery("exec USP_getBillByDate @dateCheckIn , @dateCheckOut ",new object[] { dateCheckIn,dateCheckOut});
        }
    }
}
