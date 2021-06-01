using ResManage.DAO;
using ResManage.Model;
using RestaurantManagement.DAO;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms.UserInfo
{
    public partial class personalpage : Form
    {
        DateTime checkinTime = new DateTime();

        public personalpage()
        {
            InitializeComponent();
            loadUser();
            
        }
        void loadUser()
        {
          List<Users> curUsers = UsersDB.getUser(globalUser.currentUser.UserID);
             foreach(Users u in curUsers) 
             {
                textBoxID.Text = u.UserID.ToString();
                textBoxName.Text = u.UserName.ToString();
                if (u.UserType == 1)
                {
                    textBoxPos.Text = "Manager";
                }
                else
                {
                    textBoxPos.Text = "Waiter";
                }
                if (u.UserStatus == 1)
                {
                    textBoxStatus.Text = "On Shift";
                }
                else
                {
                    textBoxStatus.Text = "Out of Shift";
                }
                dateTimeBD.Value = u.UserBirthDate;
                try
                {
                    Avatar.Image = Image.FromStream(u.UserAvatar);
                }
                catch
                {
                    //MessageBox.Show(Image.FromStream(u.UserAvatar).ToString());
                    Avatar.BackgroundImage = ResManage.Properties.Resources.avatar;
                }
                
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void button_IMG_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
            }
            Avatar.ImageLocation = imageLocation;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int uid = globalUser.currentUser.UserID;
            string uName = textBoxName.Text;
            DateTime uBD = dateTimeBD.Value;
            MemoryStream pic = new MemoryStream();
            Avatar.Image.Save(pic, Avatar.Image.RawFormat);
            if (UsersDB.UpdateUserInEmp(uid,uName,uBD,pic))
            {
                MessageBox.Show("Update successfully !!!");
            }
            else
                MessageBox.Show("Error !!!");
            loadUser();
        }


       
    }
}
