using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
    public class BillInfo
    {
        private int billInfoID;
        private int billID;
        private int foodID;
        private int billQuantity;
        public int BillInfoID { get => billInfoID; set => billInfoID = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int BillQuantity { get => billQuantity; set => billQuantity = value; }
        public BillInfo(int billInfoID, int billID, int foodId, int billQuantity)
        {
            this.BillInfoID = billInfoID;
            this.BillID = billID;
            this.FoodID = foodId;
            this.BillQuantity = billQuantity;
        }
        public BillInfo(DataRow row)
        {
            this.BillInfoID = (int)row["billInfoID"];
            this.BillID = (int)row["billID"];
            this.FoodID = (int)row["foodID"];
            this.BillQuantity = (int)row["billQuantity"]; 
        }
    }
}
