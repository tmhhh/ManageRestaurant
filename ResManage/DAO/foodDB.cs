using ResManage.Model;
using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.DAO
{
    class foodDB
    {
        public static int getFoodQuantityByID(int foodID)
        {
            string query = "Select foodQuantity from Food where foodID= " + foodID;
            int result = Convert.ToInt32(MyDB.ExecuteScalar(query));
            return result;

        }
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
            //string query = string.Format("UPDATE Food set foodName=@fname , foodQuantity=@quantity , foodPrice=@price , catID=@catID , foodPic=@fpic", f.FoodName, f.FootQuan, f.FoodPrice, f.CatID, f.FoodPic);
            SqlCommand command = new SqlCommand("UPDATE Food set foodName=@fname , foodQuantity=@quantity , foodPrice=@price , catID=@catID , foodPic=@fpic where foodID=@fid", MyDB.getConnection());
            //int result = MyDB.ExecuteNonQuery(query);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = f.FoodID;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = f.FoodName;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = f.FootQuan;
            command.Parameters.Add("@price", SqlDbType.Float).Value = f.FoodPrice;
            command.Parameters.Add("@catID", SqlDbType.VarChar).Value = f.CatID;
            command.Parameters.Add("@fpic", SqlDbType.Image).Value = f.FoodPic.ToArray();
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
        public static bool Delete(int id)
        {
            string query = "Delete from Food where foodID= " + id;
            int result = MyDB.ExecuteNonQuery(query);
            if (result != 0) return true;
            else return false;
        }
        public static List<Food> getFoodByCatID(int id)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM Food WHERE catID=" + id;
            DataTable data = MyDB.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }
    }
}
