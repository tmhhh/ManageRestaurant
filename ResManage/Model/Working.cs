using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
    public class Working
    {
        private int workingID;
        private int userID;
        private DateTime checkIn;
        private DateTime checkOut;
        private int shift;
        private DateTime workingDate;


        public int WorkingID { get => workingID; set => workingID = value; }
        public int UserID { get => userID; set => userID = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public int Shift { get => shift; set => shift = value; }
        public DateTime WorkingDate { get => workingDate; set => workingDate = value; }

        public Working(int workingID, int userID, DateTime checkIn, DateTime checkOut,int shift)
        {
            this.workingID = workingID;
            this.userID = userID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.shift = shift;
        }
        public Working()
        {

        }
    }
}
