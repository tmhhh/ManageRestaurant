using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    public class Users
    {
        private int userID;
        private string userName;
        private string userNameID;
        private string userPassword;
        private int userType;
        private int userStatus;

        private int timeArrange;
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserNameID { get => userNameID; set => userNameID = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public int UserType { get => userType; set => userType = value; }
        public int UserStatus { get => userStatus; set => userStatus = value; }
        public int TimeArrange { get => timeArrange; set => timeArrange = value; }

        public Users()
        { }
        public Users(int userID, string userName, string userNameID, string userPassword,
            int userType,int userStatus)
        {
            this.userID = userID;
            this.userName = userName;
            this.userNameID = userNameID;
            this.userPassword = userPassword;
            this.userType = userType;
            this.userStatus = userStatus;
        }
    }
}
