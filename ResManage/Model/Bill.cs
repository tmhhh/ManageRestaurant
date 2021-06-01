using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Model
{
    class Bill
    {
        private int billID;
        private DateTime? dateCheckin;
        private DateTime? dateCheckout;
        private int billStatus;
        private int discount;
        public int BillID { get => billID; set => billID = value; }
        public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
        public DateTime? DateCheckout { get => dateCheckout; set => dateCheckout = value; }
        public int BillStatus { get => billStatus; set => billStatus = value; }
        public int Discount { get => discount; set => discount = value; }

        public Bill (int billID,DateTime?dateCheckIn, DateTime? dateCheckOut,int billStatus,int discount)
        {
            this.BillID = billID;
            this.DateCheckin = dateCheckIn;
            this.DateCheckout = dateCheckOut;
            this.BillStatus = billStatus;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.BillID = (int)row["billID"];
            this.DateCheckin = (DateTime?)row["DateCheckIn"];
            var dateCheckoutTemp= row["DateCheckOut"];
            if (dateCheckoutTemp.ToString() != "")
            {
                this.DateCheckout = (DateTime?)dateCheckoutTemp;
            }
            
            this.BillStatus = (int)row["billStatus"];
            if (row["billDiscount"].ToString() != "")
            {
                this.Discount = Convert.ToInt32(row["billDiscount"]);
            }
           
        }
    }
}
