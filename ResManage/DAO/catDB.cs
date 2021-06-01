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
    public class catDB
    {
        public catDB() { }
        public static List<Category> getListCategory()
        {
            List<Category> listcat = new List<Category>();
            string query = "SELECT * FROM Category";
            DataTable data = MyDB.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                listcat.Add(category);
            }
            return listcat;
        }
    }
}
