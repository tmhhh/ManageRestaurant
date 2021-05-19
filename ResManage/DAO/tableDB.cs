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
                Table tmp = new Table(Convert.ToInt32(dr["tableID"]), Convert.ToInt32(dr["tableStatus"]));
                listDataTable.Add(tmp);
            }
            return listDataTable;
        }
    }
}
