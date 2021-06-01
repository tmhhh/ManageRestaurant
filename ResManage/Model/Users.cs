using System;
using System.Data;
using System.IO;

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
        private DateTime userBirthDate;
        private MemoryStream userAvatar;
        private int timeArrange;
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserNameID { get => userNameID; set => userNameID = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public int UserType { get => userType; set => userType = value; }
        public int UserStatus { get => userStatus; set => userStatus = value; }
        public int TimeArrange { get => timeArrange; set => timeArrange = value; }
        public DateTime UserBirthDate { get => userBirthDate; set => userBirthDate = value; }
        public MemoryStream UserAvatar { get => userAvatar; set => userAvatar = value; }

        public Users()
        { }
        public Users(int userID, string userName, string userNameID, string userPassword,
            int userType, DateTime userBirthDate, MemoryStream userAva)
        {
            this.userID = userID;
            this.userName = userName;
            this.userNameID = userNameID;
            this.userPassword = userPassword;
            this.userType = userType;
            this.userBirthDate = userBirthDate;
            this.userAvatar = userAva;
        }
        public Users(string userName, string userNameID, string userPassword,
          int userType, DateTime userBirthDate, MemoryStream userAva)
        {
            this.userName = userName;
            this.userNameID = userNameID;
            this.userPassword = userPassword;
            this.userType = userType;
            this.userBirthDate = userBirthDate;
            this.userAvatar = userAva;
        }
        public Users(int userID,string userName, string userNameID, string userPassword,
       int userType,int userStatus, DateTime userBirthDate, MemoryStream userAva)
        {
            this.userID = userID;
            this.userStatus = userStatus;
            this.userName = userName;
            this.userNameID = userNameID;
            this.userPassword = userPassword;
            this.userType = userType;
            this.userBirthDate = userBirthDate;
            this.userAvatar = userAva;
        }
        public Users(int userID, string userName, string userNameID, string userPassword,
            int userType, int userStatus)
        {
            this.userID = userID;
            this.userName = userName;
            this.userNameID = userNameID;
            this.userPassword = userPassword;
            this.userType = userType;
            this.userStatus = userStatus;
        }
        public Users(DataRow row)
        {
            this.UserID = (int)row["userID"];
            this.userName = row["userName"].ToString();
            this.UserType = (int)row["userType"];
            this.UserStatus = (int)row["userStatus"];

            if (row["userBirthDate"].ToString() == "" && row["userImage"].ToString() == "")
            {
                this.UserBirthDate = DateTime.Now;
                this.UserAvatar = null;
            }
            else
            {
                byte[] image = (byte[])row["userImage"];
                MemoryStream tempAva = new MemoryStream(image);
                this.UserBirthDate = (DateTime)row["userBirthDate"];
                this.UserAvatar = tempAva;
            }
        }
    }
}
