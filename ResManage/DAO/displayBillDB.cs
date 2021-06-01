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
    class displayBillDB
    {
        private displayBillDB()
        {

        }
        public static List<displayBill> getListMenuByTable(int id)
        {
            List<displayBill> listMenu = new List<displayBill>();
            string query = "SELECT f.foodName,bi.billQuantity,f.foodPrice,f.foodPrice*bi.billQuantity as totalPrice" +
                " FROM BillInfo as bi, Bill as b , Food as f" +
                " WHERE bi.billID = b.billID and b.billStatus=0 and bi.foodID = f.foodID and b.tableID = " + id;
            DataTable data = MyDB.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                displayBill displayBill = new displayBill(item);
                listMenu.Add(displayBill);
            }
            return listMenu;
        }
    }
}
