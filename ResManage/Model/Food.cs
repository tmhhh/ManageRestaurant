using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
    public class Food
    {
        private int foodID;
        private string foodName;
        private int footQuan;
        private double foodPrice;
        private int catID;
        private MemoryStream foodPic;

        //public Food(int foodID, string foodName, int footQuan, double foodPrice,int catID,MemoryStream foodPic)
        //{
        //    this.foodID = foodID;
        //    this.foodName = foodName;
        //    this.footQuan = footQuan;
        //    this.foodPrice = foodPrice;
        //    this.catID = catID;
        //    this.foodPic = foodPic;
        //}
        public Food( string foodName, int footQuan, double foodPrice, int catID, MemoryStream foodPic)
        {
            this.foodName = foodName;
            this.footQuan = footQuan;
            this.foodPrice = foodPrice;
            this.catID = catID;
            this.foodPic = foodPic;
        }
        public Food(int foodID,string foodName, int footQuan, double foodPrice, int catID, MemoryStream foodPic)
        {
            this.FoodID = foodID;
            this.FoodName = foodName;
            this.FootQuan = footQuan;
            this.FoodPrice = foodPrice;
            this.CatID = catID;
            this.FoodPic = foodPic;

        }
        public Food(DataRow row)
        {
            this.FoodID = (int)row["foodID"];
            this.FoodName = row["foodName"].ToString();
            this.FootQuan =(int)row["foodQuantity"];
            this.FoodPrice =Convert.ToDouble(row["foodPrice"]);
            this.CatID = (int)row["catID"];
            byte[] image = (byte[])row["foodPic"];
            MemoryStream pic = new MemoryStream(image);
            this.FoodPic = pic;
        }

        public Food()
        {
        }

        public int FoodID { get => foodID; set => foodID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int FootQuan { get => footQuan; set => footQuan = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }
        public int CatID { get => catID; set => catID = value; }
        public MemoryStream FoodPic { get => foodPic; set => foodPic = value; }
    }
}
