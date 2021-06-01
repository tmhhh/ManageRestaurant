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
    public static class tableDB
    {
        public static List<Table> getListTable()
        {
            List<Table> listDataTable = new List<Table>();
            string query = "Select * from TableFood";
            DataTable dt = MyDB.ExecuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                Table tmp = new Table(Convert.ToInt32(dr["tableID"]), Convert.ToInt32(dr["tableStatus"]),0);
                listDataTable.Add(tmp);
            }
            return listDataTable;
        }
        public static void switchTable(int id1, int id2)
        {
            MyDB.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });

        }
        public static int getTableQuantityByID(int id)
        {
            string query = "Select quantity from TableFood where tableID=" + id;

            int result= Convert.ToInt32(MyDB.ExecuteScalar(query));
            if (result == null) return 0;
            else return result;

        }
        public static bool setTableQuantity(int quantity,int tableID)
        {
            string query = "update TableFood set quantity="+quantity+" where tableID=" + tableID;
;

            if (MyDB.ExecuteNonQuery(query) > 1)
                return true;
            else
                return false;

        }
    }
}
