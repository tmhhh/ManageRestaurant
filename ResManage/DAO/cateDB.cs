using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
