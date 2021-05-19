using ResManage.Model;
using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.DAO
{
    class foodDB
    {
        public static bool insertFood(Food f)
        {
            string query = "EXECUTE USP_AddFood @foodName , @foodQuantity , @foodPrice , @catID , @foodPic ";

            int result = MyDB.ExecuteNonQuery(query, new object[] { f.FoodName, f.FootQuan, f.FoodPrice, f.CatID, f.FoodPic.ToArray() });
            if (result != 0) return true;
            else return false;
        }
        public static DataTable getList()
        {
            string query = "Select * from Food ";
            return MyDB.ExecuteQuery(query);

        }
        public static DataTable search(string input)
        {
            string query = "Select * from Food where foodName LIKE '%" + input + "%' OR foodID LIKE '%" + input + "%'";
            return MyDB.ExecuteQuery(query);

        }
        public static Food getFoodByID(int id)
        {
            Food f = new Food();
            string query = "Select * from Food where foodID=" + id;
            DataTable dt = MyDB.ExecuteQuery(query);
            //if(dt.Rows.Count>1)
            //{
            foreach (DataRow dr in dt.Rows)
            {
                f.FoodID = (int)dr["foodID"];
                f.FoodName = dr["foodName"].ToString();
                f.FootQuan = (int)dr["foodQuantity"];
                f.FoodPrice = Convert.ToDouble(dr["foodPrice"]);
                f.CatID = (int)dr["catID"];
                byte[] image = (byte[])dr["foodPic"];
                MemoryStream pic = new MemoryStream(image);
                f.FoodPic = pic;
            }
            return f;
            //}
            //return null;

        }
        public static bool Update(Food f)
        {
            string query = string.Format("UPDATE Food set foodName={0}, foodQuantity={1}, foodPrice={2}, catID={3}, foodPic={4}", new object[] { f.FoodName, f.FootQuan, f.FoodPrice, f.CatID, f.FoodPic });
            int result = MyDB.ExecuteNonQuery(query);
            if (result != 0) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            string query = "Delete from Food where foodID= " + id;
            int result = MyDB.ExecuteNonQuery(query);
            if (result != 0) return true;
            else return false;
        }
    }
}
