using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
    class displayBill
    {
        private string foodName;
        private int quantity;
        private double unitPrice;
        private double totalPrice;
        public string FoodName { get => foodName; set => foodName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public displayBill(string foodName, int quantity, float unitPrice, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalPrice;
        }
        public displayBill(DataRow row)
        {
            this.FoodName = row["foodName"].ToString();
            this.Quantity = (int)row["billQuantity"];
            this.UnitPrice = Convert.ToDouble(row["foodPrice"]);
            this.TotalPrice = Convert.ToDouble(row["totalPrice"]);
        }
    }
}
